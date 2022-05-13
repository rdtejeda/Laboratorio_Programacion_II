using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Persona
    {
        /// <summary>
        /// Atrubutos de clase Base
        /// </summary>
        protected string apellido;        
        protected string barrioRecidencia;
        protected DateTime nacimiento;
        protected string nombre;
        /// <summary>
        /// Inicilaiza una nueba instancia de Persona usando los parametro recibidos.
        /// </summary>
        /// <param name="nombre">Nombre</param>
        /// <param name="apellido">Apellido</param>
        /// <param name="nacimiento">Fecha Nacimiento</param>
        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nacimiento = nacimiento;
            this.nombre = nombre;
            this.apellido=apellido;
        }
        /// <summary>
        /// Inicilaiza una nueba instancia de Persona invocando a constructor usando los parametro recibidos.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacimiento"></param>
        /// <param name="barrioRecidencia"></param>
        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia)
            : this (nombre, apellido, nacimiento)
        {
            this.barrioRecidencia = barrioRecidencia;            
        }
        /// <summary>
        /// Prpiedad Edad devuelve la edad actual de la Persona 
        /// </summary>
        public int Edad 
        { 
            get
            {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }
        }
        /// <summary>
        /// Propiedad Retorna el nombre completo de la persona con el formato Apellido, Nombre.
        /// </summary>
        public string NombreCompleto 
        {
            get
            {
                return string.Format("{0}, {1}", this.apellido, this.nombre);
            }
        }
        /// <summary>
        /// Sobrecarga de ToStrin develve el Propieda Nombre Completo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return NombreCompleto;
        }
        /// <summary>
        /// Retorna un string de la ficha con todos los datos del objeto instanciado
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(p.NombreCompleto);
            sb.AppendLine($"EDAD: {p.Edad}");
            sb.AppendLine(p.FichaExtra());

            return sb.ToString();
        }
        /// <summary>
        /// Metodo abstarco para Sobreescribir en clases derivadas
        /// Resto de la informacion especifica del Objeto
        /// </summary>
        /// <returns></returns>
        abstract internal string FichaExtra();
    }
}