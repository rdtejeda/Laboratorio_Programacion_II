using System;

namespace I02ErroaAlCubo
{
    /*
   Consigna
   Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
   Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
   IMPORTANTE
   Utilizar el método Pow de la clase Math para calcular las potencias.
   */
    internal class I02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº2";
            string entrada;
            int numero;
            int verificador = -1;
            do
            {
                Console.WriteLine("Ingrese un numero");
                entrada = Console.ReadLine();
                if (int.TryParse(entrada, out numero)) // true sigue en el if false sale al else si lo huibiera
                {
                    if (numero > 0)
                    {
                        Console.WriteLine("El cuadrado de {0} es {1} y el cubo es {2}", numero, (long)Math.Pow(numero, 2), (long)Math.Pow(numero, 3));
                        verificador = 0;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. ¡Reingresar número!");
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese numero valido");
                }
            } while (verificador == -1);// true sigue en loop false sale del lopp
        }
    }
}
