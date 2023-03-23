using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin2WindowsFormsApp
{
    public partial class Form1 : MaterialForm
    {
        private Timer timer = new Timer();
        private int progressValue = 0;

        public Form1()
        {
            InitializeComponent();

            materialProgressBar1.Minimum = 0;
            materialProgressBar1.Maximum = 100;

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressValue >= 100)
            {
                progressValue = 0;
            }

            materialProgressBar1.Value = progressValue;
            progressValue+=5;
        }

        private void ResetProgressBar()
        {
            timer.Stop();
            materialProgressBar1.Value = 0;
            progressValue = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

    }
}
