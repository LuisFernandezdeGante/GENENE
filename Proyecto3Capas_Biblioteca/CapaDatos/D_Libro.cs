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
    public class D_Libro
    {
        public List<E_Libro> ListarLibro(bool? disponible = null)
        {
            List<E_Libro> lista = new List<E_Libro>();

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Listar_Libros", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                if (disponible.HasValue)
                    cmd.Parameters.AddWithValue("@Disponibles", disponible.Value);
                else
                    cmd.Parameters.AddWithValue("@Disponibiles", DBNull.Value);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new E_Libro

                    {
                        LibrosID = Convert.ToInt32(dr["LibrosID"]),
                        Titulo = dr["Titulo"].ToString(),
                        Autor = dr["Autor"].ToString(),
                        Disponibles = Convert.ToBoolean(dr["Disponibles"]),
                        Genero = dr["Genero"].ToString(),
                        
                        //FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]),


                    });


                }

            }
            return lista;
        }

        //Insertar Libro

        public bool InsertarLibro(E_Libro libro)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Insert_Libros", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                
                cmd.Parameters.AddWithValue("@Titulo", libro.Titulo);
                cmd.Parameters.AddWithValue("@Autor", libro.Autor);
                cmd.Parameters.AddWithValue("@Disponibles", libro.Disponibles);
                cmd.Parameters.AddWithValue("@Genero", libro.Genero);
            
                return cmd.ExecuteNonQuery() > 0;


            }
        }

        //Actualizar libro

        public bool ActualizarLibro(E_Libro libro) //recuerda escribir en singular ActualizarLibro lo mismo para el crud
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Update_Libros", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@LibrosID", libro.LibrosID);
                cmd.Parameters.AddWithValue("@Titulo", libro.Titulo);
                cmd.Parameters.AddWithValue("@Autor", libro.Autor);
                cmd.Parameters.AddWithValue("@Disponibles", libro.Disponibles);
                cmd.Parameters.AddWithValue("@Genero", libro.Genero);

                return cmd.ExecuteNonQuery() > 0;

            }
        }

        //  Eliminar camion 

        public bool EliminarLibro(int libroid)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("Delete_Libros", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@LibrosID", libroid);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
