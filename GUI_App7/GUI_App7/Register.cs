using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_App7
{
    public partial class Register : Form
    {
        DBAccess objDBAccess = new DBAccess();

        public Register()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string username = txtUsername.Text;
            string password1 = txtPassword1.Text;
            string password2 = txtPassword2.Text;

            if (firstName.Equals(""))
            {
                MessageBox.Show("Please enter your first name.");
            }
            else if (lastName.Equals(""))
            {
                MessageBox.Show("Please enter your last name.");
            }
            else if (username.Equals(""))
            {
                MessageBox.Show("Please enter your email.");
            }
            else if (password1.Equals(""))
            {
                MessageBox.Show("Please enter a password.");
            }
            else if (password2.Equals(""))
            {
                MessageBox.Show("Please confirm password.");
            }
            else if (!password1.Equals(password2))
            {
                MessageBox.Show("Passwords do not match.");
            }
            else
            {
                // Inserting info into database.
                SqlCommand insertCommand = new SqlCommand("insert into Login_Table([First Name],[Last Name],Username,Password) values(@firstName, @lastName, @username, @password1)");
                
                // Making the data private, no one can see it. Might be redundant for our program.
                insertCommand.Parameters.AddWithValue("@firstName", firstName);
                insertCommand.Parameters.AddWithValue("@lastName", lastName);
                insertCommand.Parameters.AddWithValue("@username", username);
                insertCommand.Parameters.AddWithValue("@password1", password1);

                int row = objDBAccess.executeQuery(insertCommand);

                // If it works, send the user to the login form.
                if (row == 1)
                {
                    new LoginForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error Occured. Try again.");
                }

                
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
