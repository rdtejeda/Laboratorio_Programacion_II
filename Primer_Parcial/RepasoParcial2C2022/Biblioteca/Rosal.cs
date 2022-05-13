using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rosal : Planta
    {
        public enum Color { Roja, Blanca, Amarilla,Rosa,Azul }

        private Color florColor;

        public override bool TieneFlor 
        { 
            get
            { 
                return true;
            }
        }
        public override bool TieneFruto
        {
            get
            {
                return false;
            }
        }

        public Rosal(string nombre, int tamanio)
            :this(nombre, tamanio, Color.Rosa)
        {
            
        }
        public Rosal(string nombre, int tamanio, Color color)
            :base(nombre, tamanio)
        {
            this.florColor = color;
        }   

        public override string ResumenDeDatos()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ResumenDeDatos());
            sb.Append($"Tiene flor color {this.florColor}");

            return sb.ToString();
        }
    }
}
