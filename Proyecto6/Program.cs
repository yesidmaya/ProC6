using System;

namespace Proyecto5_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // Serie Fibonacci: 0,1,1,2,3,5,8,13,21,34,55,89....
            Console.WriteLine("Introduzca valor FINAL de la serie FIBONACCI ->");
            string valor = Console.ReadLine(); // tomamos valor

            int numero = -1;
            int a = 0;
            int b = 1;
            int suma = 0;



            string mostrarPantalla = String.Empty;// almacenamos la cadena de texto y colocamos la cadena vacia
            mostrarPantalla = "0";

            while (suma <= numero)
            {
                suma = a + b;
                a = b;
                b = suma;
                mostrarPantalla = mostrarPantalla + " " + suma;
            }

            Console.WriteLine(mostrarPantalla);
            Console.ReadLine();
        }

        private static int validarNumero(string valor)
        {
            int numero = -1;
            try
            {
                numero = Convert.ToInt32(valor); // convertimos valor a entero
            }
            catch (Exception /*ex*/)
            {
                Console.WriteLine("POR FAVOR DIGITA UN NUMERO" /*+ ex.ToString()*/); //ex para mostrar mas detalle del error
                Console.ReadLine();
            }
            return numero;
        }
    }
}
