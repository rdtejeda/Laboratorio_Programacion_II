using System;
using Biblioteca;
/*
Consigna#
Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:
bool Validar(int valor, int min, int max)
valor: dato a validar.
min: mínimo valor incluido.
max: máximo valor incluido.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
IMPORTANTE
Utilizar variables escalares, NO utilizar vectores/arrays.
*/
namespace I01ValidadorRango
{
    internal class I01
    {
        static void Main(string[] args)
        {
            /*            
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
           }*/
            int numeroIngresado;
            int minimo=int.MaxValue;
            int maximo=int.MinValue;
            int contador = 0;
            do
            {
                do
                {
                    Console.WriteLine("Ingrese un numero");
                    numeroIngresado = int.Parse(Console.ReadLine());
                } while (!Validador.Validar(numeroIngresado, -100, 1000));
                minimo = ObtenerMinimo(numeroIngresado,minimo);
                maximo = ObtenerMaximo(numeroIngresado,maximo);
                contador++;
            } while (contador < 10);
            Console.WriteLine($"El numero menor es {minimo}");
            Console.WriteLine($"El numero mayor es {maximo}");
        }
        public static int ObtenerMinimo(int numeroIngresado, int minimo)
        {
            if(numeroIngresado < minimo)
            {
                minimo = numeroIngresado; 
            }
            return minimo;
        }
        public static int ObtenerMaximo(int numeroIngresado, int maximo)
        {
            if (numeroIngresado > maximo)
            {
                maximo = numeroIngresado;
            }
            return maximo;  
        }

    }
}
