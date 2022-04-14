using System;

namespace Bibioteca
{
    /// <summary>
    ///  Objeto Sumados y sus atributos
    /// </summary>
    public class Sumador
    {
        private int cantidadSumas; //Atributo

        /// <summary>
        ///  inicializa cantidadSumas en el valor recibido por parámetro.
        /// </summary>
        /// <param name="cantidadSumas">Valor recibido por parametro</param>
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        /// <summary>
        ///  inicializa cantidadSumas en cero. Reutiliza el primer constructor.
        /// </summary>
        public Sumador():this(0)
        {
            // Sumador(0);
        }
        /// <summary>
        ///  Incrementará cantidadSumas en 1  y adicionará sus parámetros
        /// </summary>
        /// <param name="uno">Valor a unoa sumar</param>
        /// <param name="dos">Valor dos a sumar</param>
        /// <returns></returns>
        public long Sumar(long uno, long dos)
        {
            this.cantidadSumas++;
            return uno + dos;
        }
        /// <summary>
        /// Sobrecarga de metodo sSumar
        /// Incrementará cantidadSumas en 1  y adicionará sus parámetros
        /// </summary>
        /// <param name="uno">Valor uno a sumar</param>
        /// <param name="dos">Valor dos a sumar</param>
        /// <returns></returns>
        public string Sumar(string uno, string dos)
        {
            this.cantidadSumas++;
           // return uno + dos;
            return String.Format(uno + dos);
        }
        /// <summary>
        /// Obtiene el valor del atributo cantidad de sumas 
        /// de un objeto Sumador
        /// </summary>
        /// <returns></returns>
        public int GetCantidadDeSumas()
        {
            return this.cantidadSumas;
        }
        /// <summary>
        /// Genero conversión explícita que retorne cantidadSumas
        /// </summary>
        /// <param name="sumador"></param>
        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
            //return sumador.GetCantidadDeSumas();
        }
        /// <summary>
        /// Sobrecargar el operador + (suma).
        /// El resultado long suma del atributo cantidadSumas de cada argumento.
        /// </summary>
        /// <param name="sumadorUno">Objeto uno</param>
        /// <param name="sumadorDos">Objeto dos</param>
        /// <returns></returns>
        public static long operator +(Sumador sumadorUno, Sumador sumadorDos)
        {
            return sumadorUno.cantidadSumas + sumadorDos.cantidadSumas;
        }
        /// <summary>
        /// Sobrecargar el operador | (pipe) .
        /// Retornar true si ambos sumadores tienen igual valor en el atributo cantidadSumas.
        /// </summary>
        /// <param name="sumadorUno"></param>
        /// <param name="sumadorDos"></param>
        /// <returns></returns>
        public static bool operator |(Sumador sumadorUno, Sumador sumadorDos)
        {
            //return sumadorUno.cantidadSumas==sumadorDos.cantidadSumas;
            bool result = false;
            if(sumadorUno.cantidadSumas == sumadorDos.cantidadSumas)
            {
                result = true;
            }
            return result;
        }
    }
}
