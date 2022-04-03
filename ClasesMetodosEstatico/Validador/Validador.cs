using System;

namespace Biblioteca
{
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
        public static bool ValidarRespuesta(int respuesta)
        {
            return respuesta == 0;
        }
    }
}
