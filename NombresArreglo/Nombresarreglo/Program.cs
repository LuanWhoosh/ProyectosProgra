using System;

namespace NombresArreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneradorNombres generador = new GeneradorNombres();
            generador.generar(11, 2);
            Console.Read();
        }
    }
}
