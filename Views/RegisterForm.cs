using TaskLink.Controllers;

namespace TaskLink.Views;

public partial class RegisterForm : Form
{
    public string RegisteredEmail { get; private set; } = "";
    public RegisterForm() { InitializeComponent(); }

    private void btnRegister_Click(object? sender, EventArgs e)
    {
        var err = AuthController.Register(txtName.Text, txtEmail.Text, txtPassword.Text, txtConfirm.Text);
        if (err != null) { UiHelper.Error(err); return; }
        RegisteredEmail = txtEmail.Text.Trim();
        UiHelper.Info("Account created. You can now log in.");
        DialogResult = DialogResult.OK;
    }
}
