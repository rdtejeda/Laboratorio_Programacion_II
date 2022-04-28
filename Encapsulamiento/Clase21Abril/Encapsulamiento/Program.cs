using System;
using Biblioteca;

namespace Encapsulamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libroUno = new Libro();
            libroUno[0]="Lord of a ring";
            libroUno[1] = "Lord of a";
            libroUno[2] = "Lord of";
            libroUno[3] = "Lord ";







            Console.WriteLine(libroUno[0]);
        }
    }
}
