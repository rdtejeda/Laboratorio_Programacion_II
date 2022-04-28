using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Libro
    {
        //Crear la clase Libro en una biblioteca de clases
        //y el código necesario para acceder a las páginas mediante un valor numérico.
        private List<string> paginas;

        public Libro()
        {
           
        }

        public Libro(List<string> paginas)
        {
            this.paginas = paginas;
        }

        public string this[int i]
        {
            //El descriptor de acceso get del indexador leerá la página pedida,
            //siempre y cuando el subíndice se encuentre dentro de un rango correcto,
            //sino retornará un string vacío.
            get
            {
                if (i>=0 && i<paginas.Count)
                {
                    return paginas[i];
                }
                return string.Empty;                 
            }
            //En el set, si la página existe(existe ese índice) le asignará el texto.
            //Si no existe (si el índice es superior al máximo existente),
            //agregará una nueva página.
            //Crear un proyecto de consola y probar la clase en el método Main.
            set
            {
                if (i >= 0)// && i < paginas.Count)
                {
                    paginas[i] = value;
                }
                if (i>paginas.Count)
                {
                    paginas.Add(value);
                }                
            }
        }
    }
}
