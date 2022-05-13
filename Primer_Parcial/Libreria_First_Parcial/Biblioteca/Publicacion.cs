using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        protected Publicacion(string nombre)
        {
            this.nombre = nombre;
        }
        protected Publicacion(string nombre,int stock) : this(nombre)
        {
            this.stock=stock;
        }
        protected Publicacion(string nombre, int stock, float importe) : this(nombre,stock)
        {
            this.importe=importe;
        }
        protected abstract bool EsColor { get; }

        public virtual bool HayStock 
        {
            get
            {
                if (this.stock > 0 && this.importe > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }                    
            }
        }
        public float Importe 
        { get
            {
                return this.importe;
            }
        }
        public int Stock
        { 
            get
            {
                return this.stock;
            }
            set
            {
                if (value>0)
                {
                    this.stock = value;
                }
            }
        }
        public string ObtenerInformacio()
        {
            string esColor = EsColor ? "SI" : "NO";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre : {this.nombre}");
            sb.AppendLine($"Stock : {Stock}");
            sb.AppendLine($"Es color : {esColor}");
            sb.AppendLine($"Valor : ${Importe}");

            return sb.ToString();
        }
        public override string ToString()
        {            
            return nombre; 
        }
    }
}
