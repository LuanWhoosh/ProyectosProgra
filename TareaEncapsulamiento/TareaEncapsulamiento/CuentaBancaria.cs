using System;

namespace TareaEncapsulamiento
{
    class CuentaBancaria
    {
        private int pin;
        private int saldo;
        public int getPin()
        {
            return pin;
        }
        public int getSaldo()
        {
            if (pin != 0)
            {
                return saldo;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Saldo no disponible");
                return 0;
            }
        }

        public void setPin(int valor)
        {
            pin = valor;
        }

        public void setSaldo(int cantidad)
        {
            saldo = cantidad;
        }

        
    }
}
