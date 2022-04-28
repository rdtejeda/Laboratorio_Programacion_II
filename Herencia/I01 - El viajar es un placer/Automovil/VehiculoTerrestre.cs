using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum EColores
    {
        Rojo,
        Blanco,
        Azul,
        Gris,
        Negro,
    }
    public class VehiculoTerrestre
    {
        short cantidadRuedas;
        short cantidadPuertas;
        EColores color;
        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, EColores color)
        {
            CatidadRuedas = cantidadRuedas;
            CantidadPuertas=cantidadPuertas;
            Color = color;
        }
        public short CatidadRuedas 
        { 
            get
            {
                return cantidadRuedas;
            }
            
            set
            {
                if (value >=2)
                {
                    cantidadRuedas = value;
                }                
            }                
        }
        public short CantidadPuertas
        {
            get
            {
                return cantidadPuertas;
            }
            set
            {
                if(value>=1)
                {
                    cantidadPuertas = value;
                }               
            }
        }        
        public EColores Color
        {
            get
            {
                return color;
            }
            set
            {
                if(value>=EColores.Rojo || value <=EColores.Negro)
                {
                    color = value;
                }
            }
        }
    }
}
