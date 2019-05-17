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
    public partial class UserDetailEdit : Form
    {
        public UserDetailEdit()
        {
            InitializeComponent();
        }

        private void btn_UDEDone_Click(object sender, EventArgs e)
        {
            string rbvalue;
            if (rb_Admin.Checked)
            {
                rbvalue = rb_Admin.Text;
            }
            else if (rb_Programmer.Checked)
            {
                rbvalue = rb_Programmer.Text;
            }
            else
            {
                rbvalue = rb_Tracker.Text;
            }
            databaseConnection con = new databaseConnection();
            string sql_updateUDEUpdate = "UPDATE tbl_userlogin SET Usr_Type='" + rbvalue + "' WHERE User_Id= '" + lbl_UdEUsrId.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql_updateUDEUpdate, con.Db_Connect());
            cmd.ExecuteNonQuery();
            con.CloseConnection();


            MessageBox.Show("Update Successful");
            this.Close();
            //Refreshing data of datagrid view   calling function of admin panel
            var principalForm1 = Application.OpenForms.OfType<AdminPanel>().FirstOrDefault();
            principalForm1.AdminPanelfun();

        }

        private void UserDetailEdit_Load(object sender, EventArgs e)
        {
            databaseConnection con = new databaseConnection();
            string sql_UDEUsrDetail = "Select UserName, Usr_Type from tbl_userlogin where User_Id ='" + lbl_UdEUsrId.Text + "'";
            MySqlCommand cmd1 = new MySqlCommand(sql_UDEUsrDetail, con.Db_Connect());
            MySqlDataReader r = cmd1.ExecuteReader();

            if (r.Read())
            {
                lbl_UDEUsrname.Text = r.GetString("UserName");
                String rbtypecheck = r.GetString("Usr_Type");
                switch (rbtypecheck)
                {
                    case "Admin":
                        rb_Admin.Checked = true;
                        break;

                    case "Programmer":
                        rb_Programmer.Checked = true;
                        break;
                    case "Tracker":
                        rb_Tracker.Checked = true;
                        break;
                    default:
                        MessageBox.Show("error value pass");
                        break;
                }

            }
            else
            {
                MessageBox.Show("error !!!!!!   UserName aand Usr_Type not shown");

            }
            con.CloseConnection();
        }

        private void btn_UDECancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
