﻿using System;
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
            float goal = float.Parse(txtWeeklyGoal.Text);
            if (goal == 1 || goal == 0)
            {
                MessageBox.Show("Please enter a valid Weekly Goal value.");
            }
            else
            {
                float mon = float.Parse(txtBurnedMon.Text);
                float tues = float.Parse(txtBurnedTues.Text);
                float wed = float.Parse(txtBurnedWed.Text);
                float thur = float.Parse(txtBurnedThu.Text);
                float fri = float.Parse(txtBurnedFri.Text);
                float sat = float.Parse(txtBurnedSat.Text);
                float sun = float.Parse(txtBurnedSun.Text);
                float total = mon + tues + wed + thur + fri + sat + sun;

                string query =
                    "Update Login_Table SET CalBurnedMon = '" + @mon + "', CalBurnedTue = '" + @tues + "', CalBurnedWed = '" + @wed + "', CalBurnedThur = '" + @thur +
                    "', CalBurnedFri = '" + @fri + "', CalBurnedSat = '" + @sat + "', CalBurnedSun = '" + @sun + "', CalBurnedGoal = '" + @goal + "', CalBurnedTotal = '"
                    + @total + "' where ID = '" + LoginForm.id + "'";

                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@mon", @mon);
                updateCommand.Parameters.AddWithValue("@tues", @tues);
                updateCommand.Parameters.AddWithValue("@wed", @wed);
                updateCommand.Parameters.AddWithValue("@thur", @thur);
                updateCommand.Parameters.AddWithValue("@fri", @fri);
                updateCommand.Parameters.AddWithValue("@sat", @sat);
                updateCommand.Parameters.AddWithValue("@sun", @sun);
                updateCommand.Parameters.AddWithValue("@goal", @goal);
                updateCommand.Parameters.AddWithValue("@total", @total);

                int row = objDBAccess.executeQuery(updateCommand);
                if (row == 1)
                {
                    txtTotalCal.Clear();
                    txtTotalCal.AppendText(total.ToString());
                    // Keeps giving me either 0 or 100 for some reason. Please check. -Bailey.
                    float percent = (total / goal) * 100;
                    txtPercent.Clear();
                    txtPercent.AppendText(percent.ToString());
                }
                else
                {
                    MessageBox.Show("Failed to update. Please try again.");
                }
            }
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            float mon, tues, wed, thur, fri, sat, sun, goal, total;

            string query =
                    "SELECT CalBurnedMon,CalBurnedTue,CalBurnedWed,CalBurnedThur,CalBurnedFri,CalBurnedSat,CalBurnedSun,CalBurnedGoal,CalBurnedTotal FROM Login_Table where ID = '" +
                    LoginForm.id + "'";

            objDBAccess.readDatathroughAdapter(query, dtLogin_Table);

            if (dtLogin_Table.Rows.Count == 1)
            {
                mon = float.Parse(dtLogin_Table.Rows[0]["CalBurnedMon"].ToString());
                tues = float.Parse(dtLogin_Table.Rows[0]["CalBurnedTue"].ToString());
                wed = float.Parse(dtLogin_Table.Rows[0]["CalBurnedWed"].ToString());
                thur = float.Parse(dtLogin_Table.Rows[0]["CalBurnedThur"].ToString());
                fri = float.Parse(dtLogin_Table.Rows[0]["CalBurnedFri"].ToString());
                sat = float.Parse(dtLogin_Table.Rows[0]["CalBurnedSat"].ToString());
                sun = float.Parse(dtLogin_Table.Rows[0]["CalBurnedSun"].ToString());
                goal = float.Parse(dtLogin_Table.Rows[0]["CalBurnedGoal"].ToString());
                total = float.Parse(dtLogin_Table.Rows[0]["CalBurnedTotal"].ToString());

                objDBAccess.closeConn();

                txtBurnedMon.AppendText(mon.ToString());
                txtBurnedTues.AppendText(tues.ToString());
                txtBurnedWed.AppendText(wed.ToString());
                txtBurnedThu.AppendText(thur.ToString());
                txtBurnedFri.AppendText(fri.ToString());
                txtBurnedSat.AppendText(sat.ToString());
                txtBurnedSun.AppendText(sun.ToString());
                txtWeeklyGoal.AppendText(goal.ToString());

                float percent = (total / goal) * 100;

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
