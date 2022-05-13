using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Centralita
    {
        /// <summary>
        /// Atributos
        /// </summary>
        List<Llamada> listaDeLlamadas;
        private string razoSocila;
        /// <summary>
        /// Constructor por ddrfecto
        /// </summary>
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        /// <summary>
        /// Construcctor con parametro
        /// </summary>
        /// <param name="nombreEmpresa"></param>
        public Centralita(string nombreEmpresa) : this()
        {
            this.razoSocila = nombreEmpresa;
        }
        /// <summary>
        /// Propiedad Get Lista
        /// </summary>
        public List<Llamada> Llamadas
        { 
            get
            {
                return this.listaDeLlamadas;
            }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;
            foreach (Llamada i in Llamadas)
            {               
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (i is Local)
                        {
                            ganancia +=((Local)i).CostoLLamada;
                        }

                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (i is Provincial)
                        {
                            ganancia += ((Provincial)i).CostoLLamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if(i is Local)
                        {
                            ganancia += ((Local)i).CostoLLamada;
                        }
                        else
                            {
                                ganancia += ((Provincial)i).CostoLLamada;
                            }
                        break;
                    default:
                        break;
                }
            }           
            return ganancia;
        }
        public string Mostrar()
        {
            return "";
        }
        public void OrdenarLlamadas()
        {

        }
    }
}
