using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Moto : VehiculoTerrestre
    {
        short cilindrada;

       
        public Moto(short cilindrada, short cantidadRuedas, short cantidadPuertas, EColores color) : base(cantidadRuedas, cantidadPuertas, color)
        {
            Cilindrada= cilindrada;
        }
        public  short Cilindrada
        {
            get
            {
                return cilindrada;
            }
            set
            { 
                this.cilindrada = value; 
            }
        }

    }
}
