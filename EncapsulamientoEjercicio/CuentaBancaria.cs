using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamientoEjercicio
{
    class CuentaBancaria
    {
        private int pin;
        private int saldo;

        public int getpin()
        {
            return pin;
        }
        public int getsaldo()
        {
            return saldo;
        }

        public void setpin(int valor)
        {
            pin = valor; 
        }

        public void getsaldo(int cantidad)
        {
            saldo = cantidad;
        }

        public void consultar(int pin)
        {
            if (pin == 0)
            {
                return saldo;
            }
            else
            {

            }


        }

    }
}
