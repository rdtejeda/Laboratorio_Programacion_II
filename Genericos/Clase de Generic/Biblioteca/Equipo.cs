using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        protected Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }
        /// <summary>
        /// Propiedad que retorna el atributo nombre de Equipo
        /// </summary>
        public string Nombre { get { return nombre; } }
        /// <summary>
        /// Propiedad que retorna la fecha de creacion del Equipo
        /// </summary>
        public DateTime FechaCreacion { get { return fechaCreacion; } }
        /// <summary>
        /// Recarga de operador ==
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns> Si Dos equipos comparten el mismo nombre y fecha de creación retorna true</returns>
        public static bool operator ==(Equipo e1, Equipo e2)
        {
            bool retorno = false;
            if(e1 is not null && e2 is not null)
            {
                if (e1.Nombre==e2.Nombre && e1.FechaCreacion==e2.FechaCreacion)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Recarga de operador !=
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns> Si Dos equipos no comparten el mismo nombre y fecha de creación retorna true</returns>
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1==e2);
        }
        /// <summary>
        /// Ficha retornará el nombre del equipo y su fecha de creación
        /// </summary>
        /// <returns></returns>
        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("EQUIPO {0} fundado el {1}",Nombre,FechaCreacion.ToString());
            return sb.ToString();
        }
    }
}
