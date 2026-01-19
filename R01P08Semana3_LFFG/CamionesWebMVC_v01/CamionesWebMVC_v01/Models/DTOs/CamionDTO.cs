using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Pkcs;


namespace CamionesWebMVC_v01.Models.DTOs
{
    public class CamionDTO
    {
        public int IdCamion { get; set; }

        [Required(ErrorMessage = "La matricula es obligatoria")]
        [StringLength (50, ErrorMessage ="Maximo 50 caracteres")]
        [Display(Name  = "Matricula")]
        public int Matricula { get; set; }


        [Required(ErrorMessage = "El tipo de camion es obligatorio")]
        [Display(Name = "Tipo de camión")]
        public string TipoCamion { get; set; }
        
        
        [Required(ErrorMessage = "El modelo es obligatorio")]
        [Range(1900, 2030, ErrorMessage = "Módelo invalido")]
        public int Modelo { get; set; }
        
        
        [Required(ErrorMessage = "La marca es obligatoria")]
        [StringLength(50)]
        public string marca { get; set; }


        [Required(ErrorMessage = "La capacidad es obligatoria")]
        [Range(1, 100000, ErrorMessage = "Capacidad entre 1 y 100000 kg")]
        [Display(Name = "Capacidad (kg)")]
        public int Capacidad { get; set; }


        [Range(0, double.MaxValue, ErrorMessage = "kilometraje invalido")]
        public double Kilometraje { get; set; }


        [Display(Name = "URL foto")]
        [Url(ErrorMessage = "URL invalida")]
        public string UrlFoto { get; set; }


        [Display(Name = "Fecha de Registro")]
        public DateTime FechaRegistro {  get; set; }


    }
}