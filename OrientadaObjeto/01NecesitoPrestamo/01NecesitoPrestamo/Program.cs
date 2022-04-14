using System;
using Biblioteca;
/*
Consigna#
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.
Deberá tener los atributos:
titular que contendrá la razón social del titular de la cuenta.
cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
Construir los siguientes métodos para la clase:
Un constructor que permita inicializar todos los atributos.
Un método getter para cada atributo.
mostrar retornará una cadena de texto con todos los datos de la cuenta.
ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.
*/
namespace _01NecesitoUnPrestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Necesito un Prestamo";
            //Crear Nueva Cuenta
            Cuenta nuevaCuenta = new Cuenta("", 0);
            string entrada;
            string titularBuffer;
            decimal cantidadBuffer;
            bool volver = true;
            do
            {
                Console.WriteLine("Ingrese Titular de la Cuenta");
                titularBuffer = Console.ReadLine();
                Console.WriteLine("Ingrese Monto Deposito Inicial");
                entrada = Console.ReadLine();
                if (decimal.TryParse(entrada, out cantidadBuffer) && cantidadBuffer > 0)
                {
                    nuevaCuenta = new Cuenta(titularBuffer, cantidadBuffer);
                    Console.WriteLine(nuevaCuenta.Mostrar());
                    volver = false;
                }
                else
                {
                    Console.WriteLine("Ingrese Datos validos");
                }
            } while (volver);
            //Operar
            string operar;
            string entro;
            decimal monto = 0;
            do
            {
                Console.WriteLine("Escriba Para Depositar 'Ingresar', Para Extraer 'Retirar', Para Salir 'Salir'");
                operar = Console.ReadLine();
                if (operar == "Ingresar" || operar == "Retirar")
                {
                    Console.WriteLine("Ingres Monto");
                    entro = Console.ReadLine();
                    decimal.TryParse(entro, out monto);
                    switch (operar)
                    {
                        //INGRESAR
                        case "Ingresar":
                            nuevaCuenta.Ingresar(monto);
                            Console.WriteLine(nuevaCuenta.Mostrar());
                            break;
                        //RETIRAR
                        case "Retirar":
                            nuevaCuenta.Retirar(monto);
                            Console.WriteLine(nuevaCuenta.Mostrar());
                            break;
                        default:
                            break;
                    }
                }
            } while (operar != "Salir");
        }
    }
}