using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class N_Socio
    {

        private D_Socio objDatos = new D_Socio();

        public List<E_Socio> ListarSocio(bool? debe = null)
        {
            try
            {
                return objDatos.ListarSocio(debe);
            }

            catch (Exception ex)
            {
                throw new Exception("ERROR:" + ex.Message);
            }
        }


        public string InsertarSocio(E_Socio socio)
        {
            try
            {
                if (string.IsNullOrEmpty(socio.Nombre))
                    return "El nombre es obligatorio";

                

                //INSERTAR

                if (objDatos.InsertarSocio(socio))
                    return "OK";
                else
                    return "No se pudo insertar el socio";

            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        public string ActualizarSocio(E_Socio socio)
        {
            try
            {
                if (string.IsNullOrEmpty(socio.Nombre))
                    return "El nombre es obligatorio";


                //ACTUALIZAR

                if (objDatos.ActualizarSocio(socio))
                    return "OK";
                else
                    return "No se pudo actualizar el socio";
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        public string EliminarSocio(int socioid)
        {
            try
            {
                if (objDatos.EliminarSocio(socioid))
                    return "OK";
                else
                    return "No se pudo eliminar el socio";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}
