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

namespace BugTracker
{
    public partial class UserDetailView : Form
    {
        public UserDetailView()
        {
            InitializeComponent();
        }

        private void UserDetailView_Load(object sender, EventArgs e)
        {
            //user view
            databaseConnection con = new databaseConnection();
            string sql_UdUsrDetail = "Select UserName, Usr_Type from tbl_userlogin where User_Id ='" + lbl_UdUsrId.Text + "'";
            string sql_UdNumBugList = "Select count(B_Id) as countbug from tbl_bug where User_Id ='" + lbl_UdUsrId.Text + "'";
            MySqlCommand cmd1 = new MySqlCommand(sql_UdUsrDetail, con.Db_Connect());
            MySqlCommand cmd2 = new MySqlCommand(sql_UdNumBugList, con.Db_Connect());
            MySqlDataReader r = cmd1.ExecuteReader();
            MySqlDataReader r2 = cmd2.ExecuteReader();

            if (r.Read() && r2.Read())
            {
                lbl_UdNumBugReport.Text = r2.GetString("countbug");
                lbl_UdUsrName.Text = r.GetString("UserName");
                lbl_UdUsrType.Text = r.GetString("Usr_Type");
                
            }
            else
            {
                MessageBox.Show("error !!!!!!   UserName aand Usr_Type not shown");

            }
            con.CloseConnection();

        }

        private void btn_UdDeleteUsr_Click(object sender, EventArgs e)
        {
            //deleting users
            DialogResult result = MessageBox.Show("Do you really want to delete this User?", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            databaseConnection con = new databaseConnection();
            if (result == DialogResult.Yes)
            {

                string sql_UdUsrDelete = "DELETE FROM tbl_userlogin WHERE User_Id='" + lbl_UdUsrId.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql_UdUsrDelete, con.Db_Connect());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successful");

                
               
                //working function calling commented
                var principalForm1 = Application.OpenForms.OfType<AdminPanel>().FirstOrDefault();
                principalForm1.AdminPanelfun();


                

            }
            this.Close();
        }

        private void btn_UdOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
