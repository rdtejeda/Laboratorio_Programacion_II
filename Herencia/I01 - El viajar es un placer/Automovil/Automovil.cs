using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Automovil : VehiculoTerrestre
    {
        short cantidadMarchas;
        int cantidadPasajeros;

        public Automovil(short cantidadMarchas, int cantidadPasajeros, short cantidadRuedas, short cantidadPuertas, EColores color) : base(cantidadRuedas, cantidadPuertas, color)
        {
            CantidadMarchas = cantidadMarchas;
            CantidadPasajeros = cantidadPasajeros;
        }
        public short CantidadMarchas
        {
            get
            {
                return cantidadMarchas; 
            }
            set
            {
                this.cantidadMarchas = value;
            }
        }
        public int CantidadPasajeros
        {
            get
            {
                return cantidadPasajeros;
            }
            set
            {
                this.cantidadPasajeros=value;
            }
        }
    }
}
