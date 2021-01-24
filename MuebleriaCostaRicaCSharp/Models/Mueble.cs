using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MuebleriaCostaRicaCSharp.Models
{
    public class Mueble
    {
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
    }
}