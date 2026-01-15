using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapasDatos
{
    public class Conexion
    {
        private static string cadenaConexion =
            "Server=localhost;Database=GeNe;Trusted_Connection=True;";

        //Método para obtener la conexión
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR AL CONECTAR CON BASE DE DATOS:" + ex.Message);
            }
        }

        //Método para probar la conexión

        public static bool ProbarConexion()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    return conn.State == System.Data.ConnectionState.Open;
                }
            }

            catch
            {
                return false;
            }
        }

    }
}
