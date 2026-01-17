using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Libro
    {
        public int LibrosID { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Disponibles { get; set; }
        public string Genero { get; set; }

    }
}
