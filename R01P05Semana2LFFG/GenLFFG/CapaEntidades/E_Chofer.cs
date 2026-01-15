using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Chofer
    {
        public int IdChofer { get; set; }
        public String Nombre { get; set; }
        public String ApPaterno { get; set; }
        public String ApMaterno { get; set; }
        public String Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Licencia { get; set; }
        public String UrlFoto { get; set; }
        public bool Disponibilidad { get; set; }
        public DateTime FechaRegistro { get; set; }
       
    }
}
