using CapaEntidades;
using CapasDatos;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class N_Camion
    {
        private D_Camion objDatos = new D_Camion();

        public List<E_Camion> ListarCamiones(bool? disponibilidad = null)
        {
            try
            {
                return objDatos.ListarCamiones(disponibilidad);
            }

            catch (Exception ex)
            {
                throw new Exception("ERROR:" + ex.Message);
            }
        }

        public string InsertarCamion (E_Camion camion)
        {
            try
            {
                if (string.IsNullOrEmpty(camion.Matricula))
                    return "La matricula es obligatoria";

                if (string.IsNullOrEmpty(camion.TipoCamion))
                    return "El tipo de camion es obligatorio";

                if (camion.Modelo<1900||camion.Modelo > DateTime.Now.Year +1)
                    return "El modelo debe estar entre 1900 y "+ (DateTime.Now.Year+1);

                if (string.IsNullOrEmpty(camion.Marca))
                    return "La marca es obligatoria";

                if (camion.Capacidad <= 0)
                    return "La capacidad es mayor a 0";

                if (camion.Kilometraje <= 0)
                    return "El kilometraje no puede ser negativo";

                //VERIFICAR SI EXISTE LA MATRICULA

                if (objDatos.ExisteMatricula(camion.Matricula))
                    return "Ya existe un camion con esa matricula";

                //INSERTAR

                if(objDatos.InsertarCamion(camion))
                        return "OK";
                else
                    return "No se pudo insertar el camion";

            }
            catch (Exception ex)
            {
                return "ERROR: "+ ex.Message;
            }
        }

        public string ActualizarCamion (E_Camion camion)
        {
            try
            {
                if (string.IsNullOrEmpty(camion.Matricula))
                    return "La matricula es obligatoria";

              
                if (camion.Modelo < 1900 || camion.Modelo > DateTime.Now.Year + 1)
                    return "El modelo no es valido, debe estar entre 1900 y " + (DateTime.Now.Year + 1);


                if (camion.Capacidad <= 0)
                    return "La capacidad es mayor a 0";


                //ACTUALIZAR

                if (objDatos.ActualizarCamion(camion))
                    return "OK";
                else
                    return "No se pudo actualizar el camion";
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        public string EliminarCamion(int idCamion)
        {
            try
            {
                if (objDatos.EliminarCamion(idCamion))
                    return "OK";
                else
                    return "No se pudo eliminar el camion";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        public E_Camion ObtenerCamionPorID (int idCamion)
        {
            try
            {
                return objDatos.ObtenerCamionPorID(idCamion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}
