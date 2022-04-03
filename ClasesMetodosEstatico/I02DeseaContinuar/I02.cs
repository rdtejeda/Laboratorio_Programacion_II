using System;
using Biblioteca;
/*
Consigna#
Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".
Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
*/

namespace I02DeseaContinuar
{
    internal class I02
    {
        static void Main(string[] args)
        {
            Console.Title = "¿Desea Continuar";
            int enteros=0;
            int respuesta=-1;
            string entrada;
            do
            {
                enteros++;
                Console.WriteLine("¿Desea continuar? (S/N)");
                entrada = Console.ReadLine();
                /*
                if(entrada=="S")
                {
                    respuesta = 0;
                }
                */
            } while (Validador.ValidarRespuesta(entrada));     
            Console.WriteLine("Hello World!");
        }
    }
}
