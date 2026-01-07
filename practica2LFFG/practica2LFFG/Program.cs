using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//ESTE ES UN COMENTARIO DE UNA PRUEBA DE RAMA DE PROYECTO DE LUIS

namespace practica2LFFG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Busqueda de Prestamos-------------");
            Console.WriteLine("Escribe el ID de la Prestación");
            string prestamo = Console.ReadLine();


            //Cadena de conexion 
            string connectionString = "Server=localhost; Database=BD_BIBLIOTECA; Trusted_Connection=True;";

            //Consulta SQL (BUSCA PRESTAMO)
            string query = "SELECT TOP 5 PrestamosID, LibrosID, SociosID " +
                            "FROM Prestamos " +
                            "WHERE PrestamosID>@prestamo"; //AQUI HUBO UN CAMBIO

            using (SqlConnection connection = new SqlConnection(connectionString)) //PASO 1
            using (SqlCommand command = new SqlCommand(query, connection))          //PASO 2
            {
                command.Parameters.AddWithValue("@prestamo", prestamo.ToUpper());  //PASO 3 

                connection.Open();                                                    //PASO 4
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("\nResultados encontrados");
                    while (reader.Read())
                    {
                        Console.WriteLine($"Prestamo num: {reader["PrestamosID"]}");  //PASO 5
                        Console.WriteLine($"Libro num: {reader["LibrosID"]}");
                        Console.WriteLine($"Socio num: {reader["SociosID"]}");
                        Console.WriteLine("---------------------\n\n");


                    }


                }
                else
                {
                    Console.WriteLine("No se encontro la consulta");                //
                


            }

            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }
    }
}
