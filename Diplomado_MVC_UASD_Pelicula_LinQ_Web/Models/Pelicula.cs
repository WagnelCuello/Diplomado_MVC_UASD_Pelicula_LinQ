using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diplomado_MVC_UASD_Pelicula_LinQ_Web.Models
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string AutorPrincipal { get; set; }
        public int NumAutores { get; set; }
        public decimal Duracion { get; set; }
        public int Estreno { get; set; }
    }
}