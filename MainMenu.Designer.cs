
namespace NetrayaCanteen
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateTimeNow = new System.Windows.Forms.ToolStripStatusLabel();
            this.userdetail = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Open Sans", 9F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUsername,
            this.toolStripStatusLabel3,
            this.dateTimeNow,
            this.userdetail});
            this.statusStrip1.Location = new System.Drawing.Point(3, 482);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
            this.statusStrip1.TabIndex = 95;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripUsername
            // 
            this.toolStripUsername.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripUsername.Name = "toolStripUsername";
            this.toolStripUsername.Size = new System.Drawing.Size(127, 17);
            this.toolStripUsername.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(234, 17);
            this.toolStripStatusLabel3.Text = "Developed by IT-PE SMT Dept with ❤  | ";
            // 
            // dateTimeNow
            // 
            this.dateTimeNow.BackColor = System.Drawing.SystemColors.Control;
            this.dateTimeNow.Name = "dateTimeNow";
            this.dateTimeNow.Size = new System.Drawing.Size(12, 17);
            this.dateTimeNow.Text = "-";
            // 
            // userdetail
            // 
            this.userdetail.Name = "userdetail";
            this.userdetail.Size = new System.Drawing.Size(64, 17);
            this.userdetail.Text = "userdetail";
            this.userdetail.Visible = false;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.logEmployeeToolStripMenuItem,
            this.statusTagToolStripMenuItem,
            this.masterDataToolStripMenuItem,
            this.administrationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(169, 186);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // logEmployeeToolStripMenuItem
            // 
            this.logEmployeeToolStripMenuItem.Name = "logEmployeeToolStripMenuItem";
            this.logEmployeeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logEmployeeToolStripMenuItem.Text = "Log Employee";
            // 
            // statusTagToolStripMenuItem
            // 
            this.statusTagToolStripMenuItem.Name = "statusTagToolStripMenuItem";
            this.statusTagToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.statusTagToolStripMenuItem.Text = "Status Tag";
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genderToolStripMenuItem,
            this.employeeLevelToolStripMenuItem,
            this.departmentToolStripMenuItem,
            this.workAreaToolStripMenuItem,
            this.lineCodeToolStripMenuItem,
            this.sectionToolStripMenuItem,
            this.shiftToolStripMenuItem,
            this.deviceToolStripMenuItem,
            this.emailTemplateToolStripMenuItem});
            this.masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            this.masterDataToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.masterDataToolStripMenuItem.Text = "Master Data";
            // 
            // genderToolStripMenuItem
            // 
            this.genderToolStripMenuItem.Name = "genderToolStripMenuItem";
            this.genderToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.genderToolStripMenuItem.Text = "Gender";
            this.genderToolStripMenuItem.Click += new System.EventHandler(this.genderToolStripMenuItem_Click);
            // 
            // employeeLevelToolStripMenuItem
            // 
            this.employeeLevelToolStripMenuItem.Name = "employeeLevelToolStripMenuItem";
            this.employeeLevelToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.employeeLevelToolStripMenuItem.Text = "Employee Level";
            this.employeeLevelToolStripMenuItem.Click += new System.EventHandler(this.employeeLevelToolStripMenuItem_Click);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // workAreaToolStripMenuItem
            // 
            this.workAreaToolStripMenuItem.Name = "workAreaToolStripMenuItem";
            this.workAreaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.workAreaToolStripMenuItem.Text = "Work Area";
            this.workAreaToolStripMenuItem.Click += new System.EventHandler(this.workAreaToolStripMenuItem_Click);
            // 
            // lineCodeToolStripMenuItem
            // 
            this.lineCodeToolStripMenuItem.Name = "lineCodeToolStripMenuItem";
            this.lineCodeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.lineCodeToolStripMenuItem.Text = "Line Code";
            this.lineCodeToolStripMenuItem.Click += new System.EventHandler(this.lineCodeToolStripMenuItem_Click);
            // 
            // sectionToolStripMenuItem
            // 
            this.sectionToolStripMenuItem.Name = "sectionToolStripMenuItem";
            this.sectionToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.sectionToolStripMenuItem.Text = "Section";
            this.sectionToolStripMenuItem.Click += new System.EventHandler(this.sectionToolStripMenuItem_Click);
            // 
            // shiftToolStripMenuItem
            // 
            this.shiftToolStripMenuItem.Name = "shiftToolStripMenuItem";
            this.shiftToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.shiftToolStripMenuItem.Text = "Shift";
            this.shiftToolStripMenuItem.Click += new System.EventHandler(this.shiftToolStripMenuItem_Click);
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.deviceToolStripMenuItem.Text = "Device";
            this.deviceToolStripMenuItem.Click += new System.EventHandler(this.deviceToolStripMenuItem_Click);
            // 
            // emailTemplateToolStripMenuItem
            // 
            this.emailTemplateToolStripMenuItem.Name = "emailTemplateToolStripMenuItem";
            this.emailTemplateToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.emailTemplateToolStripMenuItem.Text = "Email Template";
            this.emailTemplateToolStripMenuItem.Click += new System.EventHandler(this.emailTemplateToolStripMenuItem_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.userRoleToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // userRoleToolStripMenuItem
            // 
            this.userRoleToolStripMenuItem.Name = "userRoleToolStripMenuItem";
            this.userRoleToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.userRoleToolStripMenuItem.Text = "User Role";
            this.userRoleToolStripMenuItem.Click += new System.EventHandler(this.userRoleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Netraya Canteen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripUsername;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel dateTimeNow;
        public System.Windows.Forms.ToolStripStatusLabel userdetail;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
    }
}