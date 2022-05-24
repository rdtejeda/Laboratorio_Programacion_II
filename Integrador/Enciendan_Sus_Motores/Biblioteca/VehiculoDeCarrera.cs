using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera()
        {
            this.CantidadCombustible = 0;
            this.VueltasRestantes = 0;
            this.EnCompetencia = false;
        }
        public VehiculoDeCarrera(short numero, string escuderia):this()
        {
            this.escuderia = escuderia;
            this.numero = numero;
        }
        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }
        public bool EnCompetencia
        {
            get
            {
                return this.EnCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }
        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }
        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Vehiculo Numero " + this.Numero.ToString());
            sb.AppendLine("Escuderia " + this.Escuderia);
            sb.AppendLine("Vueltas restantes" + this.VueltasRestantes.ToString());
            return sb.ToString();
        }
        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            bool retorno = false;
            if (v1 is not null && v2 is not null)
            {
                if (v1.Numero == v2.Numero && v1.Escuderia == v2.Escuderia)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}
