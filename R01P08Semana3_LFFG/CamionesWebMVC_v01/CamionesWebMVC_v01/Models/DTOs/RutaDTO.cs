using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CamionesWebMVC_v01.Models.DTOs
{
    public class RutaDTO
    {

        public int IdRUTA { get; set; }


        [Required(ErrorMessage ="DEBE SELECCIONAR UN CHOFER")]
        [Display(Name ="Chofer")]
        public int IdChofer { get; set; }


        [Required(ErrorMessage = "DEBE SELECCIONAR UN Camion")]
        [Display(Name = "Camión")]
        public int IdCamion { get; set; }


        [Required(ErrorMessage = "El origen es obligatorio")]
        [StringLength(200)]
        public string Origen { get; set; }


        [Required(ErrorMessage = "El destino es obligatorio")]
        [StringLength(200)]
        public string Destino { get; set; }


        [Required(ErrorMessage = "La fecha de salida es obligatoria")]
        [DataType(DataType.DateTime)]
        [Display(Name ="Fecha de Salida")]
        public DateTime FechaSalida { get; set; }



        [Required(ErrorMessage = "La fecha de llegada es obligatoria")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha de llegada")]
        public DateTime FechaLlegada { get; set; }


        [Display(Name = "Llegó a Tiempo")]
        public bool ATiempo { get; set; }


        [Required(ErrorMessage = "La distancia es obligatoria")]
        [Range(0.1, 10000, ErrorMessage ="Distancia entre 0.1 y 10000")]
        [Display(Name = "Distancia (km)")]
        public bool Distancia { get; set; }


        //propiedades adicionales para mostrar
        [Display(Name = "Chofer")]
        public string NombreChofer { get; set; }


        [Display(Name = "Licencia")]
        public string LicenciaChofer { get; set; }



        [Display(Name = "Matrícula")]
        public string MatriculaCamion {  get; set; }


        [Display(Name = "Duracion (Horas)")]
        public double DuracionHoras
        {
            get
            {
                TimeSpan duracion = FechaLlegada - FechaSalida;
                return Math.Round(duracion.TotalHours, 2);
            }
        }
    }
}