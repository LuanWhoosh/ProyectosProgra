using System;//El using no es una declaración

namespace Ejemplos//Declaración de espacio de nombres Ejemplos
{
    class Elefante//Declaracióººn de clase Elefante dentro de namespace Ejemplos
    {
        public string Nombre;//Declaración de atributo Nombre dentro de clase Elefante
        public int Edad;//declaracion de atributo Edad dentro de clase Elefante
        public float Peso;//declaracion de atributo Peso dentro de clase Elefante

        //Declaración de método Comer dentro de clase Elefante
        //Declaración de parámetro comida dentro de método comer
        public void Comer(string comida)
        {

            for (int i = 0; i < 10; i++)//Ciclo for dentro de método Comer
            {
                int porcionesComidas = i + 1;//Declaración de variable local porcionesComidas dentro de ciclo for
            }
            Console.WriteLine($"{Nombre} está comiendo {comida}.");//Esta línea no llevará comentario
        }

        //Declaración de método rugir dentro de clase Elefante
        public void Rugir()
        {
            int distanciaEscuchante = 100;//Declaración de variable local distanciaEscuchante dentro de mètodo rugir
            Console.WriteLine($"{Nombre} está rugiendo.");
        }

        //Declaración de método Dormir dentro de clase Elefante
        //Declaración de parámetro horas dentro de método dormir
        public void Dormir(int horas)
        {
            if (horas > 10)//bloque condicional if dentro de mètodo dormir
            {
                float energiaGanada = 15;//declaraciòn de variable local energiaGanada dentro de bloque condicional if
            }
            Console.WriteLine($"{Nombre} está durmiendo durante {horas} horas.");
        }
    }

    class Zapatero//declaraciòn de clase zapatero dentro de namespace ejemplos
    {
        public string Nombre; //declaraciòn de atributo Nombre dentro de calse Zapatero
        public string Especialidad;//declaraciòn de atributo Especialidad dentro de calse Zapatero
        public int AñosExperiencia;//declaraciòn de atributo AñosExperiencia dentro de calse Zapatero

        //declaraciòn de mètodo RepararZapatos dentro de clase Zapatero
        //declaraciòn de paràmetro tipo dentro de mètodo RepararZapatos
        //declaraciòn de paràmetro cantidaddentro de mètodo RepararZapatos
        public void RepararZapatos(string tipo, int cantidad)
        {
            int precio = 50;//declaraciòn de variable local precio dentro de mètodo RepararZapatos
            if (tipo == "tenis")//declaraciòn de bloque condicional if dentro de mètodo RepararZapatos
            {
                precio = 100;//uso de variable local precio dentro de bloque condicional if
            }
            Console.WriteLine($"{Nombre} está reparando {cantidad} zapatos de tipo {tipo} a precio {precio}");
        }
        //declaraciòn de mètodo CrearZapatodentro de clase zapatero
        //declaraciòn de paràmetro estilo dentro mètodo CrearZapato
        //declaraciòn de paràmetro material dentro mètodo CrearZapato
        public void CrearZapato(string estilo, string material)
        {
            for (int i = 0; i < 100; i++)//declaraciòn de ciclo for dentro de mètodo CrearZapato
            {
                if (estilo == "industrial")//declaraciòn de bloque condicional if dentro de ciclo for
                {
                    Console.WriteLine("Golpeando fuerte");
                }
                else //declaraciòn de bloque condicional else dentro de ciclo for
                {
                    Console.WriteLine("Golpeando normal");

                }
            }
            Console.WriteLine($"{Nombre} está creando un zapato de estilo {estilo} con material {material}.");
        }
        //declaraciòn de mètodo MedirPie dentro de clase Zapatero
        //declaraciòn de paràmetro numeroPie dentro de mètodo MedirPie
        public void MedirPie(int numeroPie)
        {
            string cliente;//declaraciòn de variable local cliente dentro de mètodo MedirPie
            if (numeroPie > 20)//declaraciòn de bloque condicional if dentro de mètodo MedirPie
            {
                cliente = "Adulto";
            }
            else//declaraciòn de bloque condicional else dentro de mètodo MedirPie
            {
                cliente = "Niño";
            }
            Console.WriteLine($"{Nombre} está midiendo el pie para el número {numeroPie}.");
        }
    }

    class Television//declaracion de clase Television dentro de namespace ejemplos
    {
        public string Marca;//declaraciòn de atributo Marca dentro de clase Television
        public int Pulgadas;//declaracion de atributo Pulgadas dentro de clase Television
        public bool Encendida;//declaracion de atributo Encendida dentro de clase Television

        public void Encender()//declaraciòn de metodo Encender dentro de clase Television
        {
            Encendida = true;
            float consumoLuz = 0.05f;//declaraciòn de variable local consumoluz dentro de mètodo Encender
            Console.WriteLine($"La televisión de {Pulgadas} pulgadas, marca {Marca}, está encendida.");
        }
        //declaraciòn de metodo CambiarCanal dentro de clase Television
        //declaracion de parametro Canl dentro de metodo CambiarCanal
        public void CambiarCanal(int canal)
        {
            for (int i = 1; i < canal; i++)//declaracion de ciclo for dentro metodo CambiarCanal
            {
                Console.WriteLine($"Cambiando a canal {i}.");
            }
        }
        //declaracion de metodo AjustarVolumen dentro de clase Television
        //declaracion de parametro nivel dentro de metodo AjustarVolumen
        public void AjustarVolumen(int nivel)
        {
            if (nivel > 100)//declaracion de bloque condicional if dentro de metodo Ajustar volumen
            {
                nivel = 0;
            }
            Console.WriteLine($"Ajustando el volumen a nivel {nivel}.");
        }
    }

    class Guitarra//delcaracion de clase Guitarra dentro de namespace Ejemplos
    {
        public string Marca;//declaracion de atributo marca dentro de clase Guitarra
        public string Tipo;//declaracion de atributo tipo dentro de clase Guitarra
        public int Cuerdas;//declaracion de atributo cuerdas dentro de clase Guitarra
        //declaracion de metodo TocarCuerda dentro de clase Guitarra
        //declaracion de atributo NumeroCuerda dentro de metodo tocarCuerda
        public void TocarCuerda(int numeroCuerda)
        {
            if (numeroCuerda == 6)//declaracion de bloque condicional if dentro de metodo TocarCuerda
            {
                string nota = "Mi";
            }
            else if (numeroCuerda == 5)//declaracion de bloque condicional else dentro de metodo TocarCuerda
            {
                string nota = "La";
            }
            Console.WriteLine($"Tocando la cuerda {numeroCuerda} de la guitarra {Marca}.");
        }
        //declaracion de metodo AfinarGuitarra dentro de claseGuitarra
        //declaracion de parametro afinada dentro de metodo AfinarGuitarra
        public void AfinarGuitarra(bool afinada)
        {
            if (afinada)//declaracion de bloque condicional if dentro de metodo AfinarGuitarra
            {
                Console.WriteLine($"La guitarra {Marca} está afinada.");
            }
            else//declaracion de metodo condicional else dentro de metodo AfinarGuitarra
            {
                for (int i = 0; i < 5; i++)//declaracion de ciclo for dentro de bloque condicional else
                {
                    Console.WriteLine($"Afinando la guitarra {Marca}.");
                }
            }
        }
        //declaracion de metodo CambiarTipo dentro de clase Guitarra
        //declaracion de parametro nuevoTipo dentro de metodo CambiarTipo
        public void CambiarTipo(string nuevoTipo)
        {
            Tipo = nuevoTipo;
            Console.WriteLine($"Cambiando el tipo de la guitarra a {nuevoTipo}.");
        }
    }

}
