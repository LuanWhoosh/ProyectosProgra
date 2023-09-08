using System;

namespace ArreglosPractica080923
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ciudades = {
                "Osaka", "Tokyo", "Seùl",
                "Puebla","Montreal", "Parìs", "Londres", "Buenos Aires"
            };
            //Obtener la longitud del arreglo
            int cantElms = ciudades.Length;
            Console.WriteLine("El arreglo tiene " + cantElms + "  elementos");

            //Acceder a los elementos del arreglo guardando una variable
            string ciudad1 = ciudades[1];
            string ciudad4 = ciudades[4];

            Console.WriteLine(ciudad1);
            Console.WriteLine(ciudad4);

            //Acceder directamente SIN necesidad de una variable
            Console.WriteLine(ciudades[0]);
            Console.WriteLine(ciudades[5]);

            ciudades[4] = "Otawa";
            Console.WriteLine(ciudades[4]);

            for (int i = 0; i < 8; i++)
            {
               //Esta hardcodeado el 8 :( (no es adaptativo) NO LO USES
            }

            for (int i = 0; i < ciudades.Length; i++)
            { //Parametrizado :D (es adaptativo)
                Console.WriteLine(i + ".-" + ciudades[i]);

            }

            Console.Read();
        }
    }
}
