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
    internal class Recibido
    {

        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Producto { get; set; }
        public string Confirmado { get; set; }
        public string FechaCreacion { get; set; }


        public Recibido()
        {
        }

        public string Guardarrecibido(string nombres, string apellidos, int edad)
        {
            string mensaje = "";
            try
            {
                using (var conexion = new ConexionBD().AbrirConexion())
                {
                    var query = "INSERT INTO Recibido (Nombres, Apellidos, Edad) VALUES (@Nombres, @Apellidos, @Edad)";
                    using (var comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombres", nombres);
                        comando.Parameters.AddWithValue("@Apellidos", apellidos);
                        comando.Parameters.AddWithValue("@Edad", edad);

                        comando.ExecuteNonQuery();
                    }
                }
                mensaje = $"recibido guardado: ID: Nombres: {nombres}, Apellidos: {apellidos}, Edad: {edad}";
            }
            catch (SqlException ex)
            {
                mensaje = $"Error al guardar el recibido: {ex.Message}";
            }
            return mensaje;
        }


        public List<Recibido> ListarRecibido()
        {
            var listaRecibido = new List<Recibido>();
            try
            {
                using (var conexion = new ConexionBD().AbrirConexion())
                {
                    var query = "SELECT * FROM Recibido";
                    using (var comando = new SqlCommand(query, conexion))
                    {
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var recibido = new Recibido()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Cliente = Convert.ToString(reader["Cliente"]),
                                    Producto = Convert.ToString(reader["Producto"]),
                                    Confirmado = Convert.ToString(reader["Confirmado"]),
                                    FechaCreacion = Convert.ToString(reader["Fecha_creacion"]),
                                };
                                listaRecibido.Add(recibido);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"No se pudo obtener los Recibido: {ex.Message}");
            }
            return listaRecibido;
        }





    }

}
