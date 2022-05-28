using System;
using Biblioteca;

namespace ConsolaTorneos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Torneo de FUTBOL");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Torneo de BASQUET");
            Torneo<EquipoBasquet> torneoBasquet2 = new Torneo<EquipoBasquet>("BAD-Torneo de BASQUET");

            EquipoFutbol a = new EquipoFutbol("A",new DateTime(1912,12,24,0,2,23));
            EquipoFutbol b = new EquipoFutbol("B", new DateTime(1922, 1, 2,14,23,45));
            EquipoFutbol e = new EquipoFutbol("E", new DateTime(1913, 3, 4, 0, 2, 23));
            EquipoFutbol f = new EquipoFutbol("F", new DateTime(1822, 2, 23, 14, 23, 45));

            EquipoBasquet c = new EquipoBasquet("C", new DateTime(1932,4,20,12,45,34));
            EquipoBasquet d = new EquipoBasquet("D", new DateTime(1942, 12, 6, 13, 4, 4));
            EquipoBasquet g = new EquipoBasquet("G", new DateTime(532, 4, 20, 12, 45, 34));
            EquipoBasquet h = new EquipoBasquet("H", new DateTime(1542, 12, 6, 13, 4, 4));

           
            
            if (torneoFutbol + a && torneoFutbol+b && torneoFutbol +e && torneoFutbol +f)
            {
                Console.WriteLine(torneoFutbol.Mostrar());
            }

            if (torneoBasquet+c && torneoBasquet+d && torneoBasquet + g && torneoBasquet + h)
            {
                Console.WriteLine(torneoBasquet.Mostrar());
            }

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(torneoBasquet.JugarPartido);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(torneoBasquet.JugarPartido);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            try
            {
                bool opera = torneoBasquet2 + h;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(torneoBasquet2.Mostrar());
                    Console.WriteLine(torneoBasquet2.JugarPartido);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NoHayEquiposAnotadosException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }  
    }
}
