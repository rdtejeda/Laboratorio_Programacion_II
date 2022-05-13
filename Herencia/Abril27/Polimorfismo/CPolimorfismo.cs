using System;
using Entidades;

namespace Polimorfismo
{
    internal class CPolimorfismo
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();   
            Perro perro = new Perro();
            Gato gato = new Gato();
            
            Animal gato2 = new Gato();
            Animal perro2= new Perro();
            Animal gato3 = gato2;
            //Object
            Console.WriteLine(gato2.Equals(gato3));///compara direccion de memoria
            Console.WriteLine(gato2.GetHashCode());///devuelve codig has unico

            Console.WriteLine("Herencia polimorifica (virtual)------");
            Console.WriteLine(animal.EmitirSonido());
            Console.WriteLine(perro.EmitirSonido());
            Console.WriteLine(gato.EmitirSonido());
            Console.WriteLine("---------------------");
            Console.WriteLine(perro2.EmitirSonido());
            Console.WriteLine(gato2.EmitirSonido());

            Console.WriteLine("Herencia no polimorifica (new)------");

            Console.WriteLine(animal.Pensar());
            Console.WriteLine(perro.Pensar());
            Console.WriteLine(gato.Pensar());
            Console.WriteLine("---------------------");
            Console.WriteLine(((Perro)perro2).Pensar());
            Console.WriteLine(perro2.Pensar());
            Console.WriteLine(((Gato)gato2).Pensar());
            Console.WriteLine(gato2.Pensar());
        }
    }
}
