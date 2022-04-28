using System;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente()
        {
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(string nombre, int numero)
        {
            this.nombre = nombre;
            this.numero = numero;
        }

        public string Nombre
        {
            get
            { return this.nombre; }
            set
            {
                this.nombre = value;
            }
        }
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }
        public static bool operator != (Cliente c1, Cliente c2)
        {
            bool retorno=false;
            if (c1.Numero != c2.Numero)
            {
                retorno=true;
            }
            return retorno;
        }
        public static bool operator == (Cliente c1, Cliente c2)
        {
            bool retorno = false;
            if (c1.Numero == c2.Numero)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
