using TaskLink.Controllers;
using TaskLink.Data;
using TaskLink.Views;

namespace TaskLink;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        try { Db.Initialize(); AdminController.EnsureAdmin(); }
        catch (Exception ex)
        {
            MessageBox.Show("Cannot reach MySQL. Open XAMPP and start MySQL, then run again.\n\n" + ex.Message,
                "TaskLink", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        while (true)
        {
            using var login = new LoginForm();
            if (login.ShowDialog() != DialogResult.OK) break;
            using var main = new MainForm();
            main.ShowDialog();
            if (!main.LoggedOut) break;
        }
    }
}
