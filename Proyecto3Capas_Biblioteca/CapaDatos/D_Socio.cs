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
    public class D_Socio
    {
        public List<E_Socio> ListarSocio(bool? debe = null)
        {
            List<E_Socio> lista = new List<E_Socio>();

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Listar_Socios", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                if (debe.HasValue)
                    cmd.Parameters.AddWithValue("@Debe", debe.Value);
                else
                    cmd.Parameters.AddWithValue("@Debe", DBNull.Value);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new E_Socio
                    {
                        SociosID = Convert.ToInt32(dr["SociosID"]),
                        Nombre = dr["Nombre"].ToString(),
                        Email = dr["Email"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Direccion = dr["Direccion"].ToString(),
                        Debe = Convert.ToBoolean(dr["Debe"]),
                        
                    });


                }

            }
            return lista;
        }

        //Insertar Socio

        public bool InsertarSocio(E_Socio socio)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Insert_Socios", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                
                cmd.Parameters.AddWithValue("@SociosID", socio.SociosID);
                cmd.Parameters.AddWithValue("@Nombre", socio.Nombre);
                cmd.Parameters.AddWithValue("@Email", socio.Email);
                cmd.Parameters.AddWithValue("@Telefono", socio.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", socio.Direccion);
                cmd.Parameters.AddWithValue("@Debe", socio.Debe);

                return cmd.ExecuteNonQuery() > 0;

            }
        }

        //Actualizar socio

        public bool ActualizarSocio(E_Socio socio)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Update_Socios", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SociosID", socio.SociosID);
                cmd.Parameters.AddWithValue("@Nombre", socio.Nombre);
                cmd.Parameters.AddWithValue("@Email", socio.Email);
                cmd.Parameters.AddWithValue("@Telefono", socio.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", socio.Direccion);
                cmd.Parameters.AddWithValue("@Debe", socio.Debe);

                return cmd.ExecuteNonQuery() > 0;

            }
        }

        //  Eliminar socio

        public bool EliminarSocio(int socioid)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Delete_Socios", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SociosID", socioid);

                return cmd.ExecuteNonQuery() > 0;
            }
        }


    }
}
