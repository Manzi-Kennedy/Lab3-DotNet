namespace TaskLink.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public decimal AvgRating { get; set; }
        public int RatingCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsAdmin => Role == "ADMIN";
    }

    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime Deadline { get; set; }
        public string Status { get; set; } = string.Empty;
        public string PosterName { get; set; } = string.Empty;
        public decimal PosterRating { get; set; }
        public string? HelperName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        // Hidden columns (not shown in grids)
        public string Description { get; set; } = string.Empty;
        public int PosterId { get; set; }
        public int? HelperId { get; set; }
        public string PosterEmail { get; set; } = string.Empty;
        public string? HelperEmail { get; set; }
    }

    public class ReviewItem
    {
        public int Id { get; set; }
        public string From { get; set; } = string.Empty;
        public string Task { get; set; } = string.Empty;
        public int Score { get; set; }
        public string? Comment { get; set; }
        public DateTime Date { get; set; }
    }

    public class ReportItem
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string TaskTitle { get; set; } = string.Empty;
        public string TaskStatus { get; set; } = string.Empty;
        public string Reporter { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
        public DateTime ReportedAt { get; set; }
        public string ReportStatus { get; set; } = string.Empty;
        public int PosterId { get; set; }
    }

    public class Result
    {
        public bool Ok { get; private set; }
        public string Message { get; private set; } = string.Empty;
        public static Result Success(string msg = "") => new Result { Ok = true, Message = msg };
        public static Result Fail(string msg) => new Result { Ok = false, Message = msg };
    }

    public static class Session
    {
        public static User? Current { get; set; }
        public static User? CurrentUser
        {
            get => Current;
            set => Current = value;
        }
        public static void Logout() => Current = null;
    }
}
