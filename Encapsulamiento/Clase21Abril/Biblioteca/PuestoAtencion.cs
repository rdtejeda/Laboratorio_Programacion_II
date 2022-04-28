using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Biblioteca
{
    internal class PuestoAtencion
    {
        public enum EPuesto
        {
            Caja1,
            Caja2,
        }
        private static int numeroActual;
        private EPuesto puesto;

        private PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(EPuesto puesto)
        {
            this.puesto = puesto;
        }
        public int NumeroActual
        {
            get
            { 
                numeroActual++;
                return numeroActual; 
            }    
        }
        ///El método Atender simulará un tiempo de atención a un cliente: recibirá un cliente, 
        ///simulará un tiempo de atención mediante el método Sleep de la clase Thread
        public bool Atender(Cliente cli)
        {
            bool retorno=false;

            Thread.Sleep(2000);

            return retorno;
        }
       




        /*
         * Thread.Sleep(2000);
    Agustin Cacciatori20:19
    using System.Threading;
         * */
    }
}
