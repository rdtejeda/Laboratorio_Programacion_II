using System;
using Biblioteca;

namespace Clase06Abril
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Tiempo tiempoCero = new Tiempo(2);
            Console.WriteLine(tiempoCero.Mostrar());
            
            Console.WriteLine("Sobrecarga conversion Implicita");
            Tiempo tiempoUno = "01:01:01";
            Console.WriteLine(tiempoUno.Mostrar());

            Console.WriteLine("Sobrecarga conversion Exmplicita");
            int tiempoEnSegundos=(int)tiempoCero;
            Console.WriteLine(tiempoEnSegundos);
            */

            Console.WriteLine(Validador.ValidarRango(4, 0,10 ));
            Console.WriteLine(Validador.ValidarRango(4.5f,0.1f,10.12f));
            Console.WriteLine(Validador.ValidarRango("Hola",1,10));

            Tiempo tiempoUno = new Tiempo(12,12,12);
            Tiempo tiempoDos = new Tiempo(11, 11);
            Tiempo tiempoTres = new Tiempo(10);

            Console.WriteLine(tiempoUno.Mostrar());
            Console.WriteLine(tiempoDos.Mostrar());
            Console.WriteLine(tiempoTres.Mostrar());

        }
    }
}
