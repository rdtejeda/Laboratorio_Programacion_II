using System;
using System.Text;
/*
 *Consigna
Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

public string ConvertirDecimalABinario(int numeroEntero) {}

El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

public int ConvertirBinarioADecimal(int numeroEntero) {}

IMPORTANTE
NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.
 */

namespace I03ConversorBinario
{
    internal class I03
    {
        static void Main(string[] args)
        {
            int numeroEntero = 1; //10111  231 11100111            
            int retorno = 0;
            const int divisor = 2;
            int dividendo;
            int resultado;
            dividendo = numeroEntero;
            int extraerBinario;
            StringBuilder numeroBinario;
            numeroBinario = new StringBuilder();
            char inicio = ' ';
            string extraer;
            for (dividendo = numeroEntero; dividendo >= divisor;)
            {
                resultado = dividendo / divisor;
                extraerBinario = dividendo % divisor;
                numeroBinario=ArmarBinario(numeroBinario, extraerBinario);
               // numeroBinario.Append(extraerBinario);
                if (dividendo==divisor)
                {
                    numeroBinario.Append("1");  
                }
                dividendo = resultado;               
            }
            Console.WriteLine($"{numeroBinario}");
        }
        static StringBuilder ArmarBinario(StringBuilder sb, int extraerBinario)
        {
           sb.Append(extraerBinario);

            return sb;

        }
    }
}
