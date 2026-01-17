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
    public class D_Prestamo
    {
        public List<E_Prestamo> ListarPrestamo(bool? regresado = null)
        {
            List<E_Prestamo> lista = new List<E_Prestamo>();

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Listar_Prestamos", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                if (regresado.HasValue)
                    cmd.Parameters.AddWithValue("@Regresado", regresado.Value);
                else
                    cmd.Parameters.AddWithValue("@Regresado", DBNull.Value);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new E_Prestamo
                    {
                        PrestamosID = Convert.ToInt32(dr["PrestamosID"]),
                        LibrosID = Convert.ToInt32(dr["LibrosID"]),
                        SociosID = Convert.ToInt32(dr["SociosID"]),
                        Titulo = dr["Titulo"].ToString(),
                        Fecha = Convert.ToDateTime(dr["Fecha"]),
                        Regresado = Convert.ToBoolean(dr["Regresado"]),
                        

                        });


                }

            }
            return lista;
        }

        //Insertar Prestamo

        public bool InsertarPrestamo(E_Prestamo prestamo)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Insert_Prestamos", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@LibrosID", prestamo.LibrosID);
                cmd.Parameters.AddWithValue("@SociosID", prestamo.SociosID);
                cmd.Parameters.AddWithValue("@Titulo", prestamo.Titulo);
                cmd.Parameters.AddWithValue("@Fecha", prestamo.Fecha);
                cmd.Parameters.AddWithValue("@Regresado", prestamo.Regresado);
                

                


                return cmd.ExecuteNonQuery() > 0;


            }
        }

        //Actualizar prestamo

        public bool ActualizarPrestamo(E_Prestamo prestamo)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Update_Prestamo", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                //quiza se requiere agregar prestamosID
                cmd.Parameters.AddWithValue("@LibrosID", prestamo.LibrosID);
                cmd.Parameters.AddWithValue("@SociosID", prestamo.SociosID);
                cmd.Parameters.AddWithValue("@Titulo", prestamo.Titulo);
                cmd.Parameters.AddWithValue("@Fecha", prestamo.Fecha);
                cmd.Parameters.AddWithValue("@Regresado", prestamo.Regresado);

                return cmd.ExecuteNonQuery() > 0;

            }
        }

        //  Eliminar prestamos

        public bool EliminarPrestamo(int prestamoid)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Delete_Prestamos", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PrestamosID", prestamoid);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
