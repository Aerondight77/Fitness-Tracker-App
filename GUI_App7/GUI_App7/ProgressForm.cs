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
    public partial class ProgressForm : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtLogin_Table = new DataTable();

        public ProgressForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int goal = int.Parse(txtWeeklyGoal.Text);
            if (goal == 0)
            {
                MessageBox.Show("Please enter a valid Weekly Goal value.");
            }
            else
            {
                int mon = int.Parse(txtBurnedMon.Text);
                int tues = int.Parse(txtBurnedTues.Text);
                int wed = int.Parse(txtBurnedWed.Text);
                int thur = int.Parse(txtBurnedThu.Text);
                int fri = int.Parse(txtBurnedFri.Text);
                int sat = int.Parse(txtBurnedSat.Text);
                int sun = int.Parse(txtBurnedSun.Text);

                string query =
                    "Update Login_Table SET CalBurnedMon = '" + @mon + "', CalBurnedTue = '" + @tues + "', CalBurnedWed = '" + @wed + "', CalBurnedThur = '" + @thur +
                    "', CalBurnedFri = '" + @fri + "', CalBurnedSat = '" + @sat + "', CalBurnedSun = '" + @sun + "', CalBurnedGoal = '" + @goal + "' where ID = '" +
                    LoginForm.id + "'";

                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@mon", @mon);
                updateCommand.Parameters.AddWithValue("@tues", @tues);
                updateCommand.Parameters.AddWithValue("@wed", @wed);
                updateCommand.Parameters.AddWithValue("@thur", @thur);
                updateCommand.Parameters.AddWithValue("@fri", @fri);
                updateCommand.Parameters.AddWithValue("@sat", @sat);
                updateCommand.Parameters.AddWithValue("@sun", @sun);
                updateCommand.Parameters.AddWithValue("@goal", @goal);

                int row = objDBAccess.executeQuery(updateCommand);
                if (row == 1)
                {
                    int total = mon + tues + wed + thur + fri + sat + sun;
                    txtTotalCal.Clear();
                    txtTotalCal.AppendText(total.ToString());
                    double percent = (total / goal) * 100;
                    txtPercent.Clear();
                    txtPercent.AppendText(percent.ToString());
                }

            }
        }
    }
}
