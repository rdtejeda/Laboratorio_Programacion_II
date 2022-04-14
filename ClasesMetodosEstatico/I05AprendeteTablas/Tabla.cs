using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I05AprendeteTablas
{
    internal class Tabla
    {        public static StringBuilder LaTabla(int multiploUno)
        {
            StringBuilder sb = new StringBuilder();
            int resultado;
            for (int i = 1; i <= 9; i++)
            {
                resultado = multiploUno * i;
                sb.Append(multiploUno.ToString());
                sb.Append(" X ");
                sb.Append(i.ToString());
                sb.Append(" = ");
                sb.Append(resultado.ToString());
                sb.AppendLine();
            }
            return sb;
        }
    }
}
