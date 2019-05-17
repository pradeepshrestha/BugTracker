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
    /// inheriting the property of a form by login class
    /// </summary>
    public partial class Login : Form
    {

        //declaring variable to pass the value to the trackerpannel and programmer panel
        /// <summary>
        /// declaring variable to pass the value to the trackerpannel and programmer panel
        /// Declaring Public static String
        /// </summary>
        public static String usridpass,usrnamepass,usrtypepass;


        //function for login initialization
        /// <summary>
        /// initializing component
        /// </summary>
        public Login()
        {
            InitializeComponent();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {

        }

        //function for database calling
        /// <summary>
        /// database calling
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            //creating database connection
            databaseConnection dc = new databaseConnection();
            String sql_login = "SELECT * FROM tbl_userlogin WHERE UserName = '" + txtUsername.Text + "' AND Password= '" + txtPassword.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql_login, dc.Db_Connect());
            MySqlDataReader r = cmd.ExecuteReader();


            if (r.Read())
            {

                //retrieveing value from column and sending value to the top declare variable(line 18) for tracker panel.
                String idpass = r.GetString("User_Id");
                usridpass = idpass;


                String unamepass = r.GetString("UserName");
                usrnamepass = unamepass;

                String usertype = r.GetString("Usr_Type");
                usrtypepass = usertype;
                //Checking User Types
                switch (usertype)
                {

                    case "Programmer":
                        MessageBox.Show("welcome to BugTracking System (Programmer)");
                        ProgrammerPanel pp = new ProgrammerPanel();
                        pp.Show();
                        break;

                    case "Admin":
                        MessageBox.Show("welcome to BugTracking System (Admin)");
                        AdminPanel ap = new AdminPanel();
                        ap.Show();
                        break;
                    case "Tracker":
                        MessageBox.Show("welcome to BugTracking System (Tracker)");
                        TrackerPanel tp = new TrackerPanel();
                        tp.Show();

                        //  tp.lbl_Usershow.Text = idpass;

                        break;
                    default:
                        MessageBox.Show(usertype);
                        MessageBox.Show("welcome to BugTracking System (error!!!!!!)");
                        TrackerPanel err = new TrackerPanel();
                        err.Show();
                        break;

                }
                //for hiding loginpanel
                this.Hide();
                //for closing database connection
                dc.CloseConnection();

            }
            else
            {
                MessageBox.Show("Username or Password incorrect!!!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// calling nest pannel by making object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblNewAccount_Click_1(object sender, EventArgs e)
        {
            //redirecting the page to NewUser
            NewUser newUser = new NewUser();
            newUser.Show();

            //for hiding loginpanel
            this.Hide();
        }
    }
}
