namespace BugTracker
{
    partial class RequestList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestList));
            this.dataGridView_RequestList = new System.Windows.Forms.DataGridView();
            this.btn_RequestAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RequestList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_RequestList
            // 
            this.dataGridView_RequestList.AllowUserToAddRows = false;
            this.dataGridView_RequestList.AllowUserToDeleteRows = false;
            this.dataGridView_RequestList.AllowUserToOrderColumns = true;
            this.dataGridView_RequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RequestList.Location = new System.Drawing.Point(13, 14);
            this.dataGridView_RequestList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_RequestList.Name = "dataGridView_RequestList";
            this.dataGridView_RequestList.ReadOnly = true;
            this.dataGridView_RequestList.Size = new System.Drawing.Size(307, 291);
            this.dataGridView_RequestList.TabIndex = 0;
            // 
            // btn_RequestAccept
            // 
            this.btn_RequestAccept.Location = new System.Drawing.Point(111, 315);
            this.btn_RequestAccept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_RequestAccept.Name = "btn_RequestAccept";
            this.btn_RequestAccept.Size = new System.Drawing.Size(112, 33);
            this.btn_RequestAccept.TabIndex = 1;
            this.btn_RequestAccept.Text = "Accept";
            this.btn_RequestAccept.UseVisualStyleBackColor = true;
            this.btn_RequestAccept.Click += new System.EventHandler(this.btn_RequestAccept_Click);
            // 
            // RequestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(334, 365);
            this.Controls.Add(this.btn_RequestAccept);
            this.Controls.Add(this.dataGridView_RequestList);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RequestList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestList";
            this.Load += new System.EventHandler(this.RequestList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RequestList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_RequestList;
        private System.Windows.Forms.Button btn_RequestAccept;
    }
}