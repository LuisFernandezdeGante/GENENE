using CapaEntidades;
using CapasDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class N_Chofer
    {
        private D_Chofer objDatos = new D_Chofer();

        public List<E_Chofer> ListarChoferes(bool? disponibilidad = null)
        {
            try
            {
                return objDatos.ListarChoferes(disponibilidad);
            }

            catch (Exception ex)
            {
                throw new Exception("Error en capa de negocios:" + ex.Message);
            }
        }

        public string InsertarChofer (E_Chofer chofer)
        {
            try
            {
                //Validaciones
                if (string.IsNullOrEmpty(chofer.Nombre))
                    return "El nombre es obligatorio";
                if (string.IsNullOrEmpty(chofer.ApPaterno))
                    return "El apellido paterno es obligatorio";
                if (string.IsNullOrEmpty(chofer.ApMaterno))
                    return "El apellido materno es obligatorio";
                if (string.IsNullOrEmpty(chofer.Telefono))
                    return "El telefono es obligatorio";
                if (string.IsNullOrEmpty(chofer.Telefono))
                    return "El telefono es obligatorio";
                if (string.IsNullOrEmpty(chofer.Licencia))
                    return "El licencia es obligatorio";


                //Validar edad minima 18 años
                int edad = DateTime.Now.Year - chofer.FechaNacimiento.Year;
                if (chofer.FechaNacimiento > DateTime.Now.AddYears(-edad)) edad--;
                if (edad < 18)
                    return "El chofer debe ser mayor de edad";

                // Verificar si existelicencia 
                if (objDatos.ExisteLicencia(chofer.Licencia))
                    return "OK";

                if (objDatos.InsertarChofer(chofer))
                    return "OK";
                else
                    return "No se pudo insertar chofer";


            }

            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public string ActualizarChofer(E_Chofer chofer)
        {
            try
            {
                if (string.IsNullOrEmpty(chofer.Nombre))
                    return "El nombre es obligatorio";

                if (chofer.Telefono.Length != 10)
                    return "El telefono debe tener 10 digitos";

                if (objDatos.ActualizarChofer(chofer))
                    return "OK";
                else
                    return "No se pudo actualizar el chofer";

            }

            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public string EliminarChofer(int idChofer)
        {
            try
            {
                if (objDatos.EliminarChofer(idChofer))
                    return "OK";
                else
                    return "No se pudo eliminar el chofer";

            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}
