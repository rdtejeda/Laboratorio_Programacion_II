using System;


namespace Entidades
{
    public enum EPelaje
    {
        SinPelo =0,
        Corto = 150,
        Mediano = 240,
        Largo = 500,
    }

    public class Animal
    {
        
        int id;
        string nombre;
        int peso;
        EPelaje pelaje;

        const string nombreName = "Yo";
        public Animal(string nombre, EPelaje pelaje)
        {
            this.nombre = nombre;
            this.pelaje = pelaje;
        }

        public Animal(int id, string nombre) : this(nombre)
        {
            this.Id = id;
        }
        //propfull

  

        public int PrecioCorte
        {
            get 
            { 
                return (int)pelaje; //casteo el valor de Epelaje a su nenumerado
            }

            //set { myVar = value; }
        }

        public int Id
        {
            get 
            { 
                return id; 
            }
            set
            {
                id = value;
            }
            /*            
            private set
            {
                if (value>0)
                {
                    
                }                
            }
            */
        }
        public string  Nombre
        {
            get { return nombre; }
            set //en la propiedad puede ser algo privado
            {
                nombre = value;
            }
        }
    }
}
