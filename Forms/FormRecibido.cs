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
    public partial class FormRecibido : MaterialForm
    {
        public FormRecibido()
        {
            InitializeComponent();
            CargarDatosRecibidos();
        }

        private void CargarDatosRecibidos()
        {
            try
            {
                var listaRecibidos = new Recibido().ListarRecibido();
                if (listaRecibidos != null && listaRecibidos.Count > 0)
                {
                    dataGridView1.DataSource = listaRecibidos;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la lista de recibidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
