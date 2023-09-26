using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosConstructores
{
    class Persona
    {
        private int anioNacimiento;

        public Persona(int valorAnio)
        {
            anioNacimiento = valorAnio;
        }
        public void describir()
        {
            Console.WriteLine(
                "Año de nacimiento  " + anioNacimiento);
        }
        public float obtenerEdad()
        {
            int edad = 2023 - anioNacimiento;
            return edad;
        }
    }
}
