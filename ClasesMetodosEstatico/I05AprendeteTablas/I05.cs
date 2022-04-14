using System;
using Biblioteca;
using System.Text;
using I05AprendeteTablas;
/*
Consigna
Crear una aplicación de consola que permita al usuario ingresar un número entero.
Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.
Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.
Mostrar en la consola el resultado.
Por ejemplo, si se ingresa el número 2 la salida deberá ser:
Tabla de multiplicar del número 2:
2 x 1 = 2
2 x 2 = 4
2 x 3 = 6
2 x 4 = 8
2 x 5 = 10
2 x 6 = 12
2 x 7 = 14
2 x 8 = 16
2 x 9 = 18
 */
namespace I05AprendeteTablas
{
    internal class I05
    {
        static void Main(string[] args)
        {
            int multiploUno;
            int resultado;
            string entrada;
            char respuesta;
            Console.WriteLine("BIENVENIDO A LAS TABLAS");
            do
            {
                do
                {
                    Console.WriteLine("Ingrese un entero");
                    entrada = Console.ReadLine();
                } while (!int.TryParse(entrada, out multiploUno));
                StringBuilder sb = new StringBuilder();
                sb = Tabla.LaTabla(multiploUno);
                Console.WriteLine(sb); 
                Console.WriteLine("¿Desea continuar? (S/N)");
                entrada = Console.ReadLine();
                char.TryParse(entrada, out respuesta);
            } while (Validador.ValidarRespuesta(respuesta));
        }
    }
}
