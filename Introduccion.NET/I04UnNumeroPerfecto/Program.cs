using System;
/*
Consigna#
Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
Escribir una aplicación que encuentre los 4 primeros números perfectos.
IMPORTANTE
Utilizar sentencias de iteración y selectivas.
*/
namespace I04UnNumeroPerfecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 4;
            int numero = 1;
            int paso = 0;
            do
            {
                int buscar = 0;
                for (int j = 1; j < numero; j++)
                {
                    if (numero % j == 0)
                    {
                        buscar = buscar + j;
                    }
                }
                if (buscar == numero)
                {
                    Console.WriteLine("{0} es un numero perfecto", numero);
                    paso++;
                }
                numero++;
            } while (paso != n);
        }
    }
}
