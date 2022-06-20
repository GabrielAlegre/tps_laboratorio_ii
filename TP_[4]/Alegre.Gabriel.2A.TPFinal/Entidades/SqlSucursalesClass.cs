using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class SqlSucursalesClass
    {
        static string stringConexion;
        static SqlCommand command;
        static SqlConnection connection;

        /// <summary>
        /// Constructor que se encarga de establecer la coneccion a la base de datos
        /// </summary>
        static SqlSucursalesClass()
        {
            stringConexion = @"Data Source=.;Initial Catalog=NetComSucursales;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(stringConexion);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        /// <summary>
        /// Carga una sucursal en la tabla de sucursales de la base de datos
        /// </summary>
        /// <param name="unaSucursal">Sucursal que se desea guardar en la base de datos</param>
        public static void GuardarSucursal(Sucursal unaSucursal)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO Sucursales (provincia, localidad, direccion, telefono) VALUES (@Provincia, @Localidad, @Direccion, @Telefono)";
                command.Parameters.AddWithValue("@Direccion", unaSucursal.Direccion);
                command.Parameters.AddWithValue("@Localidad", unaSucursal.Localidad);
                command.Parameters.AddWithValue("@Provincia", unaSucursal.Provincia);
                command.Parameters.AddWithValue("@Telefono", unaSucursal.Telefono);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Elimina una sucursal de la base de datos
        /// </summary>
        /// <param name="id">id de la sucursal que se eliminara</param>
        /// <returns>Retorna la cantidad de columnas afectadas</returns>
        public static int Eliminar(int id)
        {
            int columnasAfectadas = 0;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM Sucursales WHERE idSucursal = @Id";
                command.Parameters.AddWithValue("@Id", id);
                columnasAfectadas = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return columnasAfectadas;
        }

        /// <summary>
        /// Trae de la base de datos todas las sucursales que correspondan a la string que se recibe por parametro
        /// </summary>
        /// <param name="Provincia">Representa que provincia buscar en la base de datos</param>
        /// <returns>Una lista de sucursales</returns>
        public static List<Sucursal> Leer(string Provincia)
        {
            List<Sucursal> listaDeSucursales = new List<Sucursal>();
            int idSucursal;
            string provincia;
            string localidad;
            string direccion;
            string telefono;

            try
            {
                command.Parameters.Clear();
                connection.Open();
                if(Provincia == "Todas")
                {
                    command.CommandText = "SELECT * FROM Sucursales";
                }
                else
                {
                    command.CommandText = $"SELECT * FROM Sucursales WHERE provincia = @NombreProvincia";
                }
                command.Parameters.AddWithValue("@NombreProvincia", Provincia);

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        idSucursal = Convert.ToInt32(dataReader["idSucursal"]);
                        provincia = dataReader["provincia"].ToString();
                        localidad = dataReader["localidad"].ToString();
                        direccion = dataReader["direccion"].ToString();
                        telefono = dataReader["telefono"].ToString();
                        listaDeSucursales.Add(new Sucursal(idSucursal, provincia, localidad, direccion, telefono));
                    }
                }

                return listaDeSucursales;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
