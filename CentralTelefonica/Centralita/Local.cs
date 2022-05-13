using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {
        private float costo;
        /// <summary>
        /// constuctor a Base
        /// </summary>
        /// <param name="duracion"></param>
        /// <param name="destino"></param>
        /// <param name="origen"></param>
        /// <param name="costo"></param>
        public Local( string origen,float duracion, string destino, float costo) : base (duracion,destino,origen)
        {
            this.costo = costo;
        }
        /// <summary>
        /// Constructor a Constructor
        /// </summary>
        /// <param name="llamada"></param>
        /// <param name="costo"></param>
        public Local(Llamada llamada, float costo) : this (llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
           
        }
        /// <summary>
        /// Prop devuelve el costo Llamada Local
        /// </summary>
        public float CostoLLamada
        {
            get
            {                
                return CalcularCosto();
            }
        }
        /// <summary>
        /// La propiedad CostoLlamada retornará el precio, que se calculará en el método CalcularCosto.
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {
            float costoLlamadaAux = this.costo * this.Duracion;
            return costoLlamadaAux;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Llamada.Mostrar());
            sb.AppendLine($"El costo de la llamada es : {CostoLLamada}");            
            return "";
        }
    }
}
