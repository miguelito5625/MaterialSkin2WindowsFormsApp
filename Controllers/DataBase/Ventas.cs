using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinFormsApp1.Controllers.DataBase
{
    internal class Ventas
    {

        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Producto { get; set; }
        public string FechaCreacion { get; set; }


        public Ventas()
        {
        }

        public string Guardarventa(string nombres, string apellidos, int edad)
        {
            string mensaje = "";
            try
            {
                using (var conexion = new ConexionBD().AbrirConexion())
                {
                    var query = "INSERT INTO Ventas (Nombres, Apellidos, Edad) VALUES (@Nombres, @Apellidos, @Edad)";
                    using (var comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombres", nombres);
                        comando.Parameters.AddWithValue("@Apellidos", apellidos);
                        comando.Parameters.AddWithValue("@Edad", edad);

                        comando.ExecuteNonQuery();
                    }
                }
                mensaje = $"venta guardado: ID: Nombres: {nombres}, Apellidos: {apellidos}, Edad: {edad}";
            }
            catch (SqlException ex)
            {
                mensaje = $"Error al guardar el venta: {ex.Message}";
            }
            return mensaje;
        }


        public List<Ventas> ListarVentas()
        {
            var listaVentas = new List<Ventas>();
            try
            {
                using (var conexion = new ConexionBD().AbrirConexion())
                {
                    var query = "SELECT * FROM Ventas";
                    using (var comando = new SqlCommand(query, conexion))
                    {
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var venta = new Ventas()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Cliente = Convert.ToString(reader["Cliente"]),
                                    Producto = Convert.ToString(reader["Producto"]),
                                    FechaCreacion = Convert.ToString(reader["Fecha_creacion"]),
                                };
                                listaVentas.Add(venta);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"No se pudo obtener los Ventas: {ex.Message}");
            }
            return listaVentas;
        }





    }

}
