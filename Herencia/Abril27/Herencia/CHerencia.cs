using System;
using Entidades;
using System.Collections.Generic;

namespace Herencia
{
    internal class CHerencia
    {
        static void Main(string[] args)
        {
            Publicacion publicacion = new Publicacion("Guia de c", DateTime.Now);
            Libro libro = new Libro("rayuela","Cortazar", new DateTime(1966, 04, 12));
            Publicacion libro2 = new Libro("ronda", "Almodobar", new DateTime(1986, 08, 22));
            Revista revita = new Revista("Noticias", new DateTime(2005,05,13));

            libro.Precio= 234;
            //int v = 234;
            //(Libro)libro2 = v;

            List<Publicacion> listaDeLibros = new List<Publicacion>();
            listaDeLibros.Add(libro);
            listaDeLibros.Add(revita);
            listaDeLibros.Add(publicacion);

            foreach (Publicacion item in listaDeLibros)
            {
                Console.WriteLine(item.MostrarDatos());
            }

            Console.WriteLine("Hello World!");
            Console.WriteLine(  publicacion.MostrarDatos() );
            Console.WriteLine(libro.MostrarDatos());
            Console.WriteLine( revita.MostrarDatos());

            Imprimir(revita);
            Imprimir(libro);
            Imprimir(revita);
        }
        static void Imprimir(Publicacion p)
        {
            Console.WriteLine(p.MostrarDatos());
        }
    }
}
