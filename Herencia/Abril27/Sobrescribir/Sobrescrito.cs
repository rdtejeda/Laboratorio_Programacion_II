using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSobrescribir
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;
        public Sobrescrito()
        {
           miAtributo= "Probar abstractos";
        }
        public abstract string MiPropiedad { get;}
        public abstract string MiMetodo();

        public override string ToString()
        {
            return "Este es mi metodo ToString sobrecargado";
        }
        public override bool Equals(object obj)
        {
            return obj.GetType() == base.GetType();
        }
        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
