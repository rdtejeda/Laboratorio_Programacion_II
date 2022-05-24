using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;
        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {            
        }
        public MotoCross(short numero, string escuderia, short cilindrada):base(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }
        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.Cilindrada = value;
            }
        }
        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }
        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            bool retorno = false;
            if (m1 is not null && m2 is not null)
            {
                if ((VehiculoDeCarrera)m1 == (VehiculoDeCarrera)m2 && m1.Cilindrada==m2.Cilindrada)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Cilindrada : " + this.Cilindrada.ToString());
            //sb.AppendLine("Auto Numero " + this.Numero.ToString());
            //sb.AppendLine("Escuderia " + this.Escuderia);
            //sb.AppendLine("Vueltas restantes" + this.VueltasRestantes.ToString());
            return sb.ToString();
        }
    }
}
