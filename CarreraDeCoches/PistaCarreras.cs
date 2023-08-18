using System;


namespace CarreraDeCoches
{
    public class PistaCarreras
    {
        public string nombre;
        public float longitud;


    //Es un metodo que recibe dos parametros 
        public void Competir(Auto auto1, Auto auto2)
         {
           Console.WriteLine("Iniciando competencia entre   "  + auto1.modelo + "  contra  " + auto2.modelo);

            if (auto1.velocidad > auto2.velocidad)
            {
                Console.WriteLine("Gano " + auto1.modelo);
            }
            else if (auto2.velocidad > auto1.velocidad)
            {
                Console.WriteLine("Gano " + auto2.modelo);
            }
            else
            {
                Console.WriteLine("Hubo un empate");
            }
     

}


}


}
