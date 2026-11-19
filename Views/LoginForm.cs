using TaskLink.Controllers;
using TaskLink.Models;

namespace TaskLink.Views;

public partial class LoginForm : Form
{
    public LoginForm() { InitializeComponent(); }

    private void btnLogin_Click(object? sender, EventArgs e)
    {
        var (user, error) = AuthController.Login(txtEmail.Text, txtPassword.Text);
        if (user == null) { UiHelper.Error(error!); return; }
        Session.Current = user;
        DialogResult = DialogResult.OK;
    }

    private void btnRegister_Click(object? sender, EventArgs e)
    {
        using var f = new RegisterForm();
        if (f.ShowDialog(this) == DialogResult.OK) { txtEmail.Text = f.RegisteredEmail; txtPassword.Clear(); txtPassword.Focus(); }
    }
}
