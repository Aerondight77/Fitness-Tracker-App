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
    public partial class AccountSettings : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtLogin_Table = new DataTable();

        public AccountSettings()
        {
            InitializeComponent();
        }

        private void btnUpdateUsername_Click(object sender, EventArgs e)
        {
            string newUsername = txtNewUsername.Text;
            if (newUsername.Equals(""))
            {
                MessageBox.Show("Please enter a new username.");
            }
            else
            {
                string query = "Update Login_Table SET Username = '" + @newUsername + "' where ID = '" + LoginForm.id + "'";
                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@newUsername", newUsername);

                int row = objDBAccess.executeQuery(updateCommand);
                if (row == 1)
                {
                    MessageBox.Show("Username updated successfully.");
                    txtNewUsername.Clear();
                    txtCurrentUsername.Clear();
                    txtCurrentUsername.AppendText(newUsername);
                }
                else
                {
                    MessageBox.Show("Error in updating new username.");
                }
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string newPass1 = txtNewPass1.Text;
            string newPass2 = txtNewPass2.Text;
            if (newPass1.Equals(""))
            {
                MessageBox.Show("Please enter a new password.");
            }
            else if (newPass2.Equals(""))
            {
                MessageBox.Show("Please enter something in the \"Confirm new password\" field");
            }
            else if (!newPass1.Equals(newPass2))
            {
                MessageBox.Show("New passwords don't match.");
            }
            else
            {
                string query = "Update Login_Table SET Password = '" + @newPass1 + "' where ID = '" + LoginForm.id + "'";
                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@newPass1", newPass1);

                int row = objDBAccess.executeQuery(updateCommand);
                if (row == 1)
                {
                    MessageBox.Show("New password updated successfully.");
                    txtNewPass1.Clear();
                    txtNewPass2.Clear();
                }
                else
                {
                    MessageBox.Show("Error in updating new password.");
                }
            }
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {
            string userName;
            string query = "SELECT Username FROM Login_Table where ID = '" + LoginForm.id + "'";

            objDBAccess.readDatathroughAdapter(query, dtLogin_Table);

            if (dtLogin_Table.Rows.Count == 1)
            {
                userName = dtLogin_Table.Rows[0]["Username"].ToString();
                objDBAccess.closeConn();
                txtCurrentUsername.Clear();
                txtCurrentUsername.AppendText(userName);
            }
            else
            {
                MessageBox.Show("Error loading current username.");
            }

            //txtCurrentUsername.Text = LoginForm.username;
        }
    }
}
