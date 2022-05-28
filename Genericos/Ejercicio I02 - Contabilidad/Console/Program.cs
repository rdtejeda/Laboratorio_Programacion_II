using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> egresos facturas - List<U> ingresos recibos new
            Contabilidad<Factura,Recibo> miContabilidad = new Contabilidad<Factura,Recibo>();
           
            Random rand = new Random();
            //string nombreFactura = "Factura-";
            //string recibo = "Recibo-";

            Factura factura1 = new Factura(rand.Next(1,int.MaxValue));
            Recibo recibo1 = new Recibo(rand.Next(1,int.MaxValue));
            miContabilidad.ListaEgresos.Add(factura1);
            miContabilidad.ListaIngresos.Add(recibo1);

            //if(miContabilidad.ListaEgresos+factura1 )
            //{

            //}
            string 
            Console.WriteLine("d");
        }
    }
}
