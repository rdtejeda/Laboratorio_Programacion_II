using System;

namespace Teatro
{
    public class Teatro
    {
         string nombreTeatro;
         Espectador[] arrayEsp;

        public Teatro()
        {
            arrayEsp = new Espectador[20];
            nombreTeatro = "Colon";
        }
         public string NombreTeatroProp
         {
            get
            {
                return nombreTeatro;
            }
         }
        public Espectador[] ArrayEspProp
        {
            get 
            {
                return arrayEsp; 
            }
        }
        public Espectador this[int incice]
        {
            get 
            {
                return arrayEsp[incice]; 
            }
            set
            {
                this.arrayEsp[incice] = value;
            }
        }
        public Espectador this[string palabra]
        {
            get
            {
                foreach (Espectador item in arrayEsp)
                {
                    if (item.NumeroTelefonicoProp == palabra)
                    {
                        return item;
                    }
                }
                return null;
            }
        }
    }
}
