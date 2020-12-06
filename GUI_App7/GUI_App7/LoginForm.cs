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
        public static string id, firstName, lastName, username, password;

        DBAccess objDBAccess = new DBAccess();
        DataTable dtLogin_Table = new DataTable();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUsernameLogin.Text;
            string passWord = txtPassword.Text;
            if (userName.Equals(""))
            {
                MessageBox.Show("Please enter your username.");
            }
            else if (passWord.Equals(""))
            {
                MessageBox.Show("Please enter your password.");
            }
            else
            {
                string query = "Select * from Login_Table Where Username= '" + userName + "' AND Password= '" + passWord + "'";

                // Reading the data in the database line by line.
                objDBAccess.readDatathroughAdapter(query, dtLogin_Table);

                // If data is successfully inserted into the data table.
                if (dtLogin_Table.Rows.Count == 1)
                {
                    id = dtLogin_Table.Rows[0]["ID"].ToString();
                    firstName = dtLogin_Table.Rows[0]["First Name"].ToString();
                    lastName = dtLogin_Table.Rows[0]["Last Name"].ToString();
                    username = dtLogin_Table.Rows[0]["Username"].ToString();
                    password = dtLogin_Table.Rows[0]["Password"].ToString();

                    // Credentials are correct, send user to the MainForm.
                    objDBAccess.closeConn();
                    new MainForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials. Please try again.");
                }
            }
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
