using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CamionesWebMVC_v01.Models.DTOs
{
    public class ChoferDTO
    {

        public int IdChofer { get; set; }


        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido paterno es obligatorio")]
        [StringLength(100)]
        [Display(Name = "Apellido Paterno")]
        public string ApPaterno { get; set; }


        [Required(ErrorMessage = "El apellido materno es obligatorio")]
        [StringLength(100)]
        [Display(Name = "Apellido Materno")]
        public string ApMaterno { get; set; }


        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [StringLength(15)]
        [Phone(ErrorMessage = "Teléfono invalido")]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }


        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }


        [Required(ErrorMessage = "La licencia es obligatoria")]
        [StringLength(50)]
        public string Licencia { get; set; }


        [Display(Name = "Url Foto")]
        [Url(ErrorMessage = "Url Invalida")]
        public string UrlFoto { get; set; }


        [Display(Name = "Disponible")]
        public bool Disponibilidad { get; set; }


        [Display(Name = "Nombre Completo")]
        public string NombreCompleto =>$"{Nombre } {ApPaterno } { ApMaterno }";


        [Display(Name ="Edad")]
        public int Edad
        {
            get
            {
                int edad = DateTime.Now.Year - FechaNacimiento.Year;
                if (FechaNacimiento > DateTime.Now.AddYears(-edad))edad--;
                return edad;
                
                    
                
            }
        }



    }
}