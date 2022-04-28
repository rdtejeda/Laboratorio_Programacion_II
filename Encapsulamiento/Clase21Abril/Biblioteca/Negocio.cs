using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca
{
    internal class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        //El constructor privado inicializará la colección y el puesto de atención como Caja1.
        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.EPuesto.Caja1);
            this.clientes=new Queue<Cliente>();
        }
        public Negocio(string nombre)
        {
            if(nombre == null)
            {
                this.nombre = nombre;
            }
            
        }

        //La propiedad Cliente retornará el próximo cliente en la cola de atención en el get.
        //El set deberá controlar que el Cliente no figure en la cola de atención, caso contrario lo agregará.
       
        /*
        public Cliente Cliente
        {
            //get
            {
                //return De ;
            }
            //set 
            { 
                //this.caja = 
            }
            //palabras = new List<string>() { "Chau", "Bye", "Ciao" };
       // }*/

    }
}
