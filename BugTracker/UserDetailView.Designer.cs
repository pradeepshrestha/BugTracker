namespace BugTracker
{
    partial class UserDetailView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetailView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_UdDeleteUsr = new System.Windows.Forms.Button();
            this.lbl_UdNumBugReport = new System.Windows.Forms.Label();
            this.lbl_UdUsrType = new System.Windows.Forms.Label();
            this.lbl_UdUsrName = new System.Windows.Forms.Label();
            this.lbl_UdUsrId = new System.Windows.Forms.Label();
            this.btn_UdOkay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(114, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(88, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(94, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(13, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Num of Bug Reported :";
            // 
            // btn_UdDeleteUsr
            // 
            this.btn_UdDeleteUsr.BackColor = System.Drawing.Color.Red;
            this.btn_UdDeleteUsr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_UdDeleteUsr.Location = new System.Drawing.Point(69, 172);
            this.btn_UdDeleteUsr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_UdDeleteUsr.Name = "btn_UdDeleteUsr";
            this.btn_UdDeleteUsr.Size = new System.Drawing.Size(112, 33);
            this.btn_UdDeleteUsr.TabIndex = 5;
            this.btn_UdDeleteUsr.Text = "Delete User";
            this.btn_UdDeleteUsr.UseVisualStyleBackColor = false;
            this.btn_UdDeleteUsr.Click += new System.EventHandler(this.btn_UdDeleteUsr_Click);
            // 
            // lbl_UdNumBugReport
            // 
            this.lbl_UdNumBugReport.AutoSize = true;
            this.lbl_UdNumBugReport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_UdNumBugReport.Location = new System.Drawing.Point(189, 131);
            this.lbl_UdNumBugReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UdNumBugReport.Name = "lbl_UdNumBugReport";
            this.lbl_UdNumBugReport.Size = new System.Drawing.Size(91, 19);
            this.lbl_UdNumBugReport.TabIndex = 10;
            this.lbl_UdNumBugReport.Text = "<Numbers>";
            // 
            // lbl_UdUsrType
            // 
            this.lbl_UdUsrType.AutoSize = true;
            this.lbl_UdUsrType.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_UdUsrType.Location = new System.Drawing.Point(189, 97);
            this.lbl_UdUsrType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UdUsrType.Name = "lbl_UdUsrType";
            this.lbl_UdUsrType.Size = new System.Drawing.Size(97, 19);
            this.lbl_UdUsrType.TabIndex = 8;
            this.lbl_UdUsrType.Text = "<User Type>";
            // 
            // lbl_UdUsrName
            // 
            this.lbl_UdUsrName.AutoSize = true;
            this.lbl_UdUsrName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_UdUsrName.Location = new System.Drawing.Point(189, 57);
            this.lbl_UdUsrName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UdUsrName.Name = "lbl_UdUsrName";
            this.lbl_UdUsrName.Size = new System.Drawing.Size(103, 19);
            this.lbl_UdUsrName.TabIndex = 7;
            this.lbl_UdUsrName.Text = "<User Name>";
            // 
            // lbl_UdUsrId
            // 
            this.lbl_UdUsrId.AutoSize = true;
            this.lbl_UdUsrId.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_UdUsrId.Location = new System.Drawing.Point(189, 19);
            this.lbl_UdUsrId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UdUsrId.Name = "lbl_UdUsrId";
            this.lbl_UdUsrId.Size = new System.Drawing.Size(81, 19);
            this.lbl_UdUsrId.TabIndex = 6;
            this.lbl_UdUsrId.Text = "<User Id >";
            // 
            // btn_UdOkay
            // 
            this.btn_UdOkay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_UdOkay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_UdOkay.Location = new System.Drawing.Point(243, 172);
            this.btn_UdOkay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_UdOkay.Name = "btn_UdOkay";
            this.btn_UdOkay.Size = new System.Drawing.Size(112, 33);
            this.btn_UdOkay.TabIndex = 11;
            this.btn_UdOkay.Text = "Okay";
            this.btn_UdOkay.UseVisualStyleBackColor = false;
            this.btn_UdOkay.Click += new System.EventHandler(this.btn_UdOkay_Click);
            // 
            // UserDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(390, 270);
            this.Controls.Add(this.btn_UdOkay);
            this.Controls.Add(this.lbl_UdNumBugReport);
            this.Controls.Add(this.lbl_UdUsrType);
            this.Controls.Add(this.lbl_UdUsrName);
            this.Controls.Add(this.lbl_UdUsrId);
            this.Controls.Add(this.btn_UdDeleteUsr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "UserDetailView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDetail";
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.Load += new System.EventHandler(this.UserDetailView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_UdDeleteUsr;
        private System.Windows.Forms.Label lbl_UdNumBugReport;
        private System.Windows.Forms.Label lbl_UdUsrType;
        private System.Windows.Forms.Label lbl_UdUsrName;
        private System.Windows.Forms.Button btn_UdOkay;
        public System.Windows.Forms.Label lbl_UdUsrId;
    }
}