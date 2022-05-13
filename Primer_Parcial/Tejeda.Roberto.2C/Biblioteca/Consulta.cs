using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Consulta
    {
        /// <summary>
        /// Atributos de la clase Consulta
        /// </summary>
        private DateTime fecha;
        private Paciente paciente;
        /// <summary>
        /// Inicilaiza una nueba instancia de Consulta usando los parametro recibidos.
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="paciente"></param>
        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }
        /// <summary>
        /// Propiedad Fecha devuelve Fecha de la consulta
        /// </summary>
        public DateTime Fecha 
        { 
            get
            {
                return this.fecha;
            }
        }
        /// <summary>
        /// Prop PAciente devuelve el Objeto pacienete de la consulta
        /// </summary>
        public Paciente Paciente
        {
            get
            {
                return this.paciente;
            }
        }
        /// <summary>
        /// Sobrecarga de ToString que devuelve concatenado Fecha y Pacienete atendido.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Fecha:{this.Fecha} Se ha atendido a: {paciente.ToString()}");
           
            return sb.ToString();
        }  
    }
}
