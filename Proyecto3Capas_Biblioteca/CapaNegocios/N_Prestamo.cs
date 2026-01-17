using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocios
{
    public class N_Prestamo
    {
        private D_Prestamo objDatos = new D_Prestamo();

        public List<E_Prestamo> ListarPrestamo(bool? regresado = null)
        {
            try
            {
                return objDatos.ListarPrestamo(regresado);
            }

            catch (Exception ex)
            {
                throw new Exception("ERROR:" + ex.Message);
            }
        }

        public string InsertarPrestamo(E_Prestamo prestamo)
        {
            try
            {

                //habilitar este bloque con calma
                

                //INSERTAR

                if (objDatos.InsertarPrestamo(prestamo))
                    return "OK";
                else
                    return "No se pudo insertar el prestamo";

            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        public string ActualizarPrestamo(E_Prestamo prestamo)
        {
           
            try
            {
                //Habilitar con calma


                //ACTUALIZAR

                if (objDatos.ActualizarPrestamo(prestamo))
                    return "OK";
                else
                    return "No se pudo actualizar el prestamo";
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        public string EliminarPrestamo(int prestamoid)
        {
            try
            {
                if (objDatos.EliminarPrestamo(prestamoid))
                    return "OK";
                else
                    return "No se pudo eliminar el prestamo";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }


    }
}
