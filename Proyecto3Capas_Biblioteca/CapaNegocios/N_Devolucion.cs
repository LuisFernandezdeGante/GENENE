using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class N_Devolucion
    {
        private D_Devolucion objDatos = new D_Devolucion();

        public List<E_Devolucion> ListarDevolucion(bool? entrego = null)
        {
            try
            {
                return objDatos.ListarDevolucion(entrego);
            }

            catch (Exception ex)
            {
                throw new Exception("ERROR:" + ex.Message);
            }
        }

        public string InsertarDevolucion(E_Devolucion devolucion)
        {
            try
            {
                //INSERTAR

                if (objDatos.InsertarDevolucion(devolucion))
                    return "OK";
                else
                    return "No se pudo insertar la devolucion";

            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        public string ActualizarDevolucion(E_Devolucion devolucion)
        {
            try
            {
                

                //ACTUALIZAR

                if (objDatos.ActualizarDevolucion(devolucion))
                    return "OK";
                else
                    return "No se pudo actualizar la devolucion";
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        public string EliminarDevolucion(int devolucionid)
        {
            try
            {
                if (objDatos.EliminarDevolucion(devolucionid))
                    return "OK";
                else
                    return "No se pudo eliminar la devolucion";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}
