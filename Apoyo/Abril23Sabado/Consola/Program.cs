using System;
using Entidades;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal(232,"Pepep");
            //animal.Id = 15; NOOOOOOOOOO porque ahora el set es private
            //animal.id = 12; no mas
            Console.WriteLine($"El id del animal es {animal.Id}");
        }
    }
}
