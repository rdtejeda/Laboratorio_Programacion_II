using System;

namespace Biblioteca
{
    public class Documento
    {
        private int numero;

        public Documento()
        {
        }
        public Documento(int numero)
        {
            this.numero = numero;
        }
        public int Numero
        { 
            get
            { 
                return this.numero;
            } 
            set 
            {
                this.numero=value;
            }
        }
    }
}
