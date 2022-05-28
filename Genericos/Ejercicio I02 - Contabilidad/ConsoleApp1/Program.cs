using System;
using System.IO;
using Biblioteca;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> egresos facturas - List<U> ingresos recibos new
            Contabilidad<Factura, Recibo> miContabilidad = new Contabilidad<Factura, Recibo>();

            Random rand = new Random();
            
            Factura factura1 = new Factura(rand.Next(1, int.MaxValue));
            Factura factura2 = new Factura(rand.Next(1, int.MaxValue));
           
            Recibo recibo1 = new Recibo(rand.Next(1, int.MaxValue));
            Recibo recibo2 = new Recibo(rand.Next(1, int.MaxValue));
            Recibo recibo3 = new Recibo(rand.Next(1, int.MaxValue));
            //ACA AGREGO CON ADD DIRECTAMENTE
            miContabilidad.ListaEgresos.Add(factura1);
            miContabilidad.ListaIngresos.Add(recibo1);
            miContabilidad.ListaIngresos.Add(recibo3);
            miContabilidad.ListaIngresos.Add(recibo2);
            //ACA QUIERO USAR SOBRECARGA +
            //if (miContabilidad.ListaEgresos + factura2)
            //{

            //}
            Console.WriteLine(miContabilidad.ListaEgresos.Count.ToString());
            Console.WriteLine(miContabilidad.ListaIngresos.Count.ToString());
        }
    }
}
