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
            int entero=0;
            string entrada;
            char respuesta;
            do
            {
                Console.WriteLine($"El entero vale {entero}"); //("El entero vale {0}",entero);
                entero++;
                Console.WriteLine("¿Desea continuar? (S/N)");
                entrada = Console.ReadLine();
                char.TryParse(entrada, out respuesta);
            } while (Validador.ValidarRespuesta(respuesta));
        }
    }
}
