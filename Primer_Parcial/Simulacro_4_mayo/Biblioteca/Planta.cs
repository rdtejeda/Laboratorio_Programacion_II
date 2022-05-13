using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Biblioteca
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanio"></param>"
        public Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }
        public int Tamanio
        {
            get
            {
                return this.tamanio;
            }
        }
        protected abstract bool TieneFlores { get; }
        protected abstract bool TieneFruto { get; }
        /// <summary>
        /// datos de la Planta
        /// </summary>
        /// <returns></returns>
        public virtual string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"{this.nombre.ToUpper()} tiene un tamaño de {this.tamanio}");
            sb.AppendLine(string.Format("Tiene flores {0} ",TieneFlores ? "SI" : "NO"));
            sb.AppendLine(string.Format("Tiene frutos {0] ",TieneFruto ? "SI" : "NO"));                
            
            return sb.ToString();  
        }
    }
}
