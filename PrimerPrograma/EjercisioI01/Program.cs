using System;

namespace EjercisioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float leer = 5;
            int numero;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int acumulador =0;
            float promedio = 0;
            string entrada;

            for (int i = 0; i < leer; i++)
            {
                Console.WriteLine("Ingrese un numer entero");
                entrada = Console.ReadLine();
                if (int.TryParse(entrada, out numero))
                {
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    acumulador = acumulador + numero;
                }else
                    {
                        Console.WriteLine("Ingrese un numer entero VALIDO");
                        i--;
                    }
            }
            promedio =  acumulador / leer;
            Console.WriteLine("El minimo es {0}, el maximo es {1} y el promedio es {2:F}.", minimo,maximo,promedio);
        }       
    }
}
