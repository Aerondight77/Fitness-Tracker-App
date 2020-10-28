using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace GUI_App7
{
    public partial class LoginForm : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtLogin_Table = new DataTable();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsernameLogin.Text;
            string password = txtPassword.Text;
            if (username.Equals(""))
            {
                MessageBox.Show("Please enter your username.");
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Please enter your password.");
            }
            else
            {
                string query = "Select * from Login_Table Where Username= '" + username + "' AND Password= '" + password + "'";

                // Reading the data in the database line by line.
                objDBAccess.readDatathroughAdapter(query, dtLogin_Table);

                if (dtLogin_Table.Rows.Count == 1)
                {
                    objDBAccess.closeConn();
                    new MainForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Either username or password is incorrect. Please try again.");
                }
            }

            //if (txtUsernameLogin.Text == "admin" && txtPassword.Text == "test123")
            //{
                //new MainForm().Show();
                //this.Hide();
            //}
            //else 
            //{
                //MessageBox.Show("The Username or Password is invalid, try again!");
                //txtUsernameLogin.Clear();
                //txtPassword.Clear();
                //txtUsernameLogin.Focus();
            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsernameLogin.Clear();
            txtPassword.Clear();
            txtUsernameLogin.Focus();

            //new Register().Show();
            //this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }
    }
}
