using System;
using System.Text;

namespace Biblioteca
{

    public class Conversor
    {
        public static int ConversorDecimalBinario(int numeroEntero)
        {
            int retorno=0;
            const int divisor = 2;
            int dividendo;
            int resultado;
            dividendo = numeroEntero;
            int extraerBinario;
            for (dividendo = numeroEntero; dividendo >= divisor;)
            {
                resultado= dividendo / divisor;
                extraerBinario = dividendo % divisor;                
            }
            return retorno;
        }
        public static int ConversorBinarioDecimal(int numeroDecimal)
        {
            int retorno = 0;

            return retorno;

        }
    }
    public class Validador
    {
        /// <summary>
        /// Validar que el valor ingresado este dentro del rango pedido
        /// </summary>
        /// <param name="valor">Valor a validar</param>
        /// <param name="min">Rango minimo del valor</param>
        /// <param name="max">Rango maximo del valor</param>
        /// <returns>True si esta dento del ranfo/returns>
        public static bool Validar(int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="respuesta">Valor de la respuesta</param>
        /// <returns>True si la respuesta es si(0)</returns>
        public static bool ValidarRespuesta(char respuesta)
        {
            bool retorno= false;
            if (respuesta =='S')
            {
                retorno=true;
            }
            return retorno;        }
    }
    public class ConversorDeTemperatura
    {
        private const float ceroAbsoluto = -273.15f;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="temperaturaCelcius"></param>
        /// <returns></returns>
        public static float ConversorDeCelciusAKelvin(float temperaturaCelcius)
        {
            return temperaturaCelcius - ceroAbsoluto;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="temperaturaKelvin"></param>
        /// <returns></returns>
        public static float ConversorDeKelvinacELCIUS(float temperaturaKelvin)
        {
            return temperaturaKelvin + ceroAbsoluto;
        }
    }
}
