using System;

namespace Animal
{
    public class Animales
    {
        int id;
        string nombre;

        public Animales(string nombre)
        {
            this.nombre = nombre;
        }

        public Animales(int id, string nombre):this(nombre)
        {
            this.id = id;           
        }
    }

}
