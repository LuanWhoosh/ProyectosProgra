using System;

namespace CarreraDeCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto ferrari = new Auto();
            ferrari.modelo = "Ferrari F1";
            ferrari.velocidad = 120;

            Auto mclaren = new Auto();
            mclaren.modelo = "MC 2443";
            mclaren.velocidad = 140; //Son Km/h
       
            PistaCarreras pista1 = new PistaCarreras();
            pista1.nombre = "Hermanos Rodriguez";
            pista1.longitud = 4.303f; //Son km

            pista1.Competir(ferrari, mclaren);

            Console.ReadLine();
        }
    }
}
