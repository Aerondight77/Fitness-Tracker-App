using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_App7
{
    public partial class WorkoutCalcForm : Form
    {
        public WorkoutCalcForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtPushUps.Text.Equals(""))
            {
                MessageBox.Show("Please enter a value in the push-ups field.");
            }
            else if (txtSitUps.Text.Equals(""))
            {
                MessageBox.Show("Please enter a value in the sit-ups field.");
            }
            else if (txtRunning.Text.Equals(""))
            {
                MessageBox.Show("Please enter a value in the jogging/running field.");
            }
            else
            {
                int pushUps = int.Parse(txtPushUps.Text);
                int sitUps = int.Parse(txtSitUps.Text);
                int running = int.Parse(txtRunning.Text);
                int calPushUps = pushUps * 7;
                int calSitUps = sitUps * 3;
                double calRunning = running * 11.4;

                double total = calPushUps + calSitUps + calRunning;
                txtPushUps.Clear();
                txtPushUps.AppendText("0");
                txtSitUps.Clear();
                txtSitUps.AppendText("0");
                txtRunning.Clear();
                txtRunning.AppendText("0");
                txtTotalWorkout.Clear();
                txtTotalWorkout.AppendText(total.ToString());
            }
        }

        private void WorkoutCalcForm_Load(object sender, EventArgs e)
        {
            txtPushUps.Clear();
            txtPushUps.AppendText("0");
            txtSitUps.Clear();
            txtSitUps.AppendText("0");
            txtRunning.Clear();
            txtRunning.AppendText("0");
        }
    }
}
