using System;

namespace EjerciciosConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rect1 = new Rectangulo();
            rect1.describir();
            float area1 = rect1.calcArea();
            Console.WriteLine("Area " + area1);
            

            Rectangulo rect2 = new Rectangulo();
            rect2.setAlto(12);
            rect2.describir();
            float area2 = rect2.calcArea();
            Console.WriteLine("Area " + area2);

            //construyo un rectangulo definiendo los 
            //valores desde el constructor
            Rectangulo rect3 = new Rectangulo(3,2);
            rect3.describir();
            float area3 = rect3.calcArea();
            Console.WriteLine("Area " + area3);

            Console.WriteLine("");

            //EJERCICIOS
            Triangulo triangulo1 = new Triangulo(3, 4, 7);
            triangulo1.describir();
            float perimetro1 = triangulo1.calcPerimetro();
            Console.WriteLine("Perimetro " + perimetro1);

            Console.WriteLine("");

            Triangulo triangulo2 = new Triangulo(3, 4, 5);
            triangulo2.describir();
            float perimetro2 = triangulo2.calcPerimetro();
            Console.WriteLine("Perimetro " + perimetro2);

            Console.WriteLine("");


            Circulo circulo1 = new Circulo(12);
            circulo1.describir();
            float perimetroC1 = circulo1.calcPerimetro();
            Console.WriteLine("Perimetro " + perimetroC1);


            Console.WriteLine("");


            Circulo circulo2 = new Circulo(12);
            circulo2.describir();
            float perimetroC2 = circulo2.calcPerimetro();
            Console.WriteLine("Perimetro " + perimetroC2);

            Console.WriteLine("");

            Producto producto1 = new Producto(100);
            producto1.describir();
            float precioNuevo = producto1.obtener();
            Console.WriteLine("Precio con IVA   " + precioNuevo);

            Producto producto2 = new Producto(340);
            producto2.describir();
            float precioN = producto2.obtener();
            Console.WriteLine("Precio con IVA   " + precioN);

            Console.WriteLine("");

            Console.WriteLine("");
            Zapato zapato1 = new Zapato("lila   ", "12   ");
            zapato1.describir();

            Console.WriteLine("");
            Zapato zapato2 = new Zapato("azul   ", "15  ");
            zapato2.describir();

            Console.WriteLine("");

            Persona persona1 = new Persona(2004);
            persona1.describir();
            float edad1 = persona1.obtenerEdad();
            Console.WriteLine("Edad  " + edad1);

            Persona persona2 = new Persona(2000);
            persona2.describir();
            float edad2 = persona1.obtenerEdad();
            Console.WriteLine("Edad  " + edad2);

            Console.WriteLine("");
            Email email1 = new Email("Falta ", " Buenos dias,el dia de mañana no podre ir a clases     ", "Profesor x");
            email1.describir();

            Console.WriteLine("");
            Email email2 = new Email("Tarea  ", " Adjunto mi tarea     ", "Profesor x");
            email2.describir();


            Console.ReadLine();
        }
    }
}
