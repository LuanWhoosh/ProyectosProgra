using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosConstructores
{
    class Zapato
    {
        private string color;
        private string talla;

        public Zapato(string cadenaColor, string cadenaTalla)
        {
            color = cadenaColor;
            talla = cadenaTalla;
        }

        public void describir()
        {
            Console.WriteLine(
                "Color zapato" + color+ "----" + "Talla zapato" + talla);

        }
    }
}
