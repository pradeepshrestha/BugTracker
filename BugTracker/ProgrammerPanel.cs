using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;


namespace BugTracker
{
    public partial class ProgrammerPanel : Form
    {
        public ProgrammerPanel()
        {
            InitializeComponent();

            //receiving value from the login panel and displaying in label.
            lbl_PpUserIdshow.Text = Login.usridpass;
            lbl_PpUseernameshow.Text = Login.usrnamepass;
            lbl_PpUsertypeshow.Text = Login.usrtypepass;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            //logout
            this.Close();
            Login lol = new Login();
            lol.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //exit program
            DialogResult value = MessageBox.Show("Do you really want to exit program?", "Confirm exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (value == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }

        private void dataGridView_Bug_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                //showing data to field after clicking the row
                DataGridViewRow row = dataGridView_Bug.SelectedRows[0];
                lbl_PpSubjectshow.Text = row.Cells["B_Subject"].Value.ToString();
                lbl_PpBugId.Text = row.Cells["B_Id"].Value.ToString();

                //connecting to database to show to the field after clicking the row
                databaseConnection con = new databaseConnection();
                string sql_Buglist = "Select * from tbl_bug where B_Id ='" + lbl_PpBugId.Text + "'";
                MySqlCommand cmd1 = new MySqlCommand(sql_Buglist, con.Db_Connect());
                MySqlDataReader r = cmd1.ExecuteReader();

                if (r.Read())
                {
                    String B_ListCode = r.GetString("B_Code");
                    String B_ListUpdate = r.GetString("B_Update");

                    rtxt_PpErrorCode.Text = B_ListCode;
                    rtxt_PpUpdateCode.Text = B_ListUpdate;
                }
                else
                {
                    MessageBox.Show("error !!!!!!   B_Code aand B_Describe not shown" + sql_Buglist);

                }
            }
            catch (Exception ex)
            {

                
            }
        }

        private void ProgrammerPanel_Load(object sender, EventArgs e)
        {
            try
            {
                //loading datagrid data at the page load
                databaseConnection con = new databaseConnection();
                string sql_Buglist = "Select B_Id,B_Subject from tbl_bug";
                MySqlCommand cmd1 = new MySqlCommand(sql_Buglist, con.Db_Connect());

                DataTable dt = new DataTable();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd1);
                dt.Clear();
                msda.Fill(dt);
                dataGridView_Bug.DataSource = dt;
                con.CloseConnection();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView_Bug_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_PpListEdit_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            databaseConnection con = new databaseConnection();
            string sql_PpupdateBug = "UPDATE tbl_Bug SET B_Update='" + rtxt_PpUpdateCode.Text + "' WHERE B_Id= '" + lbl_PpBugId.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql_PpupdateBug, con.Db_Connect());
            cmd.ExecuteNonQuery();


            MessageBox.Show("Submitted Successfully!!");
            rtxt_PpErrorCode.Clear();
            rtxt_PpUpdateCode.Clear();


            string sql_Buglist = "Select B_Id,B_Subject from tbl_bug";
            MySqlCommand cmd1 = new MySqlCommand(sql_Buglist, con.Db_Connect());

            DataTable dt = new DataTable();
            MySqlDataAdapter msda = new MySqlDataAdapter(cmd1);
            dt.Clear();
            msda.Fill(dt);
            dataGridView_Bug.DataSource = dt;
            con.CloseConnection();
        }

        private void rtxt_PpErrorCode_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex("class");
            int index = rtxt_PpErrorCode.SelectionStart;

            foreach (Match m in rx.Matches(rtxt_PpErrorCode.Text))
            {
                rtxt_PpErrorCode.Select(m.Index, m.Value.Length);
                rtxt_PpErrorCode.SelectionColor = Color.Blue;
                rtxt_PpErrorCode.SelectionStart = index;
                rtxt_PpErrorCode.SelectionColor = Color.Black;
            }

            Regex rx1 = new Regex("String");
            int index1 = rtxt_PpErrorCode.SelectionStart;

            foreach (Match m1 in rx1.Matches(rtxt_PpErrorCode.Text))
            {
                rtxt_PpErrorCode.Select(m1.Index, m1.Value.Length);
                rtxt_PpErrorCode.SelectionColor = Color.Green;
                rtxt_PpErrorCode.SelectionStart = index;
                rtxt_PpErrorCode.SelectionColor = Color.Black;
            }

            Regex rx2 = new Regex("private");
            int index2 = rtxt_PpErrorCode.SelectionStart;

            foreach (Match m2 in rx2.Matches(rtxt_PpErrorCode.Text))
            {
                rtxt_PpErrorCode.Select(m2.Index, m2.Value.Length);
                rtxt_PpErrorCode.SelectionColor = Color.BlueViolet;
                rtxt_PpErrorCode.SelectionStart = index;
                rtxt_PpErrorCode.SelectionColor = Color.Black;
            }
        }

        private void rtxt_PpUpdateCode_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex("class");
            int index = rtxt_PpUpdateCode.SelectionStart;

            foreach (Match m in rx.Matches(rtxt_PpUpdateCode.Text))
            {
                rtxt_PpUpdateCode.Select(m.Index, m.Value.Length);
                rtxt_PpUpdateCode.SelectionColor = Color.Blue;
                rtxt_PpUpdateCode.SelectionStart = index;
                rtxt_PpUpdateCode.SelectionColor = Color.Black;
            }

            Regex rx1 = new Regex("String");
            int index1 = rtxt_PpUpdateCode.SelectionStart;

            foreach (Match m1 in rx1.Matches(rtxt_PpErrorCode.Text))
            {
                rtxt_PpUpdateCode.Select(m1.Index, m1.Value.Length);
                rtxt_PpUpdateCode.SelectionColor = Color.Green;
                rtxt_PpUpdateCode.SelectionStart = index;
                rtxt_PpUpdateCode.SelectionColor = Color.Black;
            }

            Regex rx2 = new Regex("private");
            int index2 = rtxt_PpUpdateCode.SelectionStart;

            foreach (Match m2 in rx2.Matches(rtxt_PpErrorCode.Text))
            {
                rtxt_PpUpdateCode.Select(m2.Index, m2.Value.Length);
                rtxt_PpUpdateCode.SelectionColor = Color.BlueViolet;
                rtxt_PpUpdateCode.SelectionStart = index;
                rtxt_PpUpdateCode.SelectionColor = Color.Black;
            }
        }

        private void btn_Logout_Click_1(object sender, EventArgs e)
        {
            //logout
            this.Close();
            Login lol = new Login();
            lol.Show();
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            //exit program
            DialogResult value = MessageBox.Show("Do you really want to exit program?", "Confirm exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (value == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ViewImage_Click(object sender, EventArgs e)
        {

        }
    }
}
