using System;
using Biblioteca;

namespace I01ValidadorRango
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int numero;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero");
                entrada = Console.ReadLine();
                int.TryParse(entrada, out numero);
                if (Validador.Validar(numero, -100, 100))
                {
                    Console.WriteLine("El numero {0} esta dentro del rango", numero);
                }
                else
                {
                    Console.WriteLine("Fuera de rango!");
                }
            }
        }
    }
}
