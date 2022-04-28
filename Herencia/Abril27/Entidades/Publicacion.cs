using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Publicacion
    {
        public string titulo;
        public DateTime fechaPublicacion;
       
        public Publicacion(string titulo, DateTime fechaPublicacion)
        {
            this.titulo = titulo;
            this.fechaPublicacion = fechaPublicacion;
        }

        // propfull tab tab
       
        public string MostrarDatos()
        {
            return $"{this.GetType().Name} Titulo: {this.fechaPublicacion} Fecha: {this.fechaPublicacion}";
        }
    }
}
