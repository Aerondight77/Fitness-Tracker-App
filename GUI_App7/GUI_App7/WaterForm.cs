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
    public partial class WaterForm : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtLogin_Table = new DataTable();

        public WaterForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCupSize.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid amount of water.");
            }
            else if (txtNoOfCups.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid number of cups.");
            }
            else
            {
                int amtWater = int.Parse(txtCupSize.Text);
                int numCups = int.Parse(txtNoOfCups.Text);
                int amtToday = amtWater * numCups;

                string query = "Update Login_Table SET AmountPerCup = '" + @amtWater + "', NoOfCups = '" + @numCups + "', WaterToday = '" + @amtToday + "' where ID = '" + LoginForm.id + "'";

                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@amtWater", @amtWater);
                updateCommand.Parameters.AddWithValue("@numCups", @numCups);
                updateCommand.Parameters.AddWithValue("@amyToday", @amtToday);

                int row = objDBAccess.executeQuery(updateCommand);

                if (row == 1)
                {
                    txtWaterDrankToday.Clear();
                    txtWaterDrankToday.AppendText(amtToday.ToString());
                    MessageBox.Show("Water data successfully updated.");
                }
                else
                {
                    MessageBox.Show("Water data failed to update.");
                }
            }
        }

        private void WaterForm_Load(object sender, EventArgs e)
        {
            int amtWater, numCups, amtToday;

            string query = "SELECT AmountPerCup,NoOfCups,WaterToday FROM Login_Table where ID = '" + LoginForm.id + "'";

            objDBAccess.readDatathroughAdapter(query, dtLogin_Table);

            if (dtLogin_Table.Rows.Count == 1)
            {
                amtWater = int.Parse(dtLogin_Table.Rows[0]["AmountPerCup"].ToString());
                numCups = int.Parse(dtLogin_Table.Rows[0]["NoOfCups"].ToString());
                amtToday = int.Parse(dtLogin_Table.Rows[0]["WaterToday"].ToString());

                objDBAccess.closeConn();

                txtCupSize.AppendText(amtWater.ToString());
                txtNoOfCups.AppendText(numCups.ToString());
                txtWaterDrankToday.Clear();
                txtWaterDrankToday.AppendText(amtToday.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int empty = 0;
            string query = "Update Login_Table SET AmountPerCup = '" + @empty + "', NoOfCups = '" + @empty + "', WaterToday = '" + @empty + "' where ID = '" + LoginForm.id + "'";
            SqlCommand updateCommand = new SqlCommand(query);

            updateCommand.Parameters.AddWithValue("@empty", @empty);

            int row = objDBAccess.executeQuery(updateCommand);

            if (row == 1)
            {
                txtCupSize.Clear();
                txtNoOfCups.Clear();
                txtWaterDrankToday.Clear();
                txtWaterDrankToday.AppendText("_");
            }
            else
            {
                // Debug purposes.
                MessageBox.Show("Error in resetting water data.");
            }
        }
    }
}
