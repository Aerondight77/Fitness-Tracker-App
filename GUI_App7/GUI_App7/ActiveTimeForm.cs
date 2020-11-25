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
    public partial class ActiveTimeForm : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtLogin_Table = new DataTable();

        //public static int ActiveTime;

        public ActiveTimeForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAddTime.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid amount of water.");
            }
            else
            {
                int activeTime = int.Parse(txtAddTime.Text);
                int activeTimeTotal = int.Parse(txtTotalTime.Text);
                activeTimeTotal += activeTime;

                string query = "Update Login_Table SET ActiveTime = '" + activeTimeTotal + "' where ID = '" + LoginForm.id + "'";

                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@activeTimeTotal", @activeTimeTotal);

                int row = objDBAccess.executeQuery(updateCommand);

                if (row == 1)
                {
                    txtTotalTime.Clear();
                    txtTotalTime.AppendText(activeTimeTotal.ToString());
                    txtAddTime.Clear();
                    MessageBox.Show("Active Time data successfully updated.");
                }
                else
                {
                    MessageBox.Show("Active Time data failed to update.");
                }
            }
        }

        private void ActiveTimeForm_Load(object sender, EventArgs e)
        {
            int activeTimeTotal;
            string query = "SELECT ActiveTime FROM Login_Table where ID = '" + LoginForm.id + "'";

            SqlCommand getCommand = new SqlCommand(query);

            objDBAccess.readDatathroughAdapter(query, dtLogin_Table);

            if (dtLogin_Table.Rows.Count == 1)
            {
                activeTimeTotal = int.Parse(dtLogin_Table.Rows[0]["ActiveTime"].ToString());

                objDBAccess.closeConn();

                txtTotalTime.Clear();
                txtTotalTime.AppendText(activeTimeTotal.ToString());
            }
            else
            {
                MessageBox.Show("Unable to load Active Time data. Please try again.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            int empty = 0;
            string query = "Update Login_Table SET ActiveTime = '" + @empty + "' where ID = '" + LoginForm.id + "'";
            SqlCommand updateCommand = new SqlCommand(query);

            updateCommand.Parameters.AddWithValue("@empty", @empty);

            int row = objDBAccess.executeQuery(updateCommand);

            if (row == 1)
            {
                txtTotalTime.Clear();
                txtTotalTime.AppendText(empty.ToString());
            }
            else
            {
                // Debug purposes.
                MessageBox.Show("Error in resetting active time data.");
            }
        }
    }
}
