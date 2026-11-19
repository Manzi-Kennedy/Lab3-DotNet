using System.Data;
using TaskLink.Data;

namespace TaskLink.Controllers;

public static class ReviewController
{
    public static string? Submit(int taskId, int raterId, int score, string comment)
    {
        if (score < 1 || score > 5) return "Score must be between 1 and 5.";
        var t = TaskController.GetById(taskId);
        if (t == null || t.Status != "COMPLETED") return "You can only rate after the task is COMPLETED.";
        int rateeId;
        if (raterId == t.PosterId && t.HelperId != null) rateeId = t.HelperId.Value;
        else if (raterId == t.HelperId) rateeId = t.PosterId;
        else return "Only the poster and the helper of this task can rate.";
        if (Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM ratings WHERE task_id=@t AND rater_id=@r", ("@t", taskId), ("@r", raterId))) > 0)
            return "You have already rated this task.";
        using var c = Db.Open(); using var tx = c.BeginTransaction();
        Db.Exec(c, tx, "INSERT INTO ratings(task_id,rater_id,rated_id,score,comment) VALUES(@t,@r,@e,@s,@c)",
            ("@t", taskId), ("@r", raterId), ("@e", rateeId), ("@s", score), ("@c", string.IsNullOrWhiteSpace(comment) ? null : comment.Trim()));
        // FR-6.4 recalculate average
        Db.Exec(c, tx, @"UPDATE users SET
            avg_rating=(SELECT IFNULL(AVG(score),0) FROM ratings WHERE rated_id=@e),
            rating_count=(SELECT COUNT(*) FROM ratings WHERE rated_id=@e) WHERE id=@e", ("@e", rateeId));
        tx.Commit(); return null;
    }

    public static DataTable ForUser(int userId) => Db.Query(
        @"SELECT u.name AS Reviewer, r.score AS Score, r.comment AS Comment, t.title AS Task, r.created_at AS Date
          FROM ratings r JOIN users u ON u.id=r.rater_id JOIN tasks t ON t.id=r.task_id
          WHERE r.rated_id=@u ORDER BY r.created_at DESC", ("@u", userId));
}
