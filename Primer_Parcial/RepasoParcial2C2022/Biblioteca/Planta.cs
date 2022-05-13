using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;


        public int Tamanio
        {
            get { return tamanio; }
        }
        public abstract bool TieneFlor { get; }
        public abstract bool TieneFruto { get; }

        public Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }
        /// <summary>
        /// retorna los datos de la planta
        /// </summary>
        /// <returns></returns>
        public virtual string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.nombre.ToUpper()} tiene un tamaño de {this.Tamanio}");
            sb.AppendLine(string.Format("Tiene Flores {0}", this.TieneFlor ? "SI" : "NO" ));
            sb.AppendLine(string.Format("Tiene Fruto {0}", this.TieneFruto ? "SI" : "NO" ));

            return sb.ToString();
        }
    }
}
