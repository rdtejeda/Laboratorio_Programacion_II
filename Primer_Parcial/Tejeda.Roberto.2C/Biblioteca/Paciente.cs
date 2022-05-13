using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Paciente : Persona
    {
        /// <summary>
        /// Tipo de Valor Enum con el Diagnostico del paciente
        /// </summary>
        public enum Diagnostico
        {
            Curado, Gripe, Covid
        }
        /// <summary>
        /// Atributo clase derivada Paciente
        /// </summary>
        public Diagnostico diagnostico;
        /// <summary>
        /// Inicilaiza una nueba instancia de Peciente usando los parametro recibidos y el constructor de la base.
        /// </summary>
        /// <param name="nombre">Nombre</param>
        /// <param name="apellido">Apellido</param>
        /// <param name="nacimiento">Fecha Nacimiento</param>
        /// <param name="barrioRecidencia">Barrio</param>
        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia) : base(nombre, apellido, nacimiento, barrioRecidencia)
        {
        }
        /// <summary>
        /// Propiedad que Devuelve/Setea valor del tipo enum Diagnostico
        /// </summary>
        public Diagnostico PDiagnostico        { 
            get
            {
                return this.diagnostico;
            }
            set
            {
                this.diagnostico = value;
            }
        }
        /// <summary>
        /// Retorna un string con el resto de la ficha del objeto Paciente instanciado
        /// </summary>
        /// <returns></returns>
        internal override string FichaExtra() //protected internal
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Recide en : {this.barrioRecidencia}");
            sb.AppendLine($"Diagnostico : { this.diagnostico}");

            return sb.ToString();
        }
    }
}
