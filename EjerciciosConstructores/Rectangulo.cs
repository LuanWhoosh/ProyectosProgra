using System;

namespace EjerciciosConstructores
{
    public class Rectangulo
    {
        //Estos atributos tienen un valor 
        //por default
        private int ancho = 5;
        private int alto = 10;


        public Rectangulo()
        {

        }
        //este es otro constructor, pero si recibe parametros
        public Rectangulo(int valorAncho, int valorAlto)
        {//establezco el estado inicial del objeto
            ancho = valorAncho;
            alto = valorAlto;
        }
        public void describir()
        {
            Console.WriteLine(
                "Rectangulo " + ancho + " x " + alto);
        }
        public float calcArea()
        {
            float area = alto * ancho;
            return area;
        }

        public void setAlto(int valor)
        {
            alto = valor;
        }
    }
}
