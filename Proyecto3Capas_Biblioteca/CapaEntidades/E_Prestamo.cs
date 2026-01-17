using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Prestamo
    {
        public int PrestamosID {  get; set; }
        public int LibrosID {  get; set; }
        public int SociosID {  get; set; }
        public string Titulo {  get; set; }
        public DateTime Fecha {  get; set; }
        public bool Regresado {  get; set; }
    }
}
