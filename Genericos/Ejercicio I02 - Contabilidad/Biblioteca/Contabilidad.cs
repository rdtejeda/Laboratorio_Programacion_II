using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Contabilidad<T,U>
        where T : Factura
        where U : Recibo, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }
        public List<T> ListaEgresos { get { return this.egresos; } }
        public List<U> ListaIngresos { get { return this.ingresos; } }
        public static bool operator +(Contabilidad<T,U> c,T egresoFactura)
        {
            bool retotno = false;
            if (c.egresos is not null)
            {
                c.egresos.Add(egresoFactura);
                retotno = true;
            }

            return retotno;
        }
        public static bool operator +(Contabilidad<T,U> c, U ingreosoRecibo)
        {
            bool retotno = false;
            if (c.ingresos is not null)
            {
                c.ingresos.Add(ingreosoRecibo);
                retotno=true;
            }

            return retotno;
        }
    }
}
