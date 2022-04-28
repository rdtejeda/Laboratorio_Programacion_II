using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatro
{
    public class Espectador
    {
        int dni;
        string nombre;
        string numeroTelefonico;
        int cantidadEntradas;
        int codigoVenta;
        //constructores
        public Espectador()
        {
            cantidadEntradas = 1;
            codigoVenta = -1;
        }
        public Espectador(int dni, string nombre, string numeroTelefonico):this()
        {
            this.dni = dni;
            this.nombre = nombre;
            this.numeroTelefonico = numeroTelefonico;
        }
        public Espectador(int dni, string nombre, string numeroTelefonico,int cantidadEntradas):this(dni,nombre,numeroTelefonico)
        {
           this.cantidadEntradas = cantidadEntradas;
        }
        //propiedad get
        public int DniProp
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
        //prop vset magia de value
        public int CodigoVentaProp
        {
            set
            {
                if(value > 0)
                {
                    this.codigoVenta=value;
                }
            }
        }
        public string NumeroTelefonicoProp
        {
            get
            {
                return this.numeroTelefonico;
            }
            set
            {
                this.numeroTelefonico=value;
            }
        }
        //propfull
        /*
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        */
    }
}
