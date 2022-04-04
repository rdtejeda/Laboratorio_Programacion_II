using System;
/*
Consigna#
Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.
El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15.
El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
IMPORTANTE
Utilizar sentencias de iteración y selectivas.
 */
namespace I05TirameCentro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº5";
            string entrada;
            int numero;
            Console.WriteLine("Ingrese un numero entero mayor a 1");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out numero);            
            for (int i = 1; i <= numero; i++) 
            {                
                //Suma de menores
                int sumaMenores = 0;
                for (int j = 0; j < i; j++)
                {
                    sumaMenores = sumaMenores + j;
                }
                //Suma de Mayores
                int diferencia = 0;
                int sumaMayores = 0;
                for (int k=i+1; diferencia>=0; k++)
                {
                   sumaMayores= sumaMayores + k;
                   //Calculo diferencia para definir Centro
                   diferencia = sumaMenores - sumaMayores;
                   if (diferencia == 0)
                   {
                    Console.WriteLine("{0} es centro numerico", i);
                   }                      
                }                    
            }           
        }
    }
}
