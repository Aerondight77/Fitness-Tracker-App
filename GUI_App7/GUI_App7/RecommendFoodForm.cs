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
    public partial class RecommendFoodForm : Form
    {
        public RecommendFoodForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FoodPnl.Controls.Clear();
            BerrySMB myProfileForm_Vrb = new BerrySMB() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.FoodPnl.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.FoodPnl.Controls.Clear();
            BananaPecan myProfileForm_Vrb = new BananaPecan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.FoodPnl.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.FoodPnl.Controls.Clear();
            breakfastWrap myProfileForm_Vrb = new breakfastWrap() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.FoodPnl.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.FoodPnl.Controls.Clear();
            AvocadoTomatoToast myProfileForm_Vrb = new AvocadoTomatoToast() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.FoodPnl.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.FoodPnl.Controls.Clear();
            TacoSalad myProfileForm_Vrb = new TacoSalad() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.FoodPnl.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.FoodPnl.Controls.Clear();
            SouthwesternSalad myProfileForm_Vrb = new SouthwesternSalad() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.FoodPnl.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.FoodPnl.Controls.Clear();
            AvocTunaWrap myProfileForm_Vrb = new AvocTunaWrap() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.FoodPnl.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.FoodPnl.Controls.Clear();
            PestoChickenPastacs myProfileForm_Vrb = new PestoChickenPastacs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.FoodPnl.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.FoodPnl.Controls.Clear();
            AlfredoChicken myProfileForm_Vrb = new AlfredoChicken() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.FoodPnl.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.FoodPnl.Controls.Clear();
            TurkeyTacos myProfileForm_Vrb = new TurkeyTacos() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.FoodPnl.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }
    }
}
