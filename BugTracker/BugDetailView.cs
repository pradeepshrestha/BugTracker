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
    public partial class BugDetailView : Form
    {
        public BugDetailView()
        {
            InitializeComponent();
        }

        private void BugDetailView_Load(object sender, EventArgs e)
        {
            databaseConnection con = new databaseConnection();
            string sql_BugDetailView = "Select B_Subject, B_Describe, B_Code,B_Update, Date from tbl_bug where B_Id ='" + lbl_BGDBugid.Text + "'";
            string sql_BugDetailView1 = "Select tbl_userlogin.UserName from tbl_userlogin left join tbl_bug on tbl_bug.User_Id = tbl_userlogin.User_Id where tbl_bug.B_Id ='" + lbl_BGDBugid.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql_BugDetailView, con.Db_Connect());
            MySqlCommand cmd1 = new MySqlCommand(sql_BugDetailView1, con.Db_Connect());
            MySqlDataReader r = cmd.ExecuteReader();
            MySqlDataReader r1 = cmd1.ExecuteReader();

            if (r.Read() && r1.Read())
            {
                lbl_BGDSubject.Text = r.GetString("B_Subject");
                rtxt_BugDescribtion.Text = r.GetString("B_Describe");
                rtxt_BGDBugProblem.Text = r.GetString("B_Code");
                lbl_BGDTrackUser.Text = r1.GetString("UserName");
                rtxt_BGDBugSolution.Text = r.GetString("B_Update");
                lbl_BGDDate.Text = r.GetString("Date");

            }
            else
            {
                MessageBox.Show("error !!!!!!   UserName aand Usr_Type not shown");

            }
            con.CloseConnection();
        }

        private void btn_BGDDeleteBug_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete this User?", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            databaseConnection con = new databaseConnection();
            if (result == DialogResult.Yes)
            {

                string sql_UdBgListDelete = "DELETE FROM tbl_bug WHERE B_Id='" + lbl_BGDBugid.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql_UdBgListDelete, con.Db_Connect());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successful");



                //working function calling commented
                var principalForm1 = Application.OpenForms.OfType<AdminPanel>().FirstOrDefault();
                principalForm1.AdminPanelfun();




            }
            this.Close();
        }

        private void rtxt_BGDBugProblem_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex("class");
            int index = rtxt_BGDBugProblem.SelectionStart;

            foreach (Match m in rx.Matches(rtxt_BGDBugProblem.Text))
            {
                rtxt_BGDBugProblem.Select(m.Index, m.Value.Length);
                rtxt_BGDBugProblem.SelectionColor = Color.Blue;
                rtxt_BGDBugProblem.SelectionStart = index;
                rtxt_BGDBugProblem.SelectionColor = Color.Black;
            }

            Regex rx1 = new Regex("String");
            int index1 = rtxt_BGDBugProblem.SelectionStart;

            foreach (Match m1 in rx1.Matches(rtxt_BGDBugProblem.Text))
            {
                rtxt_BGDBugProblem.Select(m1.Index, m1.Value.Length);
                rtxt_BGDBugProblem.SelectionColor = Color.Green;
                rtxt_BGDBugProblem.SelectionStart = index;
                rtxt_BGDBugProblem.SelectionColor = Color.Black;
            }

            Regex rx2 = new Regex("private");
            int index2 = rtxt_BGDBugProblem.SelectionStart;

            foreach (Match m2 in rx2.Matches(rtxt_BGDBugProblem.Text))
            {
                rtxt_BGDBugProblem.Select(m2.Index, m2.Value.Length);
                rtxt_BGDBugProblem.SelectionColor = Color.BlueViolet;
                rtxt_BGDBugProblem.SelectionStart = index;
                rtxt_BGDBugProblem.SelectionColor = Color.Black;
            }
        }

        private void rtxt_BGDBugSolution_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex("class");
            int index = rtxt_BGDBugSolution.SelectionStart;

            foreach (Match m in rx.Matches(rtxt_BGDBugSolution.Text))
            {
                rtxt_BGDBugSolution.Select(m.Index, m.Value.Length);
                rtxt_BGDBugSolution.SelectionColor = Color.Blue;
                rtxt_BGDBugSolution.SelectionStart = index;
                rtxt_BGDBugSolution.SelectionColor = Color.Black;
            }

            Regex rx1 = new Regex("String");
            int index1 = rtxt_BGDBugSolution.SelectionStart;

            foreach (Match m1 in rx1.Matches(rtxt_BGDBugSolution.Text))
            {
                rtxt_BGDBugSolution.Select(m1.Index, m1.Value.Length);
                rtxt_BGDBugSolution.SelectionColor = Color.Green;
                rtxt_BGDBugSolution.SelectionStart = index;
                rtxt_BGDBugSolution.SelectionColor = Color.Black;
            }

            Regex rx2 = new Regex("private");
            int index2 = rtxt_BGDBugSolution.SelectionStart;

            foreach (Match m2 in rx2.Matches(rtxt_BGDBugSolution.Text))
            {
                rtxt_BGDBugSolution.Select(m2.Index, m2.Value.Length);
                rtxt_BGDBugSolution.SelectionColor = Color.BlueViolet;
                rtxt_BGDBugSolution.SelectionStart = index;
                rtxt_BGDBugSolution.SelectionColor = Color.Black;
            }
        }

        private void btn_BGDOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
