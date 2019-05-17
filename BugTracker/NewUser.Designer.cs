namespace BugTracker
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NUUsername = new System.Windows.Forms.TextBox();
            this.txt_NUPassword = new System.Windows.Forms.TextBox();
            this.txt_NUConfPass = new System.Windows.Forms.TextBox();
            this.btn_NUSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW USER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(46, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(46, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(14, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_NUUsername
            // 
            this.txt_NUUsername.Location = new System.Drawing.Point(96, 83);
            this.txt_NUUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NUUsername.Name = "txt_NUUsername";
            this.txt_NUUsername.Size = new System.Drawing.Size(202, 26);
            this.txt_NUUsername.TabIndex = 4;
            this.txt_NUUsername.TextChanged += new System.EventHandler(this.txt_NUUsername_TextChanged);
            // 
            // txt_NUPassword
            // 
            this.txt_NUPassword.Location = new System.Drawing.Point(96, 157);
            this.txt_NUPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NUPassword.Name = "txt_NUPassword";
            this.txt_NUPassword.PasswordChar = '*';
            this.txt_NUPassword.Size = new System.Drawing.Size(202, 26);
            this.txt_NUPassword.TabIndex = 5;
            this.txt_NUPassword.TextChanged += new System.EventHandler(this.txt_NUPassword_TextChanged);
            // 
            // txt_NUConfPass
            // 
            this.txt_NUConfPass.Location = new System.Drawing.Point(96, 232);
            this.txt_NUConfPass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NUConfPass.Name = "txt_NUConfPass";
            this.txt_NUConfPass.PasswordChar = '*';
            this.txt_NUConfPass.Size = new System.Drawing.Size(202, 26);
            this.txt_NUConfPass.TabIndex = 6;
            this.txt_NUConfPass.TextChanged += new System.EventHandler(this.txt_NUConfPass_TextChanged);
            // 
            // btn_NUSubmit
            // 
            this.btn_NUSubmit.BackColor = System.Drawing.Color.Green;
            this.btn_NUSubmit.Location = new System.Drawing.Point(96, 284);
            this.btn_NUSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NUSubmit.Name = "btn_NUSubmit";
            this.btn_NUSubmit.Size = new System.Drawing.Size(112, 34);
            this.btn_NUSubmit.TabIndex = 7;
            this.btn_NUSubmit.Text = "Submit";
            this.btn_NUSubmit.UseVisualStyleBackColor = false;
            this.btn_NUSubmit.Click += new System.EventHandler(this.btn_NUSubmit_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(326, 331);
            this.Controls.Add(this.btn_NUSubmit);
            this.Controls.Add(this.txt_NUConfPass);
            this.Controls.Add(this.txt_NUPassword);
            this.Controls.Add(this.txt_NUUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NUUsername;
        private System.Windows.Forms.TextBox txt_NUPassword;
        private System.Windows.Forms.TextBox txt_NUConfPass;
        private System.Windows.Forms.Button btn_NUSubmit;
    }
}