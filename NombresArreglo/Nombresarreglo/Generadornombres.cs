using System;


namespace NombresArreglo
{
    class GeneradorNombres
    {
       
        public string[] titulo = { "El washo", "Don", "El compare", "El machucao", "El guaton", "El shoro", "El pibe", "El morro", "El carnal", "El volao", "Compa", "Nini"};
        public string[] complemento = { "Motosierra", "Tunazo", "Serranita", "Camote", "Pastilla", "Petaca", "Mantarraya", "Pitilla", "Cobadonga", "Gambita" };

        public void generar(int MesNacimiento, int UltDigitoAnio)
        {
            Console.WriteLine("Crea tu nombre de personaje de Pobla");
            Console.WriteLine("Mes de nacimiento");
            for (int i = 0; i < titulo.Length; i++)
            {
                Console.WriteLine(i + 1 + ".-" + titulo[i]);
            }

            Console.WriteLine("Ultimo digito del año");
            for (int i = 0; i < complemento.Length; i++)
            {
                Console.WriteLine(i + 0 + ".-" + complemento[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Tu nombre de personaje de Pobla es: " + titulo[MesNacimiento - 1] + " " + complemento[UltDigitoAnio - 1]  );
        }
    }
}
