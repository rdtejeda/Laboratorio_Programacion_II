using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSobrescribir
{
    internal class Sobrescribir
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Sobre-Sobrescrito";
           
            Sobrescrito objetoSobrescrito = new SobreSobrescrito();

            Console.WriteLine(objetoSobrescrito.ToString());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());

            Console.WriteLine("----------------------------------------------");
            Console.Write("Metodo y Propiedad Con Herencia Polimorfica");
            Console.WriteLine($"\nValor de miAtributo : {objetoSobrescrito.MiMetodo()}");

            Console.ReadKey();
        }
    }
}
