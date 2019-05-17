namespace BugTracker
{
    partial class UserDetailEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetailEdit));
            this.lbl_UdEUsrId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_UsrType = new System.Windows.Forms.GroupBox();
            this.rb_Tracker = new System.Windows.Forms.RadioButton();
            this.rb_Programmer = new System.Windows.Forms.RadioButton();
            this.rb_Admin = new System.Windows.Forms.RadioButton();
            this.btn_UDECancel = new System.Windows.Forms.Button();
            this.btn_UDEDone = new System.Windows.Forms.Button();
            this.lbl_UDEUsrname = new System.Windows.Forms.Label();
            this.groupBox_UsrType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_UdEUsrId
            // 
            this.lbl_UdEUsrId.AutoSize = true;
            this.lbl_UdEUsrId.Location = new System.Drawing.Point(120, 13);
            this.lbl_UdEUsrId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UdEUsrId.Name = "lbl_UdEUsrId";
            this.lbl_UdEUsrId.Size = new System.Drawing.Size(73, 19);
            this.lbl_UdEUsrId.TabIndex = 0;
            this.lbl_UdEUsrId.Text = "<UserId>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Type :";
            // 
            // groupBox_UsrType
            // 
            this.groupBox_UsrType.Controls.Add(this.rb_Tracker);
            this.groupBox_UsrType.Controls.Add(this.rb_Programmer);
            this.groupBox_UsrType.Controls.Add(this.rb_Admin);
            this.groupBox_UsrType.Location = new System.Drawing.Point(124, 84);
            this.groupBox_UsrType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_UsrType.Name = "groupBox_UsrType";
            this.groupBox_UsrType.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_UsrType.Size = new System.Drawing.Size(153, 124);
            this.groupBox_UsrType.TabIndex = 5;
            this.groupBox_UsrType.TabStop = false;
            // 
            // rb_Tracker
            // 
            this.rb_Tracker.AutoSize = true;
            this.rb_Tracker.Location = new System.Drawing.Point(10, 84);
            this.rb_Tracker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_Tracker.Name = "rb_Tracker";
            this.rb_Tracker.Size = new System.Drawing.Size(80, 23);
            this.rb_Tracker.TabIndex = 2;
            this.rb_Tracker.TabStop = true;
            this.rb_Tracker.Text = "Tracker";
            this.rb_Tracker.UseVisualStyleBackColor = true;
            // 
            // rb_Programmer
            // 
            this.rb_Programmer.AutoSize = true;
            this.rb_Programmer.Location = new System.Drawing.Point(9, 49);
            this.rb_Programmer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_Programmer.Name = "rb_Programmer";
            this.rb_Programmer.Size = new System.Drawing.Size(116, 23);
            this.rb_Programmer.TabIndex = 1;
            this.rb_Programmer.TabStop = true;
            this.rb_Programmer.Text = "Programmer";
            this.rb_Programmer.UseVisualStyleBackColor = true;
            // 
            // rb_Admin
            // 
            this.rb_Admin.AutoSize = true;
            this.rb_Admin.Location = new System.Drawing.Point(10, 16);
            this.rb_Admin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_Admin.Name = "rb_Admin";
            this.rb_Admin.Size = new System.Drawing.Size(72, 23);
            this.rb_Admin.TabIndex = 0;
            this.rb_Admin.TabStop = true;
            this.rb_Admin.Text = "Admin";
            this.rb_Admin.UseVisualStyleBackColor = true;
            // 
            // btn_UDECancel
            // 
            this.btn_UDECancel.BackColor = System.Drawing.Color.Red;
            this.btn_UDECancel.Location = new System.Drawing.Point(22, 230);
            this.btn_UDECancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_UDECancel.Name = "btn_UDECancel";
            this.btn_UDECancel.Size = new System.Drawing.Size(112, 33);
            this.btn_UDECancel.TabIndex = 6;
            this.btn_UDECancel.Text = "Cancel";
            this.btn_UDECancel.UseVisualStyleBackColor = false;
            this.btn_UDECancel.Click += new System.EventHandler(this.btn_UDECancel_Click);
            // 
            // btn_UDEDone
            // 
            this.btn_UDEDone.BackColor = System.Drawing.Color.Green;
            this.btn_UDEDone.Location = new System.Drawing.Point(165, 230);
            this.btn_UDEDone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_UDEDone.Name = "btn_UDEDone";
            this.btn_UDEDone.Size = new System.Drawing.Size(112, 33);
            this.btn_UDEDone.TabIndex = 7;
            this.btn_UDEDone.Text = "Done";
            this.btn_UDEDone.UseVisualStyleBackColor = false;
            this.btn_UDEDone.Click += new System.EventHandler(this.btn_UDEDone_Click);
            // 
            // lbl_UDEUsrname
            // 
            this.lbl_UDEUsrname.AutoSize = true;
            this.lbl_UDEUsrname.Location = new System.Drawing.Point(120, 49);
            this.lbl_UDEUsrname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UDEUsrname.Name = "lbl_UDEUsrname";
            this.lbl_UDEUsrname.Size = new System.Drawing.Size(99, 19);
            this.lbl_UDEUsrname.TabIndex = 8;
            this.lbl_UDEUsrname.Text = "<UserName>";
            // 
            // UserDetailEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(320, 296);
            this.Controls.Add(this.lbl_UDEUsrname);
            this.Controls.Add(this.btn_UDEDone);
            this.Controls.Add(this.btn_UDECancel);
            this.Controls.Add(this.groupBox_UsrType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_UdEUsrId);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserDetailEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDetailEdit";
            this.Load += new System.EventHandler(this.UserDetailEdit_Load);
            this.groupBox_UsrType.ResumeLayout(false);
            this.groupBox_UsrType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_UsrType;
        private System.Windows.Forms.RadioButton rb_Tracker;
        private System.Windows.Forms.RadioButton rb_Programmer;
        private System.Windows.Forms.RadioButton rb_Admin;
        private System.Windows.Forms.Button btn_UDECancel;
        private System.Windows.Forms.Button btn_UDEDone;
        public System.Windows.Forms.Label lbl_UdEUsrId;
        public System.Windows.Forms.Label lbl_UDEUsrname;
    }
}