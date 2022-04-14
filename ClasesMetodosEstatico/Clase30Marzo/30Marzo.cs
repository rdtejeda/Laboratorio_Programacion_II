using System;
using System.Text;
using Biblioteca;

namespace Clase30Marzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string texto = "Hola ";
            texto += "Mundo"; // == texto=texto+"Mundo)
            Console.WriteLine(texto);
            string mensaje =$"El valor agregado es '{texto}'";
            string mensajeDos = string.Format("El texto copiado es '{0}'",mensaje); 
            Console.WriteLine(mensajeDos);
            float temperaturaEnCelcius = 25;
            Console.WriteLine("{0}ºC Equivalen a {1}ºK",temperaturaEnCelcius, ConversorDeTemperatura.ConversorDeCelciusAKelvin(temperaturaEnCelcius));
            */
                        string comision = "2ºC";
            int anio = 2022;

            StringBuilder sb = new StringBuilder();
            sb.Append("Hola");
            sb.AppendLine($" Mundo {Environment.NewLine}");
            sb.Append("Programacion II");
            sb.AppendLine(" Y lABORATORIO II");
            sb.AppendFormat("Comisión {0}, año {1}", comision,anio);

            Console.WriteLine(sb.ToString());

            int multiplo;
            string entrada;
            Console.WriteLine("Ingrese un numero erntero");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out multiplo);


            Console.WriteLine(TablaMultiplicacio(multiplo));

        }
        static string TablaMultiplicacio(int numero)
        {
            int resultado;
            StringBuilder impresion = new StringBuilder();
            for (int i = 1; i <= 10; i++)
            {
                resultado = i * numero;
                impresion.AppendLine($"{numero} x {i} = {resultado}");  
            }
            return impresion.ToString();
        }
    }
}
