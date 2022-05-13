using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biografia : Publicacion
    {
        public Biografia(string nombre) : base(nombre)
        {
        }

        public Biografia(string nombre, int stock) : base(nombre, stock)
        {
        }

        public Biografia(string nombre, int stock, float importe) : base(nombre, stock, importe)
        {
        }

        protected override bool EsColor
        {
            get
            {
                return false;
            }
        }
        public bool HayStock 
        {
            get
            {
                if (this.Stock >0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static explicit operator Biografia(string nombre)
        {
            Biografia biografia = new Biografia(nombre);
            return biografia;
        }

    }
}
