using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Provincial : Llamada
    {
        /// <summary>
        /// Tipo de valo Franja
        /// </summary>
        public enum Franja
        {
            Franja_1, Franmja_2, Franja_3
        }
        /// <summary>
        /// Atributo
        /// </summary>
        private Franja franjaHoraria;
        /// <summary>
        /// Constructor a base
        /// </summary>
        /// <param name="duracion"></param>
        /// <param name="destino"></param>
        /// <param name="origen"></param>
        public Provincial(string origen, Franja miFranja,float duracion,  string destino) : base (duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        /// <summary>
        /// Constructor a this
        /// </summary>
        /// <param name="miFranja"></param>
        /// <param name="llamada"></param>
        public Provincial (Franja miFranja, Llamada llamada) : this (llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        public float CostoLLamada 
        { 
            get
            {
                return CalcularCosto();
            }
        }
        /// <summary>
        ///  Mostrar retornará como texto todos los datos de la clase base y agregará el costo de la llamada y la franja horaria. Utilizar StringBuilder.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            return "";
        }
        /// <summary>
        /// será privado y retornará el valor de la llamada a partir de la duración y el costo de la misma. Los valores serán
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {
            float costoAux=0f;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costoAux = this.Duracion * 0.99f;
                    break;
                case Franja.Franmja_2:
                    costoAux = this.Duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    costoAux = this.Duracion * 0.66f;
                    break;
                default:
                    break;
            }            
            return costoAux;
        }        

    }
}
