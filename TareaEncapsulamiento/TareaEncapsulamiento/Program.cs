using System;

namespace TareaEncapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Consulta de saldo de Cuenta Bancaria");

            CuentaBancaria cuenta = new CuentaBancaria();

            cuenta.setPin(2828);
            cuenta.setSaldo(5000);

            int pin = cuenta.getPin();
            int saldo = cuenta.getSaldo();

            Console.WriteLine(" ");
            Console.WriteLine("Tu PIN es: " + pin);
            Console.WriteLine(" ");
            Console.WriteLine("Saldo total de: $ " + saldo);
            Console.ReadLine();
        }
    }
}
