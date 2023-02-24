using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace NetrayaCanteen
{
    public partial class MainMenu : MaterialForm
    {
        readonly Helper help = new Helper();
        string idUser, dept;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Are you sure you want to close this application?";
            string title = "Confirm Close";
            MaterialDialog materialDialog = new MaterialDialog(this, title, message, "OK", true, "Cancel");
            DialogResult result = materialDialog.ShowDialog(this);
            if (result.ToString() == "OK")
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar(result.ToString(), 750);
                SnackBarMessage.Show(this);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to close this application?";
            string title = "Confirm Close";
            MaterialDialog materialDialog = new MaterialDialog(this, title, message, "OK", true, "Cancel");
            DialogResult result = materialDialog.ShowDialog(this);
            if (result.ToString() == "OK")
            {
                Application.ExitThread();
            }
            else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar(result.ToString(), 750);
                SnackBarMessage.Show(this);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to logout?";
            string title = "Confirm Logout";
            MaterialDialog materialDialog = new MaterialDialog(this, title, message, "OK", true, "Cancel");
            DialogResult result = materialDialog.ShowDialog(this);
            if (result.ToString() == "OK")
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar(result.ToString(), 750);
                SnackBarMessage.Show(this);
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.usernameLbl.Text = toolStripUsername.Text;
            changePassword.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userlist userlist = new Userlist();
            userlist.toolStripUsername.Text = toolStripUsername.Text;
            userlist.userdetail.Text = userdetail.Text;
            userlist.Show();
            this.Hide();
        }

        private void userRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserRole userRole = new UserRole();
            userRole.toolStripUsername.Text = toolStripUsername.Text;
            userRole.userdetail.Text = userdetail.Text;
            userRole.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //set full with taskbar below
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            //get user id
            var userId = userdetail.Text.Split('|');
            idUser = userId[0].Trim();
            dept = userId[1].Trim();
        }
    }
}
