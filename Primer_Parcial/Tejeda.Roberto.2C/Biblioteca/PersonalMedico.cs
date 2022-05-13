using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PersonalMedico : Persona
    {
        /// <summary>
        /// Atributos clase derivada PersonalMedico
        /// </summary>
        private List<Consulta> consultas;
        private bool esResidente;
        /// <summary>
        /// Inicilaiza una nueba instancia de PersonalMedico usando los parametro recibidos y el constructor de la base.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacimiento"></param>
        /// <param name="esResidente"></param>
        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente)
            : base(nombre, apellido, nacimiento)
        {
            this.consultas = new List<Consulta>();
            this.esResidente = esResidente;
        }
        /// <summary>
        /// Retorna un string con el resto de la ficha del objeto PersonalMedico instanciado
        /// </summary>
        /// <returns></returns>
        internal override string FichaExtra()
        {
            StringBuilder sb =  new StringBuilder();
            sb.AppendLine(string.Format("Finalizo residencia {0}", this.esResidente ? "SI" : "NO"));
            sb.AppendLine("ATENCIONES :");
            foreach (Consulta item in consultas)
            {
                sb.AppendLine(Persona.FichaPersonal(item.Paciente));
            }
            return sb.ToString();
        }
        /// <summary>
        /// Agregará nuevas consultas a la lista, tomando como fecha de inicio de la misma el método Now de la clase DateTime
        /// </summary>
        /// <param name="doctor">PersonalMedico</param>
        /// <param name="paciente">Paciente</param>
        /// <returns>Una Consulta</returns>
        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta nuevaConsulta = null;
            if (doctor is not null && paciente is not null)
            {
                nuevaConsulta= new Consulta(DateTime.Now, paciente);
                doctor.consultas.Add(nuevaConsulta);
            }
            return nuevaConsulta;           
        }
    }
}
