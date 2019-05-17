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
    //inheriting the property of form
    /// <summary>
    /// inheriting the property of a form by NewUser class
    /// </summary>
    public partial class NewUser : Form
    {
        //function for NewUser initialization
        /// <summary>
        /// initializing component
        /// </summary>
        public NewUser()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //object for btn_NUSubmit
        /// <summary>
        /// connecting to database
        /// </summary>
        private void btn_NUSubmit_Click(object sender, EventArgs e)
        {

            databaseConnection con = new databaseConnection();
            string sql_LUserlist = "Select UserName from tbl_userlogin";
            MySqlCommand cmd1 = new MySqlCommand(sql_LUserlist, con.Db_Connect());
            MySqlDataReader r = cmd1.ExecuteReader();

            if (r.Read())
            {
                String UserNameCheck = r.GetString("UserName");
                if (txt_NUUsername.Text != UserNameCheck)
                {
                    try
                    {
                        
                        if (txt_NUConfPass.Text == txt_NUPassword.Text)
                        {
                            //Connecting to the database for checking unique username
                            String sql_insertusr = "INSERT INTO tbl_userlogin(UserName, Password, Usr_Type,Request_Verified) VALUES ('" + txt_NUUsername.Text + "','" + txt_NUPassword.Text + "','Tracker','No')";
                            MySqlCommand cmd2 = new MySqlCommand(sql_insertusr, con.Db_Connect());
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("User " + txt_NUUsername.Text + " successfully Created!!!");

                            //clearing the text box
                            txt_NUUsername.Clear();
                            txt_NUPassword.Clear();
                            txt_NUConfPass.Clear();

                            //closing connection
                            this.Close();
                        }
                        else
                        {
                            //displaying error message
                            MessageBox.Show("Password do not match.");
                        }
                    }
                    catch (Exception)
                    {
                        //displaying error message
                        MessageBox.Show("User Name already exists.");
                        txt_NUUsername.Clear();
                        txt_NUPassword.Clear();
                        txt_NUConfPass.Clear();
                        
                        
                    }
                    
                }

                else
                {
                    MessageBox.Show("UserName already exist!!!");
                }
            }
            else
            {

            }

            //redirecting the page to Login
            Login login = new Login();
            login.Show();

            //for hiding loginpanel
            this.Hide();

        }

        private void txt_NUConfPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NUPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NUUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
