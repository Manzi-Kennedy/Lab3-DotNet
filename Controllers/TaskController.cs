using System.Data;
using TaskLink.Data;
using TaskLink.Models;

namespace TaskLink.Controllers;

public static class TaskController
{
    public static readonly string[] Categories = { "Moving", "Tutoring", "Device Fix", "Errand", "Cleaning", "Other" };

    const string Base = @"SELECT t.*, p.name poster_name, p.email poster_email, p.avg_rating poster_rating,
        h.name helper_name, h.email helper_email
        FROM tasks t JOIN users p ON p.id=t.poster_id LEFT JOIN users h ON h.id=t.helper_id";

    static TaskItem Map(DataRow r) => new()
    {
        Id = Convert.ToInt32(r["id"]), Title = r["title"].ToString()!, Description = r["description"].ToString()!,
        Category = r["category"].ToString()!, Location = r["location"].ToString()!,
        Deadline = Convert.ToDateTime(r["deadline"]), Status = r["status"].ToString()!,
        PosterId = Convert.ToInt32(r["poster_id"]), PosterName = r["poster_name"].ToString()!,
        PosterEmail = r["poster_email"].ToString()!, PosterRating = Convert.ToDecimal(r["poster_rating"]),
        HelperId = r["helper_id"] == DBNull.Value ? null : Convert.ToInt32(r["helper_id"]),
        HelperName = r["helper_name"] == DBNull.Value ? null : r["helper_name"].ToString(),
        HelperEmail = r["helper_email"] == DBNull.Value ? null : r["helper_email"].ToString(),
        CompletedAt = r["completed_at"] == DBNull.Value ? null : Convert.ToDateTime(r["completed_at"]),
        CreatedAt = Convert.ToDateTime(r["created_at"])
    };

    static List<TaskItem> List(DataTable dt) => dt.Rows.Cast<DataRow>().Select(Map).ToList();

    /// FR-2.6 - mark OPEN tasks whose deadline passed as EXPIRED
    public static void ExpireOld() => Db.Exec("UPDATE tasks SET status='EXPIRED' WHERE status='OPEN' AND deadline<NOW()");

    public static TaskItem? GetById(int id)
    {
        var dt = Db.Query(Base + " WHERE t.id=@i", ("@i", id));
        return dt.Rows.Count == 0 ? null : Map(dt.Rows[0]);
    }

    // FR-3: paginated, filtered, searchable list of OPEN tasks
    public static List<TaskItem> Search(string keyword, string category, string location, string sort, int page, int size, out int total)
    {
        ExpireOld();
        var where = "t.status='OPEN'"; var ps = new List<(string, object?)>();
        if (!string.IsNullOrWhiteSpace(keyword)) { where += " AND (t.title LIKE @k OR t.description LIKE @k)"; ps.Add(("@k", "%" + keyword.Trim() + "%")); }
        if (!string.IsNullOrWhiteSpace(category) && category != "All categories") { where += " AND t.category=@c"; ps.Add(("@c", category)); }
        if (!string.IsNullOrWhiteSpace(location)) { where += " AND t.location LIKE @l"; ps.Add(("@l", "%" + location.Trim() + "%")); }
        var order = sort == "Deadline soonest" ? "t.deadline ASC" : "t.created_at DESC";
        total = Convert.ToInt32(Db.Scalar($"SELECT COUNT(*) FROM tasks t WHERE {where}", ps.ToArray()));
        return List(Db.Query($"{Base} WHERE {where} ORDER BY {order} LIMIT {size} OFFSET {(page - 1) * size}", ps.ToArray()));
    }

    public static List<TaskItem> Posted(int userId) { ExpireOld(); return List(Db.Query(Base + " WHERE t.poster_id=@u AND t.status<>'REMOVED' ORDER BY t.created_at DESC", ("@u", userId))); }
    public static List<TaskItem> Helping(int userId) => List(Db.Query(Base + " WHERE t.helper_id=@u ORDER BY t.created_at DESC", ("@u", userId)));

    static string? Validate(TaskItem t)
    {
        if (string.IsNullOrWhiteSpace(t.Title) || string.IsNullOrWhiteSpace(t.Description) ||
            string.IsNullOrWhiteSpace(t.Category) || string.IsNullOrWhiteSpace(t.Location))
            return "Title, description, category and location are required.";
        if (t.Deadline <= DateTime.Now) return "Deadline must be in the future.";
        return null;
    }

