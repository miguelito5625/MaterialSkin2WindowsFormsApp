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
using WinFormsApp1.Controllers.DataBase;

namespace MaterialSkin2WindowsFormsApp.Forms
{
    public partial class FormVentas : MaterialForm
    {
        public FormVentas()
        {
            InitializeComponent();
            CargarDatosVentas();
        }

        private void CargarDatosVentas()
        {
            try
            {
                var listaVentas = new Ventas().ListarVentas();
                if (listaVentas != null && listaVentas.Count > 0)
                {
                    dataGridView1.DataSource = listaVentas;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la lista de ventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
