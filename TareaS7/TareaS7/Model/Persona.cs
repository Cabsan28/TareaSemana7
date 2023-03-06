using System;
using System.Collections.Generic;
using System.Text;

namespace TareaS7.Model
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string NumeroCuenta { get; set; }


        public override string ToString()
        {
            return $"{Nombre} - {NumeroCuenta}";
        }

    }
}
