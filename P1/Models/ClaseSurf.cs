using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P1.Models
{
    public class ClaseSurf
    {
        public string Nombre { get; set; }

        public int DuracionClase { get; set; }

        public decimal PrecioBase { get; set; }

        public decimal Descuento { get; set; }

        public List<Cronograma> ListaCronograma { get; set; }

        public List<Dia> ListaDias { get; set; }

        public ClaseSurf()
        {
            ListaCronograma = new List<Cronograma>();
            ListaDias = new List<Dia>();
        }
    }
}