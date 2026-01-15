using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace WebServiceBiblioteca
{
    /// <summary>
    /// Descripción breve de ServicioUsuarios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioLibros : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        // Método que retorna la lista


        [WebMethod]
        public List<string> ObtenerLibro()
        {
            List<string> libro = new List<string>();

            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionSQL"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT Titulo FROM Libros ORDER BY Titulo",
                    conn
                    );

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    libro.Add(reader["Titulo"].ToString());
                }
            }
            return libro;

        }

        [WebMethod]

        public bool AgregarLibro(string titulo, string autor, int disponibles, string genero)
        {
            if (string.IsNullOrWhiteSpace(titulo))
                return false;
            if (string.IsNullOrWhiteSpace(autor))
               return false;

            if (string.IsNullOrWhiteSpace(genero))
                return false;

            try
            {
                string connStr = ConfigurationManager
                    .ConnectionStrings["ConexionSQL"]
                    .ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Libros (Titulo, Autor, Disponibles, Genero) VALUES (@Titulo, @Autor,@Disponibles, @Genero)",


                        conn
                        );

                    cmd.Parameters.AddWithValue("@Titulo", titulo);
                    cmd.Parameters.AddWithValue("@Autor", autor);
                    cmd.Parameters.AddWithValue("@Disponibles", disponibles);
                    cmd.Parameters.AddWithValue("@Genero", genero);

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }

            }
            catch
            {
                return false;
            }
        }

        [WebMethod]

        public UsuarioInfo ObtenerLibroPorId(int id)
        {
            UsuarioInfo libro = null;

            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionSQL"]
                .ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT LibrosID, Titulo, Autor, Disponibles, Genero FROM Libros WHERE LibrosID = @Id",
                    conn
                    );

                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    libro = new UsuarioInfo
                    {
                        IdLibro = (int)reader["LibrosID"],
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        Disponibles = (int)reader["Disponibles"],
                        Genero = reader["Genero"].ToString(),
                        
                    };



                }


            }
            return libro;

        }

    }

    [Serializable]

    public class UsuarioInfo
    {
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Disponibles { get; set; }
        public string Genero { get; set; }


    }
}