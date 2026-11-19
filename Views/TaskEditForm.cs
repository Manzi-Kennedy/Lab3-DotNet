using TaskLink.Controllers;
using TaskLink.Models;

namespace TaskLink.Views;

public partial class TaskEditForm : Form
{
    private readonly TaskItem? _existing;

    public TaskEditForm(TaskItem? existing = null)
    {
        InitializeComponent();
        _existing = existing;
        cmbCategory.Items.AddRange(TaskController.Categories);
        cmbCategory.SelectedIndex = 0;
        dtpDeadline.Value = DateTime.Now.AddDays(1);
        Text = existing == null ? "New task" : "Edit task";
        if (existing != null)
        {
            txtTitle.Text = existing.Title; txtDescription.Text = existing.Description;
            cmbCategory.SelectedItem = existing.Category; txtLocation.Text = existing.Location;
            dtpDeadline.Value = existing.Deadline;
        }
    }

    private void btnSave_Click(object? sender, EventArgs e)
    {
        var t = new TaskItem
        {
            Id = _existing?.Id ?? 0, Title = txtTitle.Text, Description = txtDescription.Text,
            Category = cmbCategory.SelectedItem?.ToString() ?? "", Location = txtLocation.Text, Deadline = dtpDeadline.Value
        };
        var uid = Session.Current!.Id;
        var err = _existing == null ? TaskController.Create(t, uid) : TaskController.Update(t, uid);
        if (err != null) { UiHelper.Error(err); return; }
        DialogResult = DialogResult.OK;
    }
}
