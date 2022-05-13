using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // NotImplementedException
    public class Animal
    {
        public virtual string EmitirSonido() //virtual PUEDE cambiar su implementacion
        {
            return "Emitir sonido";
        }
        public string Pensar()
        {
            return "Estoy pensando";
          
        }
        //NO HACER
    }
    public class Perro : Animal
    {
        public override string EmitirSonido() //override cambia la implementacion
        {
            return "wooo";
        }
        public new string Pensar()
        {
            return "Que bueno es el SH";
        }

    }
    public class Gato : Animal
    {
        public override string EmitirSonido() //Overraide cambiar la implementacion
        {
            return "miau";
        }
        public new string Pensar()
        {
            return "Me voy de pase sin avisar";
        }
    }
    public class Gatito : Gato
    {
        public override string EmitirSonido() //Overraide cambiar la implementacion
        {
            return "miaucito";
        }
    }
   
}
