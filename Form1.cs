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

        public Form1()
        {
            InitializeComponent();
            loadOthersForms();
            

        }

        private void loadOthersForms()
        {
            FormVentas formVentas = new FormVentas();
            formVentas.TopLevel = false;
            formVentas.Dock = DockStyle.Fill;
            formVentas.Show();
            tabPage1.Controls.Add(formVentas);

            Puente formPuente = new Puente();
            formPuente.TopLevel = false;
            formPuente.Dock = DockStyle.Fill;
            formPuente.Show();
            tabPage2.Controls.Add(formPuente);

            FormRecibido formRecibido = new FormRecibido();
            formRecibido.TopLevel = false;
            formRecibido.Dock = DockStyle.Fill;
            formRecibido.Show();
            tabPage3.Controls.Add(formRecibido);


        }


    }
}
