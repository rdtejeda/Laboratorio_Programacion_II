using System;
using System.Text;

namespace Centralita
{
    public class Llamada
    {
        /// <summary>
        /// Tipo de valor Tipo de LLamada
        /// </summary>
        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }
        /// <summary>
        /// Atributos
        /// </summary>
        private float duracion;
        private string nroDestino;
        private string nroOrigen;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="duracion"></param>
        /// <param name="nroDestino"></param>
        /// <param name="nroOrigen"></param>
        protected Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        /// <summary>
        /// Prop Duracion
        /// </summary>
        public float Duracion
        {
            get
            {
               return this.duracion;
            }
        }
        /// <summary>
        /// Prop Numero de destino
        /// </summary>
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        /// <summary>
        /// Prop Numero de Origen
        /// </summary>
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El origen de la llamada fue : {this.NroOrigen}");
            sb.AppendLine($"El destino de llamada fue : {this.NroDestino}");
            sb.AppendLine($"La duración de llamada fue :´{this.Duracion.ToString()}");
            return sb.ToString();
        }
        public int OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
        {
            
            return 0;
        }
    }
}
