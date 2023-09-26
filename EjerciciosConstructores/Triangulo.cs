using System;

namespace EjerciciosConstructores
{
    class Triangulo
    {
        private int lado1;
        private int lado2;
        private int baseT;

        public Triangulo(int valorLado1, int valorLado2, int valorBase)
        {
            lado1 = valorLado1;
            lado2 = valorLado2;
            baseT = valorBase;
        }
        public void describir()
        {
            Console.WriteLine(
                "Triangulo " + lado1 + " + " + lado2 + " + " + baseT);
        }
        public float calcPerimetro()
        {
            float perimetro = lado1+ lado2 + baseT;
            return perimetro;
        }
    }
}
