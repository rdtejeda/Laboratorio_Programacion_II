using System;
/*
Consigna
Escribir un programa que imprima por consola un triángulo como el siguiente:

*
***
*****
*******
*********

El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo.
Para el ejemplo anterior, la altura ingresada fue de 5.
 */
namespace I08DibTrianguloRec
{  
    internal class I08
    {
        static void Main(string[] args)
        {
            string entrada;
            int altura;
            string asterisco = "*";
            string asteriscoDos="**"; 
            Console.Title = "Dibujando un triángulo rectángulo";
            do
            {
                Console.WriteLine("Ingrese altura del triangulo");
                entrada = Console.ReadLine();
            } while (!int.TryParse(entrada, out altura));            
            if(altura>1)
            {
                for (int i = 0;  i <altura; i ++)
                {
                    
                    Console.WriteLine(asterisco);
                    asterisco = asterisco + asteriscoDos;
                }
            }else
            {
                Console.WriteLine("Para poder dibujar un Triangulo ingrese una altura mayora 1");
            }           
        }
    }
}
