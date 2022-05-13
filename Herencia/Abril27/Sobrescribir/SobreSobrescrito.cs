using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSobrescribir
{
    internal class SobreSobrescrito : Sobrescrito
    {
        public SobreSobrescrito()
        {
        }
        public override string MiPropiedad 
        {
            get
            {
                return this.miAtributo;
            }
        }
        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
