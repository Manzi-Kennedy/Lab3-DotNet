namespace TaskLink.Views;

public static class UiHelper
{
    public static void Info(string m) => MessageBox.Show(m, "TaskLink", MessageBoxButtons.OK, MessageBoxIcon.Information);
    public static void Error(string m) => MessageBox.Show(m, "TaskLink", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    public static bool Confirm(string m) => MessageBox.Show(m, "TaskLink", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

    public static T? Selected<T>(DataGridView g) where T : class => g.CurrentRow?.DataBoundItem as T;

    public static void Hide(DataGridView g, params string[] cols)
    { foreach (var c in cols) if (g.Columns[c] != null) g.Columns[c]!.Visible = false; }

    /// <summary>Small code-built dialog asking for one line of text (used for report reason).</summary>
    public static string? Prompt(string title, string label)
    {
        using var f = new Form { Text = title, ClientSize = new Size(380, 130), StartPosition = FormStartPosition.CenterParent,
            FormBorderStyle = FormBorderStyle.FixedDialog, MaximizeBox = false, MinimizeBox = false };
        var l = new Label { Text = label, Location = new Point(12, 12), AutoSize = true };
        var t = new TextBox { Location = new Point(12, 38), Size = new Size(356, 23) };
        var ok = new Button { Text = "OK", DialogResult = DialogResult.OK, Location = new Point(212, 85), Size = new Size(75, 28) };
        var cancel = new Button { Text = "Cancel", DialogResult = DialogResult.Cancel, Location = new Point(293, 85), Size = new Size(75, 28) };
        f.Controls.AddRange(new Control[] { l, t, ok, cancel });
        f.AcceptButton = ok; f.CancelButton = cancel;
        return f.ShowDialog() == DialogResult.OK ? t.Text : null;
    }
}
