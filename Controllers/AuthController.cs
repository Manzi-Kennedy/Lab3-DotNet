using System.Data;
using TaskLink.Data;
using TaskLink.Models;

namespace TaskLink.Controllers;

public static class AuthController
{
    public static string? Register(string name, string email, string password, string confirm)
    {
        name = name.Trim(); email = email.Trim().ToLowerInvariant();
        if (name.Length == 0) return "Name is required.";
        if (!IsEmail(email)) return "Email is not well-formed.";
        if (password.Length < 8) return "Password must be at least 8 characters.";
        if (password != confirm) return "Passwords do not match.";
        if (Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM users WHERE email=@e", ("@e", email))) > 0)
            return "That email is already registered.";
        Db.Exec("INSERT INTO users(name,email,password_hash,role) VALUES(@n,@e,@p,'USER')",
            ("@n", name), ("@e", email), ("@p", BCrypt.Net.BCrypt.HashPassword(password)));
        return null;
    }

    public static (User? user, string? error) Login(string email, string password)
    {
        var dt = Db.Query("SELECT * FROM users WHERE email=@e", ("@e", email.Trim().ToLowerInvariant()));
        if (dt.Rows.Count == 0 || !BCrypt.Net.BCrypt.Verify(password, dt.Rows[0]["password_hash"].ToString()))
            return (null, "Invalid email or password.");
        if (!Convert.ToBoolean(dt.Rows[0]["is_active"])) return (null, "This account has been deactivated.");
        return (Map(dt.Rows[0]), null);
    }

    public static User? GetUser(int id)
    {
        var dt = Db.Query("SELECT * FROM users WHERE id=@i", ("@i", id));
        return dt.Rows.Count == 0 ? null : Map(dt.Rows[0]);
    }

    public static string? UpdateProfile(int id, string name, string newPassword)
    {
        if (string.IsNullOrWhiteSpace(name)) return "Name is required.";
        if (newPassword.Length > 0 && newPassword.Length < 8) return "Password must be at least 8 characters.";
        Db.Exec("UPDATE users SET name=@n WHERE id=@i", ("@n", name.Trim()), ("@i", id));
        if (newPassword.Length > 0)
            Db.Exec("UPDATE users SET password_hash=@p WHERE id=@i", ("@p", BCrypt.Net.BCrypt.HashPassword(newPassword)), ("@i", id));
        return null;
    }

    static bool IsEmail(string e)
    { try { return new System.Net.Mail.MailAddress(e).Address == e; } catch { return false; } }

    static User Map(DataRow r) => new()
    {
        Id = Convert.ToInt32(r["id"]), Name = r["name"].ToString()!, Email = r["email"].ToString()!,
        Role = r["role"].ToString()!, IsActive = Convert.ToBoolean(r["is_active"]),
        AvgRating = Convert.ToDecimal(r["avg_rating"]), RatingCount = Convert.ToInt32(r["rating_count"]),
        CreatedAt = Convert.ToDateTime(r["created_at"])
    };
}
