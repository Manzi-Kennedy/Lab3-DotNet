namespace TaskLink.Views;

public partial class RatingForm : Form
{
    public int Score => (int)numScore.Value;
    public string CommentText => txtComment.Text;

    public RatingForm(string targetName) { InitializeComponent(); lblTarget.Text = "Rate: " + targetName; }

    private void btnSubmit_Click(object? sender, EventArgs e) => DialogResult = DialogResult.OK;
}
