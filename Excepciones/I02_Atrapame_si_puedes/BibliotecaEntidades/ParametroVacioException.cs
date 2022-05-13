using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public class ParametroVacioException : Exception
    {
        /// <summary>
        /// Mi primer Excepcion por datos vacios
        /// </summary>
        /// <param name="message"></param>
        public ParametroVacioException(string message) : this(message,null)
        {
        }
        public ParametroVacioException(string message, Exception innerException) : base(message, innerException)
        {            
        }
    }
}
