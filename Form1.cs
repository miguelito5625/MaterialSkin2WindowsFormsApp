using MaterialSkin.Controls;
using MaterialSkin2WindowsFormsApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controllers.DataBase;

namespace MaterialSkin2WindowsFormsApp
{
    public partial class Form1 : MaterialForm
    {
        private Timer timer = new Timer();
        private int progressValue = 0;

        public Form1()
        {
            InitializeComponent();
            loadFormVentas();
            materialProgressBar1.Minimum = 0;
            materialProgressBar1.Maximum = 100;

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void loadFormVentas()
        {
            FormVentas formVentas = new FormVentas();
            formVentas.TopLevel = false;
            formVentas.Show();
            tabPage1.Controls.Add(formVentas);

            FormRecibido formRecibido = new FormRecibido();
            formRecibido.TopLevel = false;
            formRecibido.Show();
            tabPage3.Controls.Add(formRecibido);

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