    public static string? Create(TaskItem t, int posterId)
    {
        var err = Validate(t); if (err != null) return err;
        Db.Exec("INSERT INTO tasks(title,description,category,location,deadline,status,poster_id) VALUES(@t,@d,@c,@l,@dl,'OPEN',@p)",
            ("@t", t.Title.Trim()), ("@d", t.Description.Trim()), ("@c", t.Category), ("@l", t.Location.Trim()), ("@dl", t.Deadline), ("@p", posterId));
        return null;
    }

    public static string? Update(TaskItem t, int userId)
    {
        var err = Validate(t); if (err != null) return err;
        var n = Db.Exec("UPDATE tasks SET title=@t,description=@d,category=@c,location=@l,deadline=@dl WHERE id=@i AND poster_id=@u AND status='OPEN'",
            ("@t", t.Title.Trim()), ("@d", t.Description.Trim()), ("@c", t.Category), ("@l", t.Location.Trim()), ("@dl", t.Deadline), ("@i", t.Id), ("@u", userId));
        return n == 1 ? null : "Only your own OPEN tasks can be edited.";
    }

    public static string? Cancel(int taskId, int userId) =>
        Db.Exec("DELETE FROM tasks WHERE id=@i AND poster_id=@u AND status='OPEN'", ("@i", taskId), ("@u", userId)) == 1
            ? null : "Only your own OPEN tasks can be cancelled.";

    // FR-4: claim (atomic UPDATE prevents double claims, even concurrent ones)
    public static string? Claim(int taskId, int userId)
    {
        var t = GetById(taskId);
        if (t == null) return "Task not found.";
        if (t.PosterId == userId) return "You cannot claim your own task.";
        using var c = Db.Open(); using var tx = c.BeginTransaction();
        var n = Db.Exec(c, tx, "UPDATE tasks SET status='CLAIMED', helper_id=@u WHERE id=@i AND status='OPEN' AND poster_id<>@u AND deadline>NOW()", ("@u", userId), ("@i", taskId));
        if (n != 1) { tx.Rollback(); return "This task is no longer available."; }
        Db.Exec(c, tx, "INSERT INTO claims(task_id,helper_id) VALUES(@i,@u)", ("@i", taskId), ("@u", userId));
        tx.Commit(); return null;
    }

    public static string? Withdraw(int taskId, int userId)
    {
        using var c = Db.Open(); using var tx = c.BeginTransaction();
        var n = Db.Exec(c, tx, "UPDATE tasks SET status='OPEN', helper_id=NULL WHERE id=@i AND helper_id=@u AND status='CLAIMED'", ("@i", taskId), ("@u", userId));
        if (n != 1) { tx.Rollback(); return "You can only withdraw from a task you have claimed."; }
        Db.Exec(c, tx, "UPDATE claims SET withdrawn_at=NOW() WHERE task_id=@i AND helper_id=@u AND withdrawn_at IS NULL", ("@i", taskId), ("@u", userId));
        tx.Commit(); return null;
    }

    public static string? Complete(int taskId, int userId) =>
        Db.Exec("UPDATE tasks SET status='COMPLETED', completed_at=NOW() WHERE id=@i AND poster_id=@u AND status='CLAIMED'", ("@i", taskId), ("@u", userId)) == 1
            ? null : "Only the poster can complete a CLAIMED task.";

    // FR-8.1 / 8.2
    public static string? Report(int taskId, int userId, string reason)
    {
        if (string.IsNullOrWhiteSpace(reason)) return "A reason is required.";
        var t = GetById(taskId); if (t == null) return "Task not found.";
        string prev;
        if (t.Status == "OPEN" || t.Status == "CLAIMED") prev = t.Status;
        else if (t.Status == "FLAGGED") prev = Db.Scalar("SELECT prev_status FROM reports WHERE task_id=@i AND status='PENDING' LIMIT 1", ("@i", taskId))?.ToString() ?? "OPEN";
        else return "This task cannot be reported.";
        using var c = Db.Open(); using var tx = c.BeginTransaction();
        Db.Exec(c, tx, "INSERT INTO reports(task_id,reporter_id,reason,prev_status) VALUES(@t,@u,@r,@p)", ("@t", taskId), ("@u", userId), ("@r", reason.Trim()), ("@p", prev));
        Db.Exec(c, tx, "UPDATE tasks SET status='FLAGGED' WHERE id=@t", ("@t", taskId));
        tx.Commit(); return null;
    }
}
