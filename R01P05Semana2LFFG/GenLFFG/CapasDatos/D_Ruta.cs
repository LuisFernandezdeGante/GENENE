using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapasDatos
{
    public class D_Ruta
    {
        public List<E_Ruta> ListarRutas(bool? ATiempo  = null)
        {
            List<E_Ruta> lista= new List<E_Ruta>();

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("ListarRutas", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (ATiempo.HasValue)
                    cmd.Parameters.AddWithValue("@ATiempo", ATiempo.Value);
                else
                    cmd.Parameters.AddWithValue("@ATiempo", DBNull.Value);


                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new E_Ruta
                    {
                        IdRutas= Convert.ToInt32(dr["IdRutas"]),
                        IdChofer = Convert.ToInt32(dr["IdChofer"]),
                        IdCamion= Convert.ToInt32(dr["IdCamion"]),
                        Origen = dr["Origen"].ToString(),
                        Destino = dr["Destino"].ToString(),
                        FechaSalida = Convert.ToDateTime(dr["Salida"]),
                        FechaLlegada = Convert.ToDateTime(dr["Llegada"]),
                        ATiempo = Convert.ToBoolean(dr["ATiempo"]),
                        Distancia = Convert.ToDouble(dr["Distancia"]),
                        //FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"])

                     
                        

                    });
                }
            }
            return lista;
        }

        public bool InsertarRuta(E_Ruta ruta)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Insert_Ruta", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdChofer", ruta.IdChofer);
                cmd.Parameters.AddWithValue("@IdCamion", ruta.IdCamion);
                cmd.Parameters.AddWithValue("@Origen", ruta.Origen);
                cmd.Parameters.AddWithValue("@Destino", ruta.Destino);
                cmd.Parameters.AddWithValue("@FechaSalida", ruta.FechaSalida);
                cmd.Parameters.AddWithValue("@FechaLlegada", ruta.FechaLlegada);
                cmd.Parameters.AddWithValue("@ATiempo", ruta.ATiempo);
                cmd.Parameters.AddWithValue("@Distancia", ruta.Distancia);


                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool ActualizarRuta(E_Ruta ruta)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Update_Ruta", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdRutas", ruta.IdRutas);
                cmd.Parameters.AddWithValue("@IdChofer", ruta.IdChofer);
                cmd.Parameters.AddWithValue("@IdCamion", ruta.IdCamion);
                cmd.Parameters.AddWithValue("@Origen", ruta.Origen);
                cmd.Parameters.AddWithValue("@Destino", ruta.Destino);
                cmd.Parameters.AddWithValue("@FechaSalida", ruta.FechaSalida);
                cmd.Parameters.AddWithValue("@FechaLlegada", ruta.FechaLlegada);
                cmd.Parameters.AddWithValue("@ATiempo", ruta.ATiempo);
                cmd.Parameters.AddWithValue("@Distancia", ruta.Distancia);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool EliminarRuta(int idRuta) //revisar
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Delete_Ruta", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdRuta", idRuta);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
