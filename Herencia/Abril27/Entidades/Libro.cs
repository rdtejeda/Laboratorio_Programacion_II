using System;

namespace Entidades
{
    public class Libro : Publicacion
    {
        string autor;
        int precio;
        public Libro(string titulo, string autor, DateTime fechaPublicacion) : base(titulo, fechaPublicacion)
        {
            this.autor = autor;
           //falta precio
        }
        

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public new string MostrarDatos()
        {
            return $"{this.GetType().Name} Titulo: {this.fechaPublicacion} Autor: {this.autor} Fecha: {this.fechaPublicacion}";
        }
    }
}
