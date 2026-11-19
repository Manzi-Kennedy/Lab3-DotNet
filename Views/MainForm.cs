using TaskLink.Controllers;
using TaskLink.Models;

namespace TaskLink.Views;

public partial class MainForm : Form
{
    private const int PageSize = 10;
    private int _page = 1, _totalPages = 1;
    public bool LoggedOut { get; private set; }
    private static User Me => Session.Current!;

    public MainForm() { InitializeComponent(); }

    private void MainForm_Load(object? sender, EventArgs e)
    {
        lblWelcome.Text = $"Signed in as {Me.Name} ({Me.Role})";
        cmbCategory.Items.Add("All categories");
        cmbCategory.Items.AddRange(TaskController.Categories);
        cmbCategory.SelectedIndex = 0; cmbSort.SelectedIndex = 0;
        if (Me.Role != "ADMIN") tabs.TabPages.Remove(tabAdmin);
        LoadBrowse();
    }

    private void btnLogout_Click(object? sender, EventArgs e) { LoggedOut = true; Session.Current = null; Close(); }

    private void tabs_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (tabs.SelectedTab == tabBrowse) LoadBrowse();
        else if (tabs.SelectedTab == tabMine) LoadMine();
        else if (tabs.SelectedTab == tabProfile) LoadProfile();
        else if (tabs.SelectedTab == tabAdmin) LoadReports();
    }

    // ---------------- Browse ----------------
    private void LoadBrowse()
    {
        var list = TaskController.Search(txtKeyword.Text, cmbCategory.Text, txtLocation.Text, cmbSort.Text, _page, PageSize, out int total);
        _totalPages = Math.Max(1, (int)Math.Ceiling(total / (double)PageSize));
        dgvBrowse.DataSource = list;
        UiHelper.Hide(dgvBrowse, "Id", "Description", "PosterId", "PosterEmail", "HelperId", "HelperName", "HelperEmail", "CompletedAt", "Status");
        lblPage.Text = $"Page {_page}/{_totalPages}  ({total} open tasks)";
    }
    private void btnSearch_Click(object? sender, EventArgs e) { _page = 1; LoadBrowse(); }
    private void btnClear_Click(object? sender, EventArgs e)
    { txtKeyword.Clear(); txtLocation.Clear(); cmbCategory.SelectedIndex = 0; cmbSort.SelectedIndex = 0; _page = 1; LoadBrowse(); }
    private void btnPrev_Click(object? sender, EventArgs e) { if (_page > 1) { _page--; LoadBrowse(); } }
    private void btnNext_Click(object? sender, EventArgs e) { if (_page < _totalPages) { _page++; LoadBrowse(); } }

    private void btnDetails_Click(object? sender, EventArgs e) => ShowDetails(UiHelper.Selected<TaskItem>(dgvBrowse));
    private void dgvBrowse_CellDoubleClick(object? sender, DataGridViewCellEventArgs e) => ShowDetails(UiHelper.Selected<TaskItem>(dgvBrowse));

    private void ShowDetails(TaskItem? sel)
    {
        if (sel == null) return;
        var t = TaskController.GetById(sel.Id); if (t == null) return;
        var s = $"{t.Title}\n\nStatus: {t.Status}\nCategory: {t.Category}\nLocation: {t.Location}\nDeadline: {t.Deadline:yyyy-MM-dd HH:mm}\n" +
                $"Posted by: {t.PosterName} (rating {t.PosterRating:0.00})\n\n{t.Description}";
        if (t.HelperId == Me.Id) s += $"\n\nPoster contact: {t.PosterEmail}";
        if (t.PosterId == Me.Id && t.HelperName != null) s += $"\n\nClaimed by: {t.HelperName} ({t.HelperEmail})";
        UiHelper.Info(s);
    }

    private void btnClaim_Click(object? sender, EventArgs e)
    {
        var t = UiHelper.Selected<TaskItem>(dgvBrowse); if (t == null) return;
        var err = TaskController.Claim(t.Id, Me.Id);
        if (err != null) UiHelper.Error(err);
        else UiHelper.Info($"Task claimed! Contact the poster at {t.PosterEmail}.");
        LoadBrowse();
    }

    private void btnReport_Click(object? sender, EventArgs e)
    {
        var t = UiHelper.Selected<TaskItem>(dgvBrowse); if (t == null) return;
        var reason = UiHelper.Prompt("Report task", "Why is this task inappropriate or suspicious?");
        if (reason == null) return;
        var err = TaskController.Report(t.Id, Me.Id, reason);
        if (err != null) UiHelper.Error(err); else UiHelper.Info("Thank you. An admin will review this task.");
        LoadBrowse();
    }

    // ---------------- My tasks ----------------
    private void LoadMine()
    {
        dgvPosted.DataSource = TaskController.Posted(Me.Id);
        UiHelper.Hide(dgvPosted, "Id", "Description", "PosterId", "PosterName", "PosterEmail", "PosterRating", "HelperId");
        dgvHelping.DataSource = TaskController.Helping(Me.Id);
        UiHelper.Hide(dgvHelping, "Id", "Description", "PosterId", "PosterRating", "HelperId", "HelperName", "HelperEmail");
    }

    private void btnNewTask_Click(object? sender, EventArgs e)
    { using var f = new TaskEditForm(); if (f.ShowDialog(this) == DialogResult.OK) LoadMine(); }

    private void btnEditTask_Click(object? sender, EventArgs e)
    {
        var t = UiHelper.Selected<TaskItem>(dgvPosted); if (t == null) return;
        if (t.Status != "OPEN") { UiHelper.Error("Only OPEN tasks can be edited."); return; }
        using var f = new TaskEditForm(t); if (f.ShowDialog(this) == DialogResult.OK) LoadMine();
    }

    private void btnCancelTask_Click(object? sender, EventArgs e)
    {
        var t = UiHelper.Selected<TaskItem>(dgvPosted); if (t == null || !UiHelper.Confirm($"Cancel \"{t.Title}\"?")) return;
        var err = TaskController.Cancel(t.Id, Me.Id); if (err != null) UiHelper.Error(err); LoadMine();
    }

    private void btnComplete_Click(object? sender, EventArgs e)
    {
        var t = UiHelper.Selected<TaskItem>(dgvPosted); if (t == null) return;
        var err = TaskController.Complete(t.Id, Me.Id); if (err != null) UiHelper.Error(err); else UiHelper.Info("Task marked as completed. You can now rate the helper."); LoadMine();
    }

    private void btnRateHelper_Click(object? sender, EventArgs e)
    {
        var t = UiHelper.Selected<TaskItem>(dgvPosted); if (t == null) return;
        Rate(t, t.HelperName ?? "helper");
    }

    private void btnWithdraw_Click(object? sender, EventArgs e)
    {
        var t = UiHelper.Selected<TaskItem>(dgvHelping); if (t == null || !UiHelper.Confirm($"Withdraw from \"{t.Title}\"?")) return;
        var err = TaskController.Withdraw(t.Id, Me.Id); if (err != null) UiHelper.Error(err); LoadMine();
    }

    private void btnRatePoster_Click(object? sender, EventArgs e)
    {
        var t = UiHelper.Selected<TaskItem>(dgvHelping); if (t == null) return;
        Rate(t, t.PosterName);
    }

    private void Rate(TaskItem t, string who)
    {
        if (t.Status != "COMPLETED") { UiHelper.Error("You can only rate after the task is COMPLETED."); return; }
        using var f = new RatingForm(who);
        if (f.ShowDialog(this) != DialogResult.OK) return;
        var err = ReviewController.Submit(t.Id, Me.Id, f.Score, f.CommentText);
        if (err != null) UiHelper.Error(err); else UiHelper.Info("Rating submitted. Thank you!");
    }

    // ---------------- Profile ----------------
    private void LoadProfile()
    {
        var u = AuthController.GetUser(Me.Id)!; Session.Current = u;
        lblProfileInfo.Text = $"Name: {u.Name}\nEmail: {u.Email}\nMember since: {u.CreatedAt:yyyy-MM-dd}\nAverage rating: {u.AvgRating:0.00}\nNumber of ratings: {u.RatingCount}";
        txtProfileName.Text = u.Name; txtNewPassword.Clear();
        dgvReviews.DataSource = ReviewController.ForUser(u.Id);
    }

    private void btnSaveProfile_Click(object? sender, EventArgs e)
    {
        var err = AuthController.UpdateProfile(Me.Id, txtProfileName.Text, txtNewPassword.Text);
        if (err != null) { UiHelper.Error(err); return; }
        UiHelper.Info("Profile updated."); LoadProfile();
        lblWelcome.Text = $"Signed in as {Me.Name} ({Me.Role})";
    }

    // ---------------- Admin ----------------
    private void LoadReports()
    {
        dgvReports.DataSource = AdminController.Reports();
        UiHelper.Hide(dgvReports, "report_id", "task_id", "poster_id");
    }
    private int? Cell(string col) => dgvReports.CurrentRow == null ? null : Convert.ToInt32(dgvReports.CurrentRow.Cells[col].Value);

    private void btnDismiss_Click(object? sender, EventArgs e)
    { if (Cell("report_id") is int id) { AdminController.Dismiss(id); LoadReports(); } }

    private void btnRemoveTask_Click(object? sender, EventArgs e)
    { if (Cell("task_id") is int id && UiHelper.Confirm("Remove this task?")) { AdminController.RemoveTask(id); LoadReports(); } }

    private void btnDeactivate_Click(object? sender, EventArgs e)
    {
        if (Cell("poster_id") is not int id || !UiHelper.Confirm("Deactivate the poster's account?")) return;
        var err = AdminController.DeactivateUser(id); if (err != null) UiHelper.Error(err); else UiHelper.Info("Account deactivated.");
    }

    private void btnRefreshAdmin_Click(object? sender, EventArgs e) => LoadReports();
}
