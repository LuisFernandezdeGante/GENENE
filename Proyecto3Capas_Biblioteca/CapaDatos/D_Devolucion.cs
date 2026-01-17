using CapaEntidades;
using CapasDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Devolucion
    {
        public List<E_Devolucion> ListarDevolucion(bool? entrego = null)
        {
            List<E_Devolucion> lista = new List<E_Devolucion>();

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Listar_Devoluciones", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                if (entrego.HasValue)
                    cmd.Parameters.AddWithValue("@Entrego", entrego.Value);
                else
                    cmd.Parameters.AddWithValue("@Entrego", DBNull.Value);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new E_Devolucion
                    {
                        DevolucionesID = Convert.ToInt32(dr["DevolucionesID"]),
                        PrestamosID = Convert.ToInt32(dr["PrestamosID"]),
                        LibrosID = Convert.ToInt32(dr["LibrosID"]),
                        SociosID = Convert.ToInt32(dr["SociosID"]),
                        Titulo = dr["Titulo"].ToString(),
                        Fecha = Convert.ToDateTime(dr["Fecha"]),
                        Entrego = Convert.ToBoolean(dr["Entrego"]),


                        });


                }

            }
            return lista;
        }

        //Insertar Devoluciones

        public bool InsertarDevolucion(E_Devolucion devolucion)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Insert_Camion", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PrestamosID", devolucion.PrestamosID);
                cmd.Parameters.AddWithValue("@LibrosID", devolucion.LibrosID);
                cmd.Parameters.AddWithValue("@SociosID", devolucion.SociosID);
                cmd.Parameters.AddWithValue("@Titulo", devolucion.Titulo);
                cmd.Parameters.AddWithValue("@Fecha", devolucion.Fecha);
                cmd.Parameters.AddWithValue("@Entrego", devolucion.Entrego);
                

                return cmd.ExecuteNonQuery() > 0;


            }
        }
        //Actualizar devoluciones

        public bool ActualizarDevolucion(E_Devolucion devolucion)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Update_Devoluciones", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PrestamosID", devolucion.PrestamosID);
                cmd.Parameters.AddWithValue("@LibrosID", devolucion.LibrosID);
                cmd.Parameters.AddWithValue("@SociosID", devolucion.SociosID);
                cmd.Parameters.AddWithValue("@Titulo", devolucion.Titulo);
                cmd.Parameters.AddWithValue("@Fecha", devolucion.Fecha);
                cmd.Parameters.AddWithValue("@Entrego", devolucion.Entrego);

                return cmd.ExecuteNonQuery() > 0;

            }
        }

        //  Eliminar devolucion 

        public bool EliminarDevolucion(int devolucionid)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Delete_Devoluciones", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DevolucionesID", devolucionid);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
