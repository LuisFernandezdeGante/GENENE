using CapaEntidades;
using CapasDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class N_Ruta
    {
        private D_Ruta objDatos = new D_Ruta();

        public List<E_Ruta> ListarRutas(bool? ATiempo = null)
        {
            try
            {
                return objDatos.ListarRutas(ATiempo);
            }

            catch (Exception ex)
            {
                throw new Exception("Error en capa de negocios:" + ex.Message);
            }
        }
        public string InsertarRuta (E_Ruta ruta)
        {
            try
            {
                //Validaciones 
                if(string.IsNullOrEmpty(ruta.Origen))
                    return "El origen es obligatorio";
                if(string.IsNullOrEmpty(ruta.Destino))
                    return "El destino es obligatorio";
                if(ruta.FechaSalida >= ruta.FechaLlegada)
                    return "La fecha debe ser posterior a la fecha de salida";
                if ( ruta.Distancia <= 0)
                    return "La distancia debe ser mayor a 0";
                if ( ruta.IdChofer <= 0)
                    return "Debe seleccionar un chofer";
                if ( ruta.IdCamion<= 0)
                    return "Debe seleccionar un camion";
                if (objDatos.InsertarRuta(ruta))
                    return "OK";
                else
                    return "No se pudo insertar la ruta";

            }

            catch (Exception ex) 
            {
                return "Error: " + ex.Message;
            }
        }

        public string ActualizarRuta (E_Ruta ruta)
        {
            try
            {
                if (ruta.FechaSalida >= ruta.FechaLlegada)
                    return "La fecha de llegada debe ser posterior a la fecha de salida";
                if (ruta.Distancia <= 0)
                    return "La distancia debe ser mayora 0";
                if (objDatos.ActualizarRuta(ruta))
                    return "OK";
                else
                    return "No se pudo e¿actualizar la ruta";
                
            }
            catch ( Exception ex)
            {
                return "Error : " + ex.Message;
            }
        }

        public string EliminarRuta (int idRuta)
        {
            try
            {
                if (objDatos.EliminarRuta(idRuta))
                    return "OK";
                else
                    return "No se pudo eliminar la ruta";
            }
            catch (Exception ex)
            {
                return "Error: "+ ex.Message;
            }
        }
    }
}
