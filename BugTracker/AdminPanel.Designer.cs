namespace BugTracker
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_ApUser = new System.Windows.Forms.TabPage();
            this.lbl_APUserRequestList = new System.Windows.Forms.Label();
            this.btn_ApView = new System.Windows.Forms.Button();
            this.btn_ApEdit = new System.Windows.Forms.Button();
            this.lbl_ApLUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_UserList = new System.Windows.Forms.Label();
            this.dataGridView_ApUserList = new System.Windows.Forms.DataGridView();
            this.tabPage_ApBuglist = new System.Windows.Forms.TabPage();
            this.btn_ApBGLView = new System.Windows.Forms.Button();
            this.dataGridView_APBGL = new System.Windows.Forms.DataGridView();
            this.tabPage_APBugsolved = new System.Windows.Forms.TabPage();
            this.btn_APBGSView = new System.Windows.Forms.Button();
            this.dataGridView_APBGS = new System.Windows.Forms.DataGridView();
            this.tabPage_ApAccount = new System.Windows.Forms.TabPage();
            this.btn_connectgitlab = new System.Windows.Forms.Button();
            this.groupBox_Changepassword = new System.Windows.Forms.GroupBox();
            this.btn_APCancel = new System.Windows.Forms.Button();
            this.btn_APchangepassDone = new System.Windows.Forms.Button();
            this.txt_APConfirmPassword = new System.Windows.Forms.TextBox();
            this.txt_APNewPassword = new System.Windows.Forms.TextBox();
            this.txt_APOldPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ApExit = new System.Windows.Forms.Button();
            this.btn_ApLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_ApUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ApUserList)).BeginInit();
            this.tabPage_ApBuglist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_APBGL)).BeginInit();
            this.tabPage_APBugsolved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_APBGS)).BeginInit();
            this.tabPage_ApAccount.SuspendLayout();
            this.groupBox_Changepassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_ApUser);
            this.tabControl1.Controls.Add(this.tabPage_ApBuglist);
            this.tabControl1.Controls.Add(this.tabPage_APBugsolved);
            this.tabControl1.Controls.Add(this.tabPage_ApAccount);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(418, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_ApUser
            // 
            this.tabPage_ApUser.Controls.Add(this.lbl_APUserRequestList);
            this.tabPage_ApUser.Controls.Add(this.btn_ApView);
            this.tabPage_ApUser.Controls.Add(this.btn_ApEdit);
            this.tabPage_ApUser.Controls.Add(this.lbl_ApLUserName);
            this.tabPage_ApUser.Controls.Add(this.label1);
            this.tabPage_ApUser.Controls.Add(this.lbl_UserList);
            this.tabPage_ApUser.Controls.Add(this.dataGridView_ApUserList);
            this.tabPage_ApUser.Location = new System.Drawing.Point(4, 28);
            this.tabPage_ApUser.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_ApUser.Name = "tabPage_ApUser";
            this.tabPage_ApUser.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_ApUser.Size = new System.Drawing.Size(410, 457);
            this.tabPage_ApUser.TabIndex = 0;
            this.tabPage_ApUser.Text = "Users";
            this.tabPage_ApUser.UseVisualStyleBackColor = true;
            // 
            // lbl_APUserRequestList
            // 
            this.lbl_APUserRequestList.AutoSize = true;
            this.lbl_APUserRequestList.Location = new System.Drawing.Point(122, 48);
            this.lbl_APUserRequestList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_APUserRequestList.Name = "lbl_APUserRequestList";
            this.lbl_APUserRequestList.Size = new System.Drawing.Size(122, 19);
            this.lbl_APUserRequestList.TabIndex = 6;
            this.lbl_APUserRequestList.Text = "User Requst List";
            this.lbl_APUserRequestList.Click += new System.EventHandler(this.lbl_APUserRequestList_Click);
            // 
            // btn_ApView
            // 
            this.btn_ApView.Location = new System.Drawing.Point(260, 415);
            this.btn_ApView.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ApView.Name = "btn_ApView";
            this.btn_ApView.Size = new System.Drawing.Size(142, 34);
            this.btn_ApView.TabIndex = 5;
            this.btn_ApView.Text = "View";
            this.btn_ApView.UseVisualStyleBackColor = true;
            this.btn_ApView.Click += new System.EventHandler(this.btn_ApView_Click);
            // 
            // btn_ApEdit
            // 
            this.btn_ApEdit.Location = new System.Drawing.Point(91, 415);
            this.btn_ApEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ApEdit.Name = "btn_ApEdit";
            this.btn_ApEdit.Size = new System.Drawing.Size(134, 34);
            this.btn_ApEdit.TabIndex = 4;
            this.btn_ApEdit.Text = "Edit";
            this.btn_ApEdit.UseVisualStyleBackColor = true;
            this.btn_ApEdit.Click += new System.EventHandler(this.btn_ApEdit_Click);
            // 
            // lbl_ApLUserName
            // 
            this.lbl_ApLUserName.AutoSize = true;
            this.lbl_ApLUserName.Location = new System.Drawing.Point(122, 14);
            this.lbl_ApLUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ApLUserName.Name = "lbl_ApLUserName";
            this.lbl_ApLUserName.Size = new System.Drawing.Size(103, 19);
            this.lbl_ApLUserName.TabIndex = 3;
            this.lbl_ApLUserName.Text = "<User Name>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Logged In as :";
            // 
            // lbl_UserList
            // 
            this.lbl_UserList.AutoSize = true;
            this.lbl_UserList.Location = new System.Drawing.Point(44, 48);
            this.lbl_UserList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserList.Name = "lbl_UserList";
            this.lbl_UserList.Size = new System.Drawing.Size(70, 19);
            this.lbl_UserList.TabIndex = 1;
            this.lbl_UserList.Text = "User List";
            // 
            // dataGridView_ApUserList
            // 
            this.dataGridView_ApUserList.AllowUserToAddRows = false;
            this.dataGridView_ApUserList.AllowUserToDeleteRows = false;
            this.dataGridView_ApUserList.AllowUserToOrderColumns = true;
            this.dataGridView_ApUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ApUserList.Location = new System.Drawing.Point(9, 82);
            this.dataGridView_ApUserList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_ApUserList.Name = "dataGridView_ApUserList";
            this.dataGridView_ApUserList.ReadOnly = true;
            this.dataGridView_ApUserList.Size = new System.Drawing.Size(393, 325);
            this.dataGridView_ApUserList.TabIndex = 0;
            this.dataGridView_ApUserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ApUserList_CellContentClick);
            this.dataGridView_ApUserList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_ApUserList_MouseClick);
            // 
            // tabPage_ApBuglist
            // 
            this.tabPage_ApBuglist.Controls.Add(this.btn_ApBGLView);
            this.tabPage_ApBuglist.Controls.Add(this.dataGridView_APBGL);
            this.tabPage_ApBuglist.Location = new System.Drawing.Point(4, 28);
            this.tabPage_ApBuglist.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_ApBuglist.Name = "tabPage_ApBuglist";
            this.tabPage_ApBuglist.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_ApBuglist.Size = new System.Drawing.Size(410, 457);
            this.tabPage_ApBuglist.TabIndex = 1;
            this.tabPage_ApBuglist.Text = "BugList";
            this.tabPage_ApBuglist.UseVisualStyleBackColor = true;
            // 
            // btn_ApBGLView
            // 
            this.btn_ApBGLView.Location = new System.Drawing.Point(290, 415);
            this.btn_ApBGLView.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ApBGLView.Name = "btn_ApBGLView";
            this.btn_ApBGLView.Size = new System.Drawing.Size(112, 34);
            this.btn_ApBGLView.TabIndex = 1;
            this.btn_ApBGLView.Text = "View";
            this.btn_ApBGLView.UseVisualStyleBackColor = true;
            this.btn_ApBGLView.Click += new System.EventHandler(this.btn_ApBGLView_Click);
            // 
            // dataGridView_APBGL
            // 
            this.dataGridView_APBGL.AllowUserToAddRows = false;
            this.dataGridView_APBGL.AllowUserToDeleteRows = false;
            this.dataGridView_APBGL.AllowUserToOrderColumns = true;
            this.dataGridView_APBGL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_APBGL.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_APBGL.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_APBGL.Name = "dataGridView_APBGL";
            this.dataGridView_APBGL.ReadOnly = true;
            this.dataGridView_APBGL.Size = new System.Drawing.Size(406, 407);
            this.dataGridView_APBGL.TabIndex = 0;
            // 
            // tabPage_APBugsolved
            // 
            this.tabPage_APBugsolved.Controls.Add(this.btn_APBGSView);
            this.tabPage_APBugsolved.Controls.Add(this.dataGridView_APBGS);
            this.tabPage_APBugsolved.Location = new System.Drawing.Point(4, 28);
            this.tabPage_APBugsolved.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_APBugsolved.Name = "tabPage_APBugsolved";
            this.tabPage_APBugsolved.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_APBugsolved.Size = new System.Drawing.Size(410, 457);
            this.tabPage_APBugsolved.TabIndex = 3;
            this.tabPage_APBugsolved.Text = "Bug Solved";
            this.tabPage_APBugsolved.UseVisualStyleBackColor = true;
            // 
            // btn_APBGSView
            // 
            this.btn_APBGSView.Location = new System.Drawing.Point(290, 415);
            this.btn_APBGSView.Margin = new System.Windows.Forms.Padding(4);
            this.btn_APBGSView.Name = "btn_APBGSView";
            this.btn_APBGSView.Size = new System.Drawing.Size(112, 34);
            this.btn_APBGSView.TabIndex = 1;
            this.btn_APBGSView.Text = "View";
            this.btn_APBGSView.UseVisualStyleBackColor = true;
            this.btn_APBGSView.Click += new System.EventHandler(this.btn_APBGSView_Click);
            // 
            // dataGridView_APBGS
            // 
            this.dataGridView_APBGS.AllowUserToAddRows = false;
            this.dataGridView_APBGS.AllowUserToDeleteRows = false;
            this.dataGridView_APBGS.AllowUserToOrderColumns = true;
            this.dataGridView_APBGS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_APBGS.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_APBGS.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_APBGS.Name = "dataGridView_APBGS";
            this.dataGridView_APBGS.ReadOnly = true;
            this.dataGridView_APBGS.Size = new System.Drawing.Size(402, 407);
            this.dataGridView_APBGS.TabIndex = 0;
            // 
            // tabPage_ApAccount
            // 
            this.tabPage_ApAccount.Controls.Add(this.btn_connectgitlab);
            this.tabPage_ApAccount.Controls.Add(this.groupBox_Changepassword);
            this.tabPage_ApAccount.Controls.Add(this.button1);
            this.tabPage_ApAccount.Controls.Add(this.btn_ApExit);
            this.tabPage_ApAccount.Controls.Add(this.btn_ApLogout);
            this.tabPage_ApAccount.Location = new System.Drawing.Point(4, 28);
            this.tabPage_ApAccount.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_ApAccount.Name = "tabPage_ApAccount";
            this.tabPage_ApAccount.Size = new System.Drawing.Size(410, 457);
            this.tabPage_ApAccount.TabIndex = 2;
            this.tabPage_ApAccount.Text = "Account";
            this.tabPage_ApAccount.UseVisualStyleBackColor = true;
            // 
            // btn_connectgitlab
            // 
            this.btn_connectgitlab.Location = new System.Drawing.Point(250, 104);
            this.btn_connectgitlab.Margin = new System.Windows.Forms.Padding(4);
            this.btn_connectgitlab.Name = "btn_connectgitlab";
            this.btn_connectgitlab.Size = new System.Drawing.Size(112, 34);
            this.btn_connectgitlab.TabIndex = 9;
            this.btn_connectgitlab.Text = "Open GitLab";
            this.btn_connectgitlab.UseVisualStyleBackColor = true;
            this.btn_connectgitlab.Click += new System.EventHandler(this.btn_connectgitlab_Click);
            // 
            // groupBox_Changepassword
            // 
            this.groupBox_Changepassword.Controls.Add(this.btn_APCancel);
            this.groupBox_Changepassword.Controls.Add(this.btn_APchangepassDone);
            this.groupBox_Changepassword.Controls.Add(this.txt_APConfirmPassword);
            this.groupBox_Changepassword.Controls.Add(this.txt_APNewPassword);
            this.groupBox_Changepassword.Controls.Add(this.txt_APOldPassword);
            this.groupBox_Changepassword.Controls.Add(this.label11);
            this.groupBox_Changepassword.Controls.Add(this.label13);
            this.groupBox_Changepassword.Controls.Add(this.label14);
            this.groupBox_Changepassword.Location = new System.Drawing.Point(36, 146);
            this.groupBox_Changepassword.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Changepassword.Name = "groupBox_Changepassword";
            this.groupBox_Changepassword.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Changepassword.Size = new System.Drawing.Size(326, 274);
            this.groupBox_Changepassword.TabIndex = 8;
            this.groupBox_Changepassword.TabStop = false;
            this.groupBox_Changepassword.Text = "Change  Password";
            this.groupBox_Changepassword.Visible = false;
            // 
            // btn_APCancel
            // 
            this.btn_APCancel.Location = new System.Drawing.Point(70, 212);
            this.btn_APCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_APCancel.Name = "btn_APCancel";
            this.btn_APCancel.Size = new System.Drawing.Size(75, 34);
            this.btn_APCancel.TabIndex = 16;
            this.btn_APCancel.Text = "Cancel";
            this.btn_APCancel.UseVisualStyleBackColor = true;
            // 
            // btn_APchangepassDone
            // 
            this.btn_APchangepassDone.Location = new System.Drawing.Point(153, 212);
            this.btn_APchangepassDone.Margin = new System.Windows.Forms.Padding(4);
            this.btn_APchangepassDone.Name = "btn_APchangepassDone";
            this.btn_APchangepassDone.Size = new System.Drawing.Size(75, 34);
            this.btn_APchangepassDone.TabIndex = 8;
            this.btn_APchangepassDone.Text = "Done";
            this.btn_APchangepassDone.UseVisualStyleBackColor = true;
            this.btn_APchangepassDone.Click += new System.EventHandler(this.btn_APchangepassDone_Click);
            // 
            // txt_APConfirmPassword
            // 
            this.txt_APConfirmPassword.Location = new System.Drawing.Point(153, 157);
            this.txt_APConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_APConfirmPassword.Name = "txt_APConfirmPassword";
            this.txt_APConfirmPassword.Size = new System.Drawing.Size(148, 26);
            this.txt_APConfirmPassword.TabIndex = 15;
            // 
            // txt_APNewPassword
            // 
            this.txt_APNewPassword.Location = new System.Drawing.Point(153, 108);
            this.txt_APNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_APNewPassword.Name = "txt_APNewPassword";
            this.txt_APNewPassword.Size = new System.Drawing.Size(148, 26);
            this.txt_APNewPassword.TabIndex = 14;
            // 
            // txt_APOldPassword
            // 
            this.txt_APOldPassword.Location = new System.Drawing.Point(153, 44);
            this.txt_APOldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_APOldPassword.Name = "txt_APOldPassword";
            this.txt_APOldPassword.Size = new System.Drawing.Size(148, 26);
            this.txt_APOldPassword.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 157);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Confirm Password";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 108);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 19);
            this.label13.TabIndex = 10;
            this.label13.Text = "New Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 47);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 19);
            this.label14.TabIndex = 9;
            this.label14.Text = "Old Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 94);
            this.button1.TabIndex = 2;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ApExit
            // 
            this.btn_ApExit.Location = new System.Drawing.Point(282, 62);
            this.btn_ApExit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ApExit.Name = "btn_ApExit";
            this.btn_ApExit.Size = new System.Drawing.Size(80, 34);
            this.btn_ApExit.TabIndex = 1;
            this.btn_ApExit.Text = "Exit";
            this.btn_ApExit.UseVisualStyleBackColor = true;
            this.btn_ApExit.Click += new System.EventHandler(this.btn_ApExit_Click);
            // 
            // btn_ApLogout
            // 
            this.btn_ApLogout.Location = new System.Drawing.Point(282, 19);
            this.btn_ApLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ApLogout.Name = "btn_ApLogout";
            this.btn_ApLogout.Size = new System.Drawing.Size(80, 34);
            this.btn_ApLogout.TabIndex = 0;
            this.btn_ApLogout.Text = "Logout";
            this.btn_ApLogout.UseVisualStyleBackColor = true;
            this.btn_ApLogout.Click += new System.EventHandler(this.btn_ApLogout_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(445, 515);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Panel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_ApUser.ResumeLayout(false);
            this.tabPage_ApUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ApUserList)).EndInit();
            this.tabPage_ApBuglist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_APBGL)).EndInit();
            this.tabPage_APBugsolved.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_APBGS)).EndInit();
            this.tabPage_ApAccount.ResumeLayout(false);
            this.groupBox_Changepassword.ResumeLayout(false);
            this.groupBox_Changepassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_ApUser;
        private System.Windows.Forms.TabPage tabPage_ApBuglist;
        private System.Windows.Forms.TabPage tabPage_ApAccount;
        private System.Windows.Forms.Label lbl_ApLUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_UserList;
        private System.Windows.Forms.Button btn_ApView;
        public System.Windows.Forms.DataGridView dataGridView_ApUserList;
        private System.Windows.Forms.Button btn_ApEdit;
        private System.Windows.Forms.Button btn_ApLogout;
        private System.Windows.Forms.Button btn_ApExit;
        private System.Windows.Forms.Button btn_ApBGLView;
        private System.Windows.Forms.DataGridView dataGridView_APBGL;
        private System.Windows.Forms.TabPage tabPage_APBugsolved;
        private System.Windows.Forms.Button btn_APBGSView;
        private System.Windows.Forms.DataGridView dataGridView_APBGS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_APUserRequestList;
        private System.Windows.Forms.GroupBox groupBox_Changepassword;
        private System.Windows.Forms.Button btn_APCancel;
        private System.Windows.Forms.Button btn_APchangepassDone;
        private System.Windows.Forms.TextBox txt_APConfirmPassword;
        private System.Windows.Forms.TextBox txt_APNewPassword;
        private System.Windows.Forms.TextBox txt_APOldPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_connectgitlab;
    }
}