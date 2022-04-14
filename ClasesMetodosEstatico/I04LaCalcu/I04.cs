using System;
using I04LaCalcu;
using Biblioteca;
/*
 Consigna
Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.

Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.
 */
namespace I04LaCalcu
{
    internal class I04
    {
        static void Main(string[] args)
        {
            int primeOperador;
            int segundoOperador;
            char operacion;
            int resultado;
            string entrada;
            char respuesta;
            Console.WriteLine("BIENVENIDO A LA CALCULADORA");
            do
            {
                do
                {
                    Console.WriteLine("Ingrese el primer operador");
                    entrada = Console.ReadLine();
                } while (!int.TryParse(entrada, out primeOperador));
                do
                {
                    Console.WriteLine("Ingrese el segundo operador");
                    entrada = Console.ReadLine();
                } while (!int.TryParse(entrada, out segundoOperador));
                do
                {
                    Console.WriteLine("Ingrese operacion");
                    entrada = Console.ReadLine();
                    char.TryParse(entrada, out operacion);
                } while (!(operacion == '+' || operacion == '-' || operacion == '*' || operacion == '/'));
                resultado = Calculadora.Calcular(primeOperador, segundoOperador, operacion);
                Console.WriteLine($"{primeOperador} {operacion} {segundoOperador} = {resultado}");
                Console.WriteLine("¿Desea continuar? (S/N)");
                entrada = Console.ReadLine();
                char.TryParse(entrada, out respuesta);
            } while (Validador.ValidarRespuesta(respuesta));            
        }
    }
}
