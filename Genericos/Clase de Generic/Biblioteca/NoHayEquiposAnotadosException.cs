using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class NoHayEquiposAnotadosException : Exception
    {
        public NoHayEquiposAnotadosException()
        {
        }

        public NoHayEquiposAnotadosException(string message) : base(message)
        {
        }

        public NoHayEquiposAnotadosException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoHayEquiposAnotadosException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
