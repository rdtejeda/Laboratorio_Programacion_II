using System;
/*
Ejercicio I06 - Años bisiestos
Consigna
Escribir un programa que determine si un año es bisiesto.
Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos,
salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
IMPORTANTE
Utilizar sentencias de iteración, selectivas y el operador módulo (%).
*/
namespace I06AñosBisiestos
{
    internal class I06
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº6 - Años biciestos";
            Console.WriteLine("¡Vamos a calcular que años son biciestos!");
            //Pido años desde hasta
            string entrada;
            int desde;
            int hasta;
            Console.WriteLine("Ingrese desde que año");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out desde);            
            Console.WriteLine("Ingrese hasta que año");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out hasta);
            //Verifico consistencia de ingreso
            if (desde<hasta)
            {
                for (int i = desde; i <= hasta; i++)
                {
                    //Verifico multipo de 4
                    if (i%4==0)
                    {
                        //Verifico multplo de 100 pero no de 400
                        if (!((i%100==0)&&(!(i%400==0))))
                        {
                            Console.WriteLine("El año {0} es biciesto",i);
                        }                      
                    }
                }
            }
            else
            {
                Console.WriteLine("Desde debe ser menor que hasta");
            }
            Console.ReadKey();
        }
    }
}