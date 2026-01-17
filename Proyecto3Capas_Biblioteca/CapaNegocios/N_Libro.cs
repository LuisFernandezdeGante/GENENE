using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocios
{
    public class N_Libro
    {
        private D_Libro objDatos = new D_Libro();

        public List<E_Libro> ListarLibro(bool? disponible = null)
        {
            try
            {
                return objDatos.ListarLibro(disponible);
            }

            catch (Exception ex)
            {
                throw new Exception("ERROR:" + ex.Message);
            }
        }

        

        public string InsertarLibro(E_Libro libro)
        {
            try
            {
                if (string.IsNullOrEmpty(libro.Titulo))
                    return "El titulo es obligatorio";


                //INSERTAR

                if (objDatos.InsertarLibro(libro))
                    return "OK";
                else
                    return "No se pudo insertar el libro";

            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        public string ActualizarLibro(E_Libro libro)
        {
            try
            {
                if (string.IsNullOrEmpty(libro.Titulo))
                    return "El titulo es obligatorio";

                //ACTUALIZAR

                if (objDatos.ActualizarLibro(libro))
                    return "OK";
                else
                    return "No se pudo actualizar el libro";
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        public string EliminarLibro(int libroid)
        {
            try
            {
                if (objDatos.EliminarLibro(libroid))
                    return "OK";
                else
                    return "No se pudo eliminar el libro";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

    }
}
