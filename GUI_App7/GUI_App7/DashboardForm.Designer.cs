namespace GUI_App7
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCalBurned = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SummaryPage = new System.Windows.Forms.Button();
            this.txtCupsWater = new System.Windows.Forms.TextBox();
            this.txtHoursSlept = new System.Windows.Forms.TextBox();
            this.txtCalIntake = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtCalBurned);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.SummaryPage);
            this.panel4.Controls.Add(this.txtCupsWater);
            this.panel4.Controls.Add(this.txtHoursSlept);
            this.panel4.Controls.Add(this.txtCalIntake);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(12, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(719, 426);
            this.panel4.TabIndex = 13;
            // 
            // txtCalBurned
            // 
            this.txtCalBurned.Enabled = false;
            this.txtCalBurned.Location = new System.Drawing.Point(186, 225);
            this.txtCalBurned.Multiline = true;
            this.txtCalBurned.Name = "txtCalBurned";
            this.txtCalBurned.Size = new System.Drawing.Size(107, 20);
            this.txtCalBurned.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(28, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Calories burned:";
            // 
            // SummaryPage
            // 
            this.SummaryPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.SummaryPage.FlatAppearance.BorderSize = 0;
            this.SummaryPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SummaryPage.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.SummaryPage.ForeColor = System.Drawing.Color.White;
            this.SummaryPage.Location = new System.Drawing.Point(270, 348);
            this.SummaryPage.Name = "SummaryPage";
            this.SummaryPage.Size = new System.Drawing.Size(173, 38);
            this.SummaryPage.TabIndex = 2;
            this.SummaryPage.Text = "Update Summary";
            this.SummaryPage.UseVisualStyleBackColor = false;
            this.SummaryPage.Click += new System.EventHandler(this.SummaryPage_Click);
            // 
            // txtCupsWater
            // 
            this.txtCupsWater.Enabled = false;
            this.txtCupsWater.Location = new System.Drawing.Point(186, 165);
            this.txtCupsWater.Multiline = true;
            this.txtCupsWater.Name = "txtCupsWater";
            this.txtCupsWater.Size = new System.Drawing.Size(107, 20);
            this.txtCupsWater.TabIndex = 1;
            // 
            // txtHoursSlept
            // 
            this.txtHoursSlept.Enabled = false;
            this.txtHoursSlept.Location = new System.Drawing.Point(186, 87);
            this.txtHoursSlept.Multiline = true;
            this.txtHoursSlept.Name = "txtHoursSlept";
            this.txtHoursSlept.Size = new System.Drawing.Size(107, 20);
            this.txtHoursSlept.TabIndex = 1;
            // 
            // txtCalIntake
            // 
            this.txtCalIntake.Enabled = false;
            this.txtCalIntake.Location = new System.Drawing.Point(186, 33);
            this.txtCalIntake.Multiline = true;
            this.txtCalIntake.Name = "txtCalIntake";
            this.txtCalIntake.Size = new System.Drawing.Size(107, 20);
            this.txtCalIntake.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(28, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cups of";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(28, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Hours slept:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(28, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "water drank:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label11.Location = new System.Drawing.Point(28, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Calorie intake:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(28, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Recent measured";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(28, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "weight:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(186, 280);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 8;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(743, 466);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "Form4";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCupsWater;
        private System.Windows.Forms.TextBox txtHoursSlept;
        private System.Windows.Forms.TextBox txtCalIntake;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SummaryPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCalBurned;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}