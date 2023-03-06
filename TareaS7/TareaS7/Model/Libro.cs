using System;
using System.Collections.Generic;
using System.Text;

namespace TareaS7.Model
{
    public class Libro
    {
        public string Nombre { set; get; }
        public string Autor { set; get; }
        public DateTime FechaImpresion { set; get; }

        public override string ToString()
        {
            return $"{Nombre} - {Autor} - {FechaImpresion}";
        }

    }
}
