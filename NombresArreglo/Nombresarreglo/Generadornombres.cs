using System;


namespace NombresArreglo
{
    class GeneradorNombres
    {
       
        public string[] titulos = { "El washo", "Don", "El compare", "El machucao", "El guaton", "El shoro", "El pibe", "El morro", "El carnal", "El volao", "Compa", "Nini"};
        public string[] complementos = { "Motosierra", "Tunazo", "Serranita", "Camote", "Pastilla", "Petaca", "Mantarraya", "Pitilla", "Cobadonga", "Gambita" };

        public void generar(int mesNacimiento, int ultDigito)
        {
            Console.WriteLine("Crea tu nombre de personaje de Pobla");
            Console.WriteLine("");
            Console.WriteLine("Mes de nacimiento");
            Console.WriteLine("");
            for (int i = 0; i < titulos.Length; i++)
            {
                Console.WriteLine(i + 1 + ".-" + titulos[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Ultimo digito del año de nacimiento");
            Console.WriteLine("");
            for (int i = 0; i < complementos.Length; i++)
            {
                Console.WriteLine(i + 0 + ".-" + complementos[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Tu nombre de personaje de Pobla es: " + titulos[mesNacimiento - 1] + " " + complementos[ultDigito- 1]  );
        }
    }
}
