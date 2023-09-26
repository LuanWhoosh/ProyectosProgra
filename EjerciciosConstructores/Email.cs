using System;


namespace EjerciciosConstructores
{
    class Email
    {
        private string subject;
        private string contenido;
        private string destinatario;

        public Email(string tema, string contenidoC, string destinatarioC)
        {
            subject=tema;
            contenido=contenidoC;
            destinatario= destinatarioC;
        }

     public void describir()
        {
            Console.WriteLine(
                "Email   " + subject + contenido + destinatario);

        }

    }    
}
