using System;

namespace I01MaxMin
{
    /* Consigna#
      Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio. 
      INFORMACIÓN
      Un escalar es una constante o variable que contiene un dato atómico y unidimensional.En contraposición al concepto de escalar, están los conceptos de array,
      lista y objeto, que pueden tener almacenado en su estructura más de un valor.​ Ver en Wikipedia.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercisio 01 Máximos y Mínimos";
            float numero;
            float minimo = float.MaxValue;
            float maximo = float.MinValue;
            float acumulador = 0;
            float promedio = 0;
            string entrada;
            int i = 0;
            do
            {
                i++;
                Console.WriteLine("Ingrese un numero");
                entrada = Console.ReadLine();
                if (float.TryParse(entrada, out numero))
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
                }
                else
                {
                    Console.WriteLine("Ingrese un número VALIDO");
                    i--;
                }
            } while (i < 5);
            promedio = acumulador / i;
            Console.WriteLine("El minimo es {0}, el maximo es {1} y el promedio es {2:F}.", minimo, maximo, promedio);
        }
    }
}
