using System;


namespace EjerciciosConstructores
{
    public class Circulo
    {
        private float radio;

        public Circulo(int valorRadio)
        {
            radio = valorRadio;
        }

        public void describir()
        {
            Console.WriteLine(
                "Circulo " + radio) ;
        }
        public float calcPerimetro()
        {
            float perimetro = (float)(2 * Math.PI * radio);
            return perimetro;
        }
    }
}
