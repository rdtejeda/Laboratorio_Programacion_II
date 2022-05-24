using System;
using System.Runtime.Serialization;

namespace Biblioteca
{
    [Serializable]
    public class NegativoNoPermitidoException : Exception
    {
        public NegativoNoPermitidoException()
        {
        }
        public NegativoNoPermitidoException(string message) : base(message)
        {
        }
    }
}