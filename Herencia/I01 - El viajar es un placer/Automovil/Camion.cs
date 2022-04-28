using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Camion : VehiculoTerrestre
    {
       
        short cantidadMarchas;
        int pesoCarga;


        public Camion(short cantidadMarchas, int pesoCarga, short cantidadRuedas, short cantidadPuertas,EColores color) : base(cantidadRuedas,cantidadPuertas,color)
        {
            CantidadMarchas = cantidadMarchas;
            PesoCarga = pesoCarga;
        }
        public int PesoCarga
        { 
            get
            {
                return pesoCarga;
            }
            set
            {
                this.pesoCarga=value;   
            }
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
    }
}
