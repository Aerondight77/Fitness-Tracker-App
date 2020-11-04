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

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            int mon, tues, wed, thur, fri, sat, sun, goal;

            string query =
                    "SELECT CalBurnedMon,CalBurnedTue,CalBurnedWed,CalBurnedThur,CalBurnedFri,CalBurnedSat,CalBurnedSun,CalBurnedGoal FROM Login_Table where ID = '" +
                    LoginForm.id + "'";

            objDBAccess.readDatathroughAdapter(query, dtLogin_Table);

            if (dtLogin_Table.Rows.Count == 1)
            {
                mon = int.Parse(dtLogin_Table.Rows[0]["CalBurnedMon"].ToString());
                tues = int.Parse(dtLogin_Table.Rows[0]["CalBurnedTue"].ToString());
                wed = int.Parse(dtLogin_Table.Rows[0]["CalBurnedWed"].ToString());
                thur = int.Parse(dtLogin_Table.Rows[0]["CalBurnedThur"].ToString());
                fri = int.Parse(dtLogin_Table.Rows[0]["CalBurnedFri"].ToString());
                sat = int.Parse(dtLogin_Table.Rows[0]["CalBurnedSat"].ToString());
                sun = int.Parse(dtLogin_Table.Rows[0]["CalBurnedSun"].ToString());
                goal = int.Parse(dtLogin_Table.Rows[0]["CalBurnedGoal"].ToString());

                objDBAccess.closeConn();

                txtBurnedMon.AppendText(mon.ToString());
                txtBurnedTues.AppendText(tues.ToString());
                txtBurnedWed.AppendText(wed.ToString());
                txtBurnedThu.AppendText(thur.ToString());
                txtBurnedFri.AppendText(fri.ToString());
                txtBurnedSat.AppendText(sat.ToString());
                txtBurnedSun.AppendText(sun.ToString());
                txtWeeklyGoal.AppendText(goal.ToString());

                int total = mon + tues + wed + thur + fri + sat + sun;
                double percent = (total / goal) * 100;

                txtTotalCal.AppendText(total.ToString());
                txtPercent.AppendText(percent.ToString());
            }
            else
            {
                MessageBox.Show("Error loading Workout Log data.");
            }
        }
    }
}
