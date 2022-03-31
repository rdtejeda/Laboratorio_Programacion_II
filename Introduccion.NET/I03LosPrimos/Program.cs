using System;

namespace I03LosPrimos
{
    /*
Consigna
Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
Validar que el dato ingresado por el usuario sea un número.
Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
Si ingresa "salir", cerrar la consola.
Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
IMPORTANTE
Utilizar sentencias de iteración, selectivas y el operador módulo (%). 
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int numero;
            do
            {
                Console.WriteLine("Ingrese un numero");
                entrada = Console.ReadLine();
                if (int.TryParse(entrada, out numero))
                {
                    if (numero < 2)
                    {
                        Console.WriteLine("PARA PODER LISTAR NUMERO PRIMOS INGRES ENTEROS MAYORES A 1");
                    }
                    int verificar;
                    int divisor = 0;
                    for (verificar = 2; verificar <= numero; verificar++) // Verifico los numeros entre 2 y el ingresado
                    {
                        for (divisor = 2; divisor < verificar; divisor++) // Determino si es primo
                        {
                            if ((verificar % divisor) == 0) // Si tiene un divisor con resto cero, salgo ya que NO ES PRIMO
                            {
                                break;
                            }
                        }
                        if (divisor == verificar)
                        {
                            Console.WriteLine("{0} es primo", verificar);
                        }
                    }
                    Console.WriteLine("Si desea volver a operar ingrese 'si'");
                    entrada = Console.ReadLine();
                    if (entrada != "si")
                    {
                        entrada = "salir";
                    }
                }
                else
                {
                    Console.WriteLine("Ingresar numero valido, para cerrar la aplicacxion ingrese 'salir'");
                    entrada = Console.ReadLine();
                }
            } while (entrada != "salir");
        }
    }
}
