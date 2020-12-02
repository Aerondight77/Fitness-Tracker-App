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
    public partial class WorkoutPlansForm : Form
    {
        bool isMenu1PanelOpen = false;
        bool isMenu1PanelOpen2 = false;
        bool isMenu1PanelOpen3 = false;


        public WorkoutPlansForm()
        {
            InitializeComponent();
        }
        //Main menu bar labels with timers
        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private void labelHeavyWorkouts_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }
        // For LIGHT WORKOUTS
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isMenu1PanelOpen)
            {
                panelMenu1.Height -= 20;
                if (panelMenu1.Height == 0)
                {
                    timer1.Stop();
                    isMenu1PanelOpen = false;
                }
            }
            else if (isMenu1PanelOpen == false)
            {
                panelMenu1.Height += 20;
                if(panelMenu1.Height >= 100)
                {
                    timer1.Stop();
                    isMenu1PanelOpen = true;
                }
            }
        }

        // for MEDIUM WORKOUTS
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isMenu1PanelOpen2)
            {
                panelMenu2.Height -= 20;
                if (panelMenu2.Height == 0)
                {
                    timer2.Stop();
                    isMenu1PanelOpen2 = false;
                }
            }
            else if (isMenu1PanelOpen2 == false)
            {
                panelMenu2.Height += 20;
                if (panelMenu2.Height >= 100)
                {
                    timer2.Stop();
                    isMenu1PanelOpen2 = true;
                }
            }
        }
        // for HEAVY WORKOUTS
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isMenu1PanelOpen3)
            {
                panelMenu3.Height -= 20;
                if (panelMenu3.Height == 0)
                {
                    timer3.Stop();
                    isMenu1PanelOpen3 = false;
                }
            }
            else if (isMenu1PanelOpen3 == false)
            {
                panelMenu3.Height += 20;
                if (panelMenu3.Height >= 100)
                {
                    timer3.Stop();
                    isMenu1PanelOpen3 = true;
                }
            }
        }
        // Light Workout 1
        private void label4_Click(object sender, EventArgs e)
        {
            lightWorkout2.Hide();
            mediumWorkout1.Hide();
            mediumWorkout2.Hide();
            heavyWorkout1.Hide();
            heavyWorkout2.Hide();

            lightWorkout1.Show();
            lightWorkout1.Height = 230;
            lightWorkout1.BringToFront();
        }
        // Light Workout 2
        private void label5_Click(object sender, EventArgs e)
        {
            
            lightWorkout1.Hide();
            mediumWorkout1.Hide();
            mediumWorkout2.Hide();
            heavyWorkout1.Hide();
            heavyWorkout2.Hide();

            lightWorkout2.Show();
            lightWorkout2.Height = 230;
            lightWorkout2.BringToFront();
        }
        //Medium Workout 1
        private void label25_Click(object sender, EventArgs e)
        {
            lightWorkout1.Hide();
            lightWorkout2.Hide();
            mediumWorkout2.Hide();
            heavyWorkout1.Hide();
            heavyWorkout2.Hide();

            mediumWorkout1.Show();
            mediumWorkout1.Height = 230;
            mediumWorkout1.BringToFront();
        }
        //Medium Workout 2
        private void labelMediumWorkout2_Click(object sender, EventArgs e)
        {
            lightWorkout1.Hide();
            lightWorkout2.Hide();
            mediumWorkout1.Hide();
            heavyWorkout1.Hide();
            heavyWorkout2.Hide();

            mediumWorkout2.Show();
            mediumWorkout2.Height = 230;
            mediumWorkout2.BringToFront();
        }
        //Heavy Workout 1
        private void labelHeavyWorkout1_Click(object sender, EventArgs e)
        {
            lightWorkout1.Hide();
            lightWorkout2.Hide();
            mediumWorkout1.Hide();
            mediumWorkout2.Hide();
            heavyWorkout2.Hide();

            heavyWorkout1.Show();
            heavyWorkout1.Height = 230;
            heavyWorkout1.BringToFront();
        }
        //Heavy Workout 2
        private void labelHeavyWorkout2_Click(object sender, EventArgs e)
        {
            lightWorkout1.Hide();
            lightWorkout2.Hide();
            mediumWorkout1.Hide();
            mediumWorkout2.Hide();
            heavyWorkout1.Hide();

            heavyWorkout2.Show();
            heavyWorkout2.Height = 230;
            heavyWorkout2.BringToFront();
        }

    }
}
