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
    public partial class RequestList : Form
    {
        public RequestList()
        {
            InitializeComponent();
        }

        private void RequestList_Load(object sender, EventArgs e)
        {
            databaseConnection con1 = new databaseConnection();
            string sql_Usrlist = "Select User_Id,UserName from tbl_userlogin where Request_Verified='Wait' ";
            MySqlCommand cmd1 = new MySqlCommand(sql_Usrlist, con1.Db_Connect());

            DataTable dt = new DataTable();
            MySqlDataAdapter msda1 = new MySqlDataAdapter(cmd1);
            dt.Clear();
            msda1.Fill(dt);
            dataGridView_RequestList.DataSource = dt;
            con1.CloseConnection();
        }

        private void btn_RequestAccept_Click(object sender, EventArgs e)
        {
            //storing selected rows id into variable
            String RequestId= dataGridView_RequestList.CurrentRow.Cells[0].Value.ToString();

            databaseConnection con = new databaseConnection();
            string sql_updateUserType = "UPDATE tbl_userlogin SET Request_Verified='Yes',Usr_Type='Programmer' WHERE User_Id= '" + RequestId + "'";
            MySqlCommand cmd2 = new MySqlCommand(sql_updateUserType, con.Db_Connect());
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Successfully changed User Type from 'Tracker' to 'Programmer'.");

            //Refreshing data again
            databaseConnection con1 = new databaseConnection();
            string sql_Usrlist = "Select User_Id,UserName from tbl_userlogin where Request_Verified='Wait' ";
            MySqlCommand cmd1 = new MySqlCommand(sql_Usrlist, con1.Db_Connect());

            DataTable dt = new DataTable();
            MySqlDataAdapter msda1 = new MySqlDataAdapter(cmd1);
            dt.Clear();
            msda1.Fill(dt);
            dataGridView_RequestList.DataSource = dt;
            con1.CloseConnection();

        }
    }
}
