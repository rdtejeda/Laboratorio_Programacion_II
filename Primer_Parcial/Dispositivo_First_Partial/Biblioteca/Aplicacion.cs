using System;
using System.Text;
using System.Collections.Generic;
{

}
/*
La sobrecarga del operador == buscará si una aplicación existe en la lista recibida por parámetro comparando por su nombre. Devolverá true si ya existe.
La sobrecarga del operador + añadirá una aplicación a la lista de aplicaciones pasada por parámetro siempre y cuando sea no exista previamente. Reutilizar código.
 */

namespace Biblioteca
{
    public abstract class Aplicacion // * Clase Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }
        public SistemaOperativo SistemaOperativo
        {
            get
            {
                return this.sistemaOperativo;
            }
        }
        /// <summary>
        /// Las propiedades marcadas en cursiva son abstractas.
        /// </summary>
        protected abstract int Tamanio { get; } 
        
        /// <summary>
        /// El método ObtenerInformacionApp retornará los datos de la aplicación utilizando StringBuilder.
        /// </summary>
        /// <returns></returns>
        public string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.nombre);
            sb.AppendLine(this.SistemaOperativo.ToString());
            sb.AppendLine(this.Tamanio.ToString());

            return sb.ToString();
        }
        /// <summary>
        /// El método ToString devolverá el nombre de la aplicación.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.nombre;
        }
        /// <summary>
        /// El operador implícito recibirá una lista de aplicaciones y devolverá
        /// la instancia de la aplicación que más tamaño tenga.
        /// </summary>
        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            int mayorTamanio = int.MinValue;
            Aplicacion aplicacionMasPesada=null;
            foreach (Aplicacion item in listaApp)
            {
                if(item.Tamanio>mayorTamanio)
                {
                    mayorTamanio = item.Tamanio;
                    aplicacionMasPesada = item;
                }
            }
            return aplicacionMasPesada;
        }
    }
}
