using System;

namespace EjerciciosConstructores
{
    class Producto
    {
        private float precio;

        public Producto(int valorPrecio)
        {
            precio = valorPrecio;
        }

        public void describir()
        {
            Console.WriteLine(
                "Precio" + precio);
        }
        public float obtener()
        {
            float precioIva = precio + (precio * 0.16f);
            return precioIva;
        }
  
    }
}
