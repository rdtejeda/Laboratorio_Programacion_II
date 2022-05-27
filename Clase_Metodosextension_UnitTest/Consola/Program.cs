using System;
using Biblioteca;
namespace Consola
{
    internal class Program
    {
        static void Main(string [] args)
        {


            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(i.FizzBuzz());
            }

            Console.ReadKey();
  
            string texto = "Hola Mundo";

            int cantidadDePalabras = texto.ContarPalabras();

            int cantidad = StringExtendido.ContarPalabras(texto);

            Console.WriteLine(cantidad);
        }
    }
    
}
