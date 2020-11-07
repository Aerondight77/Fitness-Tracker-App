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
    public partial class SleepForm : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtLogin_Table = new DataTable();

        public SleepForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (txtWentSleep.Text.Equals(""))
            //{
               //MessageBox.Show("Please enter the time that you went to sleep.");
            //}
            //else if (txtWokeUp.Text.Equals(""))
            //{
                //MessageBox.Show("Please enter the time that you woke up.");
            //}
            //else
            //{
                //int sleepStart = int.Parse(txtWentSleep.Text);
                //int sleepEnd = int.Parse(txtWokeUp.Text);

                //int hourStart = dateTimePickerSleep.Value.Hour;
                //int hourEnd = dateTimePickerWake.Value.Hour;
            DateTime start = new DateTime(2020, 1, 1, dateTimePickerSleep.Value.Hour, 0, 0);
            DateTime end = new DateTime(2020, 1, 2, dateTimePickerWake.Value.Hour, 0, 0);
            TimeSpan diff = end - start;
            
            double timeSlept = diff.Hours;
            string query = "Update Login_Table SET Sleep = '" + @timeSlept + "' where ID = '" + LoginForm.id + "'";
            SqlCommand updateCommand = new SqlCommand(query);

            updateCommand.Parameters.AddWithValue("@timeSlept", @timeSlept);
            int row = objDBAccess.executeQuery(updateCommand);

            if (row == 1)
            {
                txtTimeSlept.Clear();
                txtTimeSlept.AppendText(timeSlept.ToString());
            }
            else
            {
                MessageBox.Show("Some error occurred.");
            }

            //}

        }
    }
}
