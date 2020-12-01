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
    public partial class PrescriptionTrackerForm : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtLogin_Table = new DataTable();

        public PrescriptionTrackerForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string pill1 = txtPillName1.Text;
            string pill2 = txtPillName2.Text;
            string pill3 = txtPillName3.Text;
            string pill4 = txtPillName4.Text;

            string dateTime1 = txtDateTime1.Text;
            string dateTime2 = txtDateTime2.Text;
            string dateTime3 = txtDateTime3.Text;
            string dateTime4 = txtDateTime4.Text;

            string query = "Update Login_Table SET Pill1Name = '" + @pill1 + "', Pill2Name = '" + @pill2 + "', Pill3Name = '" + @pill3 + "', Pill4Name = '"
                + @pill4 + "', DateTime1 = '" + @dateTime1 + "', DateTime2 = '" + @dateTime2 + "', DateTime3 = '" + @dateTime3 + "', DateTime4 = '" + @dateTime4 
                + "' where ID = '" + LoginForm.id + "'";

            SqlCommand updateCommand = new SqlCommand(query);

            updateCommand.Parameters.AddWithValue("@pill1", @pill1);
            updateCommand.Parameters.AddWithValue("@pill2", @pill2);
            updateCommand.Parameters.AddWithValue("@pill3", @pill3);
            updateCommand.Parameters.AddWithValue("@pill4", @pill4);

            updateCommand.Parameters.AddWithValue("@dateTime1", @dateTime1);
            updateCommand.Parameters.AddWithValue("@dateTime2", @dateTime2);
            updateCommand.Parameters.AddWithValue("@dateTime3", @dateTime3);
            updateCommand.Parameters.AddWithValue("@dateTime4", @dateTime4);

            int row = objDBAccess.executeQuery(updateCommand);

            if (row == 1)
            {
                MessageBox.Show("Successfully updated information.");
            }
            else
            {
                MessageBox.Show("Failed to update information.");
            }
        }

        private void PrescriptionTrackerForm_Load(object sender, EventArgs e)
        {
            string pill1, pill2, pill3, pill4, dateTime1, dateTime2, dateTime3, dateTime4;

            string query = "SELECT Pill1Name,Pill2Name,Pill3Name,Pill4Name,DateTime1,DateTime2,DateTime3,DateTime4 FROM Login_Table where ID = '" + LoginForm.id + "'";

            SqlCommand getCommand = new SqlCommand(query);

            objDBAccess.readDatathroughAdapter(query, dtLogin_Table);

            if (dtLogin_Table.Rows.Count == 1)
            {
                pill1 = dtLogin_Table.Rows[0]["Pill1Name"].ToString();
                pill2 = dtLogin_Table.Rows[0]["Pill2Name"].ToString();
                pill3 = dtLogin_Table.Rows[0]["Pill3Name"].ToString();
                pill4 = dtLogin_Table.Rows[0]["Pill4Name"].ToString();

                dateTime1 = dtLogin_Table.Rows[0]["DateTime1"].ToString();
                dateTime2 = dtLogin_Table.Rows[0]["DateTime2"].ToString();
                dateTime3 = dtLogin_Table.Rows[0]["DateTime3"].ToString();
                dateTime4 = dtLogin_Table.Rows[0]["DateTime4"].ToString();

                objDBAccess.closeConn();

                txtPillName1.AppendText(pill1);
                txtPillName2.AppendText(pill2);
                txtPillName3.AppendText(pill3);
                txtPillName4.AppendText(pill4);

                txtDateTime1.AppendText(dateTime1);
                txtDateTime2.AppendText(dateTime2);
                txtDateTime3.AppendText(dateTime3);
                txtDateTime4.AppendText(dateTime4);
            }
            else
            {
                MessageBox.Show("Failed to load Pills data.");
            }
        }

        private void btnClearPill1_Click(object sender, EventArgs e)
        {
            string empty = "";
            string query = "Update Login_Table SET Pill1Name = '" + @empty + "', DateTime1 = '" + @empty + "' where ID = '" + LoginForm.id + "'";
            SqlCommand updateCommand = new SqlCommand(query);

            updateCommand.Parameters.AddWithValue("@empty", @empty);

            int row = objDBAccess.executeQuery(updateCommand);

            if (row == 1)
            {
                txtPillName1.Clear();
                txtPillName1.AppendText(empty);

                txtDateTime1.Clear();
                txtDateTime1.AppendText(empty);
            }
            else
            {
                MessageBox.Show("Error in removing Pill 1 data.");
            }
        }

        private void btnClearPill2_Click(object sender, EventArgs e)
        {
            string empty = "";
            string query = "Update Login_Table SET Pill2Name = '" + @empty + "', DateTime2 = '" + @empty + "' where ID = '" + LoginForm.id + "'";
            SqlCommand updateCommand = new SqlCommand(query);

            updateCommand.Parameters.AddWithValue("@empty", @empty);

            int row = objDBAccess.executeQuery(updateCommand);

            if (row == 1)
            {
                txtPillName2.Clear();
                txtPillName2.AppendText(empty);

                txtDateTime2.Clear();
                txtDateTime2.AppendText(empty);
            }
            else
            {
                MessageBox.Show("Error in removing Pill 2 data.");
            }
        }

        private void btnClearPill3_Click(object sender, EventArgs e)
        {
            string empty = "";
            string query = "Update Login_Table SET Pill3Name = '" + @empty + "', DateTime3 = '" + @empty + "' where ID = '" + LoginForm.id + "'";
            SqlCommand updateCommand = new SqlCommand(query);

            updateCommand.Parameters.AddWithValue("@empty", @empty);

            int row = objDBAccess.executeQuery(updateCommand);

            if (row == 1)
            {
                txtPillName3.Clear();
                txtPillName3.AppendText(empty);

                txtDateTime3.Clear();
                txtDateTime3.AppendText(empty);
            }
            else
            {
                MessageBox.Show("Error in removing Pill 3 data.");
            }
        }

        private void btnClearPill4_Click(object sender, EventArgs e)
        {
            string empty = "";
            string query = "Update Login_Table SET Pill4Name = '" + @empty + "', DateTime4 = '" + @empty + "' where ID = '" + LoginForm.id + "'";
            SqlCommand updateCommand = new SqlCommand(query);

            updateCommand.Parameters.AddWithValue("@empty", @empty);

            int row = objDBAccess.executeQuery(updateCommand);

            if (row == 1)
            {
                txtPillName4.Clear();
                txtPillName4.AppendText(empty);

                txtDateTime4.Clear();
                txtDateTime4.AppendText(empty);
            }
            else
            {
                MessageBox.Show("Error in removing Pill 4 data.");
            }
        }
    }
}
