using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;
        public CompetenciaNoDisponibleException()
        {
        }
        public CompetenciaNoDisponibleException(string message) : base(message)
        {
        }
        public CompetenciaNoDisponibleException(string nombreClase, string nombreMetodo, string message) : this(message)
        {
            this.nombreMetodo = nombreMetodo;
            this.nombreClase = nombreClase;
        }
        public CompetenciaNoDisponibleException(string nombreClase, string nombreMetodo, string message, Exception inner) : base(message,inner)
        {
            this.nombreMetodo = nombreMetodo;
            this.nombreClase = nombreClase;
        }
        public string NombreClase
        { 
            get
            {
                return this.nombreClase;
            }
        }
        public string NombreMetodo
        { 
            get
            {
                return this.nombreMetodo;
            }
        }
        public override string ToString()
        {
            //"Excepción en el método {0} de la clase {1}:"
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Excepción en el método {0} de la clase {1}.\n",NombreMetodo, NombreClase);
            //Mensaje propio de la excepción.
            sb.AppendFormat($"El Mensaje propio de la excepción es: '{Message}'\n");
            //Todos los InnerException con una tabulación(\t).
            Exception auxInner = this.InnerException;
            while (auxInner != null)
            {
                sb.AppendLine($"\t{auxInner.Message}");
                auxInner = auxInner.InnerException;                
            }
            return sb.ToString();
        }
    }
}
