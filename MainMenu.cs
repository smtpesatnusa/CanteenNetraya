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

        private void genderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genderlist genderlist = new Genderlist();
            genderlist.toolStripUsername.Text = toolStripUsername.Text;
            genderlist.userdetail.Text = userdetail.Text;
            genderlist.Show();
            this.Hide();
        }

        private void employeeLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeLevellist employeeLevellist = new EmployeeLevellist();
            employeeLevellist.toolStripUsername.Text = toolStripUsername.Text;
            employeeLevellist.userdetail.Text = userdetail.Text;
            employeeLevellist.Show();
            this.Hide();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departmentlist departmentlist = new Departmentlist();
            departmentlist.toolStripUsername.Text = toolStripUsername.Text;
            departmentlist.userdetail.Text = userdetail.Text;
            departmentlist.Show();
            this.Hide();
        }

        private void workAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkArealist workArealist = new WorkArealist();
            workArealist.toolStripUsername.Text = toolStripUsername.Text;
            workArealist.userdetail.Text = userdetail.Text;
            workArealist.Show();
            this.Hide();
        }

        private void lineCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineCodelist lineCodelist = new LineCodelist();
            lineCodelist.toolStripUsername.Text = toolStripUsername.Text;
            lineCodelist.userdetail.Text = userdetail.Text;
            lineCodelist.Show();
            this.Hide();
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sectionlist sectionlist = new Sectionlist();
            sectionlist.toolStripUsername.Text = toolStripUsername.Text;
            sectionlist.userdetail.Text = userdetail.Text;
            sectionlist.Show();
            this.Hide();
        }

        private void shiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shiftlist shiftlist = new Shiftlist();
            shiftlist.toolStripUsername.Text = toolStripUsername.Text;
            shiftlist.userdetail.Text = userdetail.Text;
            shiftlist.Show();
            this.Hide();
        }

        private void deviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devicelist devicelist = new Devicelist();
            devicelist.toolStripUsername.Text = toolStripUsername.Text;
            devicelist.userdetail.Text = userdetail.Text;
            devicelist.Show();
            this.Hide();
        }

        private void emailTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailTemplate emailTemplate = new EmailTemplate();
            emailTemplate.userdetail.Text = userdetail.Text;
            emailTemplate.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            help.dateTimeNow(dateTimeNow);
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employeelist employeelist = new Employeelist();
            employeelist.toolStripUsername.Text = toolStripUsername.Text;
            employeelist.userdetail.Text = userdetail.Text;
            employeelist.Show();
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
