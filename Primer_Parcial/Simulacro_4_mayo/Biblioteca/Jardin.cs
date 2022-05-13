using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    
    public class Jardin
    {
        public enum Tipo
        {
            Terrozo, Arenozo
        }
        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;

        static Jardin()
        {
            Jardin.suelo= Jardin.Tipo.Terrozo;
        }
        private Jardin()
        {
            this.plantas= new List<Planta>();
        }

        public Jardin(int espacioTotal) :this()
        {
            this.espacioTotal = espacioTotal;
        }
        public Tipo TipoSuelo 
        { 
            set
            {
               Jardin.suelo = value;
            }
        }
        public static bool operator +(Jardin jardin,Planta planta)
        {
            if (jardin is not null && planta is not null && jardin.espacioTotal >= jardin.EspacioOcupado(planta))
            {
                jardin.plantas.Add(planta);
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Composición del Jardin : {Jardin.suelo}");
            sb.AppendLine($"Espacio Ocupado {this.EspacioOcupado()} de {this.espacioTotal}");
            sb.AppendLine("Lista de Plantas");
            foreach (Planta planta in this.plantas)
            {
                sb.AppendLine(planta.ResumenDeDatos());
            }
            return sb.ToString();
        }
        private int EspacioOcupado()
        {
            int espacioOcupado = 0;
            foreach (Planta item in this.plantas)
            {
                espacioOcupado += item.Tamanio;
            }
            return espacioOcupado;
        }
        private int EspacioOcupado(Planta planta)
        {
            return this.EspacioOcupado()+planta.Tamanio;
        }

    }
}
