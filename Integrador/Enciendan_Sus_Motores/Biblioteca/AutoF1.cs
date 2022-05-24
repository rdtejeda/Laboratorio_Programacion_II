using System;
using System.Text;

namespace Biblioteca
{
    public class AutoF1 : VehiculoDeCarrera
    {
        //private short cantidadCombustible;
        //private bool enCompetencia;
        //private string escuderia;
        //private short numero;
        //private short vueltasRestantes;
        private short caballosDeFuerza;
        public AutoF1():base()
        {

        }
        public AutoF1(short numero, string escuderia) :base(numero,escuderia)
        {
            //this.CantidadCombustible = 0;
            //this.VueltasRestantes = 0;
            //this.EnCompetencia = false;
        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : base(numero,escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;           
            //this.escuderia = escuderia;
            //this.numero = numero;
        }

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza=value; 
            }
        }   
        
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Caballos de fuerza : " + this.CaballosDeFuerza.ToString());
            //sb.AppendLine("Auto Numero " + this.Numero.ToString());
            //sb.AppendLine("Escuderia " + this.Escuderia);
            //sb.AppendLine("Vueltas restantes" + this.VueltasRestantes.ToString());
            return sb.ToString();
        }
        public static bool operator !=(AutoF1 a1,AutoF1 a2)
        {
            return !(a1==a2); 
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;
            if(a1 is not null && a2 is not null)
            {
                if((VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 && a1.CaballosDeFuerza == a2.CaballosDeFuerza)
                {
                    retorno = true;
                }                
            }
            return retorno;
        }
    }
}
