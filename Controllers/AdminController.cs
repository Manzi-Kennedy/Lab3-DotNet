using System.Data;
using TaskLink.Data;

namespace TaskLink.Controllers;

public static class AdminController
{
    /// FR-1.8 - seeds a default admin (admin@tasklink.com / Admin@123) if none exists.
    public static void EnsureAdmin()
    {
        if (Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM users WHERE role='ADMIN'")) > 0) return;
        Db.Exec("INSERT INTO users(name,email,password_hash,role) VALUES('Administrator','admin@tasklink.com',@p,'ADMIN')",
            ("@p", BCrypt.Net.BCrypt.HashPassword("Admin@123")));
    }

    public static DataTable Reports() => Db.Query(
        @"SELECT r.id AS report_id, t.id AS task_id, t.title AS Title, u.name AS Reporter, r.reason AS Reason,
                 t.status AS TaskStatus, p.id AS poster_id, p.name AS Poster, r.created_at AS Reported
          FROM reports r JOIN tasks t ON t.id=r.task_id JOIN users u ON u.id=r.reporter_id JOIN users p ON p.id=t.poster_id
          WHERE r.status='PENDING' ORDER BY r.created_at DESC");

    public static void Dismiss(int reportId)
    {
        var dt = Db.Query("SELECT task_id, prev_status FROM reports WHERE id=@i", ("@i", reportId));
        if (dt.Rows.Count == 0) return;
        int taskId = Convert.ToInt32(dt.Rows[0]["task_id"]); string prev = dt.Rows[0]["prev_status"].ToString()!;
        Db.Exec("UPDATE reports SET status='DISMISSED' WHERE id=@i", ("@i", reportId));
        if (Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM reports WHERE task_id=@t AND status='PENDING'", ("@t", taskId))) == 0)
            Db.Exec("UPDATE tasks SET status=@s WHERE id=@t AND status='FLAGGED'", ("@s", prev), ("@t", taskId));
    }

    public static void RemoveTask(int taskId)
    {
        Db.Exec("UPDATE tasks SET status='REMOVED' WHERE id=@t", ("@t", taskId));
        Db.Exec("UPDATE reports SET status='REMOVED' WHERE task_id=@t AND status='PENDING'", ("@t", taskId));
    }

    public static string? DeactivateUser(int userId)
    {
        if (Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM users WHERE id=@i AND role='ADMIN'", ("@i", userId))) > 0)
            return "Administrators cannot be deactivated.";
        Db.Exec("UPDATE users SET is_active=0 WHERE id=@i", ("@i", userId)); return null;
    }
}
