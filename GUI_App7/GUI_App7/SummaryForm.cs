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
    public partial class SummaryForm : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtLogin_Table = new DataTable();

        public SummaryForm()
        {
            InitializeComponent();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            string toDo1, toDo2, toDo3, toDo4, toDo5;

            string query = "SELECT ToDo1,ToDo2,ToDo3,ToDo4,ToDo5 FROM Login_Table where ID = '" + LoginForm.id + "'";

            SqlCommand getCommand = new SqlCommand(query);

            objDBAccess.readDatathroughAdapter(query, dtLogin_Table);

            if (dtLogin_Table.Rows.Count == 1)
            {
                toDo1 = dtLogin_Table.Rows[0]["ToDo1"].ToString();
                toDo2 = dtLogin_Table.Rows[0]["ToDo2"].ToString();
                toDo3 = dtLogin_Table.Rows[0]["ToDo3"].ToString();
                toDo4 = dtLogin_Table.Rows[0]["ToDo4"].ToString();
                toDo5 = dtLogin_Table.Rows[0]["ToDo5"].ToString();

                objDBAccess.closeConn();

                txtToDo1.AppendText(toDo1);
                txtToDo2.AppendText(toDo2);
                txtToDo3.AppendText(toDo3);
                txtToDo4.AppendText(toDo4);
                txtToDo5.AppendText(toDo5);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string toDo1 = txtToDo1.Text;
            string toDo2 = txtToDo2.Text;
            string toDo3 = txtToDo3.Text;
            string toDo4 = txtToDo4.Text;
            string toDo5 = txtToDo5.Text;

            string query = "Update Login_Table SET ToDo1 = '" + @toDo1 + "', ToDo2 = '" + @toDo2 + "', ToDo3 = '" + @toDo3 + "', ToDo4 = '"
                + @toDo4 + "', ToDo5 = '" + @toDo5 + "' where ID = '" + LoginForm.id + "'";

            SqlCommand updateCommand = new SqlCommand(query);

            updateCommand.Parameters.AddWithValue("@toDo1", @toDo1);
            updateCommand.Parameters.AddWithValue("@toDo2", @toDo2);
            updateCommand.Parameters.AddWithValue("@toDo3", @toDo3);
            updateCommand.Parameters.AddWithValue("@toDo4", @toDo4);
            updateCommand.Parameters.AddWithValue("@toDo5", @toDo5);

            int row = objDBAccess.executeQuery(updateCommand);
            if (row == 1)
            {
                // Debug purposes.
                MessageBox.Show("Successfully updated information.");
            }
            else
            {
                MessageBox.Show("Failed to update information.");
            }
        }

        private void lblComplete1_Click(object sender, EventArgs e)
        {
            string empty = "";
            string query = "Update Login_Table SET ToDo1 = '" + @empty + "' where ID = '" + LoginForm.id + "'";
            SqlCommand updateCommand = new SqlCommand(query);

            updateCommand.Parameters.AddWithValue("@empty", @empty);

            int row = objDBAccess.executeQuery(updateCommand);
            if (row == 1)
            {
                txtToDo1.Clear();
                txtToDo1.AppendText(empty);
            }
            else
            {
                // Debug purposes.
                MessageBox.Show("Error in removing ToDo1.");
            }
        }

        private void lblCompleted2_Click(object sender, EventArgs e)
        {
            string empty = "";
            string query = "Update Login_Table SET ToDo2 = '" + @empty + "' where ID = '" + LoginForm.id + "'";
            SqlCommand updateCommand = new SqlCommand(query);

            updateCommand.Parameters.AddWithValue("@empty", @empty);

            int row = objDBAccess.executeQuery(updateCommand);
            if (row == 1)
            {
                txtToDo2.Clear();
                txtToDo2.AppendText(empty);
            }
            else
            {
                // Debug purposes.
                MessageBox.Show("Error in removing ToDo2.");
            }
        }

        private void lblCompleted3_Click(object sender, EventArgs e)
        {
            string empty = "";
            string query = "Update Login_Table SET ToDo3 = '" + @empty + "' where ID = '" + LoginForm.id + "'";
            SqlCommand updateCommand = new SqlCommand(query);

            updateCommand.Parameters.AddWithValue("@empty", @empty);

            int row = objDBAccess.executeQuery(updateCommand);
            if (row == 1)
            {
                txtToDo3.Clear();
                txtToDo3.AppendText(empty);
            }
            else
            {
                // Debug purposes.
                MessageBox.Show("Error in removing ToDo3.");
            }
        }

        private void lblCompleted4_Click(object sender, EventArgs e)
        {
            string empty = "";
            string query = "Update Login_Table SET ToDo4 = '" + @empty + "' where ID = '" + LoginForm.id + "'";
            SqlCommand updateCommand = new SqlCommand(query);

            updateCommand.Parameters.AddWithValue("@empty", @empty);

            int row = objDBAccess.executeQuery(updateCommand);
            if (row == 1)
            {
                txtToDo4.Clear();
                txtToDo4.AppendText(empty);
            }
            else
            {
                // Debug purposes.
                MessageBox.Show("Error in removing ToDo4.");
            }
        }

        private void lblCompleted5_Click(object sender, EventArgs e)
        {
            string empty = "";
            string query = "Update Login_Table SET ToDo5 = '" + @empty + "' where ID = '" + LoginForm.id + "'";
            SqlCommand updateCommand = new SqlCommand(query);

            updateCommand.Parameters.AddWithValue("@empty", @empty);

            int row = objDBAccess.executeQuery(updateCommand);
            if (row == 1)
            {
                txtToDo5.Clear();
                txtToDo5.AppendText(empty);
            }
            else
            {
                // Debug purposes.
                MessageBox.Show("Error in removing ToDo5.");
            }
        }
    }
}
