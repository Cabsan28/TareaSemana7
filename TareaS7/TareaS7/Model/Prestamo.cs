using System;
using System.Collections.Generic;
using System.Text;

namespace TareaS7.Model
{
    public class Prestamo 
    {
        public string Libro { get; set; }
        public string Persona { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }


        public override string ToString()
        {
            return $"{Libro} - {Persona} - {FechaPrestamo} - {FechaDevolucion}";
        }

    }
}
