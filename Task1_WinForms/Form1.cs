using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_WinForms
{
    public partial class Form1 : Form
    {



        Timer myTimer = new Timer();

        Timer myTimer2 = new Timer();

        Label newLabel = new Label();

        Label newLabel2 = new Label();

        Button GoBack = new Button();
        public Form1()
        {
            InitializeComponent();
            myTimer.Interval = 1000;
            myTimer.Tick += MyTimer_Tick;
            myTimer.Start();

            myTimer2.Interval = 1000;
            myTimer2.Tick += MyTimer2_Tick;
            myTimer2.Start();
        }

        private void MyTimer2_Tick(object sender, EventArgs e)
        {
            newLabel2.Text = "London Local Time\n" + DateTime.Now.AddHours(-4).ToString();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            newLabel.Text = "Baku Local Time\n"+DateTime.Now.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form newForm=new Form();
            newForm.BackgroundImage = Properties.Resources.london;
            newForm.Size = new Size(1920, 1080);
            newLabel2.Size = new Size(400, 100);
            newLabel2.Font = new Font("Palatino LinoType", 24, FontStyle.Bold);
            newLabel2.Location = new Point(0, 25);

            newForm.Controls.Add(newLabel2);
            
            newForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

            Form newForm = new Form();
            newForm.BackgroundImage = Properties.Resources.baku;
            newForm.Size = new Size(1920, 1080);

            newLabel.Size = new Size(300, 100);
            newLabel.Font = new Font("Palatino LinoType", 24, FontStyle.Bold);
            newLabel.Location = new Point(0, 25);

            newForm.Controls.Add(newLabel);
            newForm.Show();
        }
    }
}
