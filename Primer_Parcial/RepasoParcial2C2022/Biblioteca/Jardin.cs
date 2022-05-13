using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public  class Jardin
    {
        public  enum Tipo {  Terrozo, Arenoso}

        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;

        static Jardin()
        {
            Jardin.suelo = Jardin.Tipo.Terrozo;
        }
        private Jardin()
        {
            this.plantas = new List<Planta>();
        }

        public Jardin(int espacioTotal)
            :this()
        {
            this.espacioTotal  = espacioTotal;
        }

        private int EspacioOcupado()
        {
            int espacioTotalOcupado = 0;
            foreach (Planta item in this.plantas)
            {
                espacioTotalOcupado += item.Tamanio;
            }
            return espacioTotalOcupado;
        }
        private int EspacioOcupado(Planta planta)
        {
            return this.EspacioOcupado() + planta.Tamanio;
        }
        public static bool operator +(Jardin j, Planta p)
        {
            if (j is not null && p is not null && j.espacioTotal >= j.EspacioOcupado(p) )
            {
                j.plantas.Add(p);
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Composicion del jardin {Jardin.suelo}");
            sb.AppendLine($"Espacio ocupado {this.EspacioOcupado()} de {this.espacioTotal}  ");
            sb.AppendLine("LISTA DE PLANTAS:");
            foreach (Planta item in this.plantas)
            {
                
                sb.AppendLine(item.ResumenDeDatos());
            }
            return sb.ToString();
        }




    }
}
