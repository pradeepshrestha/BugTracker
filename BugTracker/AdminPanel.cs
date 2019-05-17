using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//connection library for MySql
using MySql.Data.MySqlClient;
//selenium webdriver for git
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BugTracker
{
    //inheriting the property of form
    /// <summary>
    /// inheriting the property of a form by AdminPanel class
    /// </summary>
    public partial class AdminPanel : Form
    {
        //declaring variable to pass the value
        /// <summary>
        /// declaring string variable to pass the value
        /// Declaring Public static String
        /// </summary>
        public static String usidpassth;

        //function for login initialization
        /// <summary>
        /// initializing component
        /// </summary>
        public AdminPanel()
        {
            InitializeComponent();
            usidpassth = Login.usridpass;
            String utypepass = Login.usrtypepass;
            lbl_ApLUserName.Text = Login.usrnamepass + " (" + utypepass+ ")";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Loading the data grid on the AdminPanel_Load
        /// </summary>
        public void AdminPanel_Load(object sender, EventArgs e)
        {
            try
            {
                //loading datagrid data at the page load
                databaseConnection con1 = new databaseConnection();
                string sql_Usrlist = "Select User_Id,UserName from tbl_userlogin group by User_Id Asc";
                MySqlCommand cmd1 = new MySqlCommand(sql_Usrlist, con1.Db_Connect());

                DataTable dt = new DataTable();
                MySqlDataAdapter msda1 = new MySqlDataAdapter(cmd1);
                dt.Clear();
                msda1.Fill(dt);
                dataGridView_ApUserList.DataSource = dt;
                con1.CloseConnection();



                //loading new buglist with no solution reply
                databaseConnection con = new databaseConnection();
                string sql_Buglist = "Select B_Id,B_Subject from tbl_bug where B_Update=''";
                MySqlCommand cmd = new MySqlCommand(sql_Buglist, con.Db_Connect());

                DataTable dt1 = new DataTable();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
                dt1.Clear();
                msda.Fill(dt1);
                dataGridView_APBGL.DataSource = dt1;
                con.CloseConnection();


                //loading solved buglist with  solution reply
                databaseConnection con2 = new databaseConnection();
                string sql_BuglistSolve = "Select B_Id,B_Subject from tbl_bug where B_Update!=''";
                MySqlCommand cmd2 = new MySqlCommand(sql_BuglistSolve, con2.Db_Connect());

                DataTable dt2 = new DataTable();
                MySqlDataAdapter msda2 = new MySqlDataAdapter(cmd2);
                dt2.Clear();
                msda2.Fill(dt2);
                dataGridView_APBGS.DataSource = dt2;
                con2.CloseConnection();
            }
            catch (Exception)
            {

                
            }
        }
        public void AdminPanelfun()
        {
            try
            {
                
                //loading data in datagrid view in page load
                databaseConnection con1 = new databaseConnection();
                string sql_Usrlist = "Select User_Id,UserName from tbl_userlogin";
                MySqlCommand cmd1 = new MySqlCommand(sql_Usrlist, con1.Db_Connect());

                DataTable dt = new DataTable();
                MySqlDataAdapter msda1 = new MySqlDataAdapter(cmd1);
                dt.Clear();
                msda1.Fill(dt);
                dataGridView_ApUserList.DataSource = dt;
                con1.CloseConnection();



                //loading new buglist with no solution reply
                databaseConnection con = new databaseConnection();
                string sql_Buglist = "Select B_Id,B_Subject from tbl_bug where B_Update=''";
                MySqlCommand cmd = new MySqlCommand(sql_Buglist, con.Db_Connect());

                DataTable dt1 = new DataTable();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
                dt1.Clear();
                msda.Fill(dt1);
                dataGridView_APBGL.DataSource = dt1;
                con.CloseConnection();


                //loading solved buglist with  solution reply
                databaseConnection con2 = new databaseConnection();
                string sql_BuglistSolve = "Select B_Id,B_Subject from tbl_bug where B_Update!=''";
                MySqlCommand cmd2 = new MySqlCommand(sql_BuglistSolve, con2.Db_Connect());

                DataTable dt2 = new DataTable();
                MySqlDataAdapter msda2 = new MySqlDataAdapter(cmd2);
                dt2.Clear();
                msda2.Fill(dt2);
                dataGridView_APBGS.DataSource = dt2;
                con2.CloseConnection();



            }
            catch (Exception)
            {


            }
        }

        private void dataGridView_ApUserList_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_ApView_Click(object sender, EventArgs e)
        {
            //creating upcomming userdetailview form object in this form
            UserDetailView frm = new UserDetailView();
            //load data from datagridview to UserDetailView form in label
            frm.lbl_UdUsrId.Text = this.dataGridView_ApUserList.CurrentRow.Cells[0].Value.ToString();
            frm.Show();
            
            

        }

        /// <summary>
        /// passing valuethrough objects created for page opening
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ApEdit_Click(object sender, EventArgs e)
        {
            //creating upcomming userdetailview form object in this form
            UserDetailEdit frm = new UserDetailEdit();
            //load data from datagridview to UserDetailView form in label
            frm.lbl_UdEUsrId.Text = this.dataGridView_ApUserList.CurrentRow.Cells[0].Value.ToString();
            frm.Show();
        }

        /// <summary>
        /// logging out the user via btn_ApLogout
        /// </summary>
        private void btn_ApLogout_Click(object sender, EventArgs e)
        {   
            //logout
            this.Close();
            Login lol = new Login();
            lol.Show();
        }

        /// <summary>
        /// closing the form via btn_ApExit
        /// </summary>
        private void btn_ApExit_Click(object sender, EventArgs e)
        {
            //exit program
            DialogResult value = MessageBox.Show("Do you really want to exit program?", "Confirm exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (value == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }

        /// <summary>
        /// displaying groupBox via button1
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox_Changepassword.Show();
        }

        /// <summary>
        /// displaying the value for gridview by creating object
        /// </summary>
        private void btn_ApBGLView_Click(object sender, EventArgs e)
        {
            //creating upcomming userdetailview form object in this form
            BugDetailView frm = new BugDetailView();
            //load data from datagridview to UserDetailView form in label
            frm.lbl_BGDBugid.Text = this.dataGridView_APBGL.CurrentRow.Cells[0].Value.ToString();
            frm.Show();
        }

        /// <summary>
        /// displaying the value for gridview by creating object
        /// </summary>
        private void btn_APBGSView_Click(object sender, EventArgs e)
        {
            //creating upcomming userdetailview form object in this form
            BugDetailView frm = new BugDetailView();
            //load data from datagridview to UserDetailView form in label
            frm.lbl_BGDBugid.Text = this.dataGridView_APBGS.CurrentRow.Cells[0].Value.ToString();
            frm.Show();
        }

        /// <summary>
        /// creating object for changing the password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_APchangepassDone_Click(object sender, EventArgs e)
        {
            databaseConnection con = new databaseConnection();
            string sql_LUserlist = "Select * from tbl_userlogin where User_Id = '"+ usidpassth + "' ";
            MySqlCommand cmd1 = new MySqlCommand(sql_LUserlist, con.Db_Connect());
            MySqlDataReader r = cmd1.ExecuteReader();

            if (r.Read())
            {
                String OldPassword = r.GetString("Password");
                if (OldPassword == txt_APOldPassword.Text)
                {
                    if (txt_APNewPassword.Text == txt_APConfirmPassword.Text)
                    {
                        string sql_updateBug = "UPDATE tbl_userlogin SET Password='" + txt_APConfirmPassword.Text + "' WHERE User_Id= '" + usidpassth + "'";
                        MySqlCommand cmd2 = new MySqlCommand(sql_updateBug, con.Db_Connect());
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Password changed successfully!!!");

                        txt_APOldPassword.Clear();
                        txt_APNewPassword.Clear();
                        txt_APConfirmPassword.Clear();

                        groupBox_Changepassword.Hide();
                    }
                    else
                    {
                        MessageBox.Show("New password and Confirm password do not match!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Old Password not match");
                }


                
            }
            else
            {

            }
        }

        /// <summary>
        /// creating object of another page for opening
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_APUserRequestList_Click(object sender, EventArgs e)
        {

            RequestList requestList = new RequestList();
            requestList.Show();
        }

        /// <summary>
        /// connecting to gitlab via btn_connectgitlab_click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_connectgitlab_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            // Launch the ToolsQA WebSite
            driver.Url = ("https://github.com/pradeepshrestha/BugTracker.git");

            // Type Name in the FirstName text box      
            //driver.FindElement(By.Name("firstname")).SendKeys("pradeepshrestha");
            driver.FindElement(By.Id("user_login")).SendKeys("pradeepshrestha");

            //Type LastName in the LastName text box
            driver.FindElement(By.Id("user_password")).SendKeys("Pradip3421");

            // Click on the Submit button
            driver.FindElement(By.Name("commit")).Click();
        }

        private void dataGridView_ApUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
