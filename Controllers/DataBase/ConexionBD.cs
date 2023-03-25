using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Controllers.DataBase
{
    public class ConexionBD
    {
        private SqlConnection conexion;

        public ConexionBD()
        {
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\migue\\source\\repos\\MaterialSkin2WindowsFormsApp\\Database1.mdf";
            conexion = new SqlConnection(cadenaConexion);
        }
        public SqlConnection AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
