using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum ETipoCompetencia
    {
        F1,
        MotoCross
    }
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private ETipoCompetencia tipo;

        public Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, ETipoCompetencia tipo) :this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }
        public List<VehiculoDeCarrera> ListaVehiculosDeCarrera 
        {
            get
            {
                return competidores;
            }
            
        }
        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }
        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }  
            set { this.cantidadVueltas = value; }   
        }
        public ETipoCompetencia TipoCompetencia
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        public VehiculoDeCarrera this[int i] 
        { 
            get { return this.competidores[i]; }
            
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------COMPETENCIA--------");
            sb.AppendLine("Capacidad de COMPETIDORES: " + this.cantidadCompetidores);
            sb.AppendLine("Cantidad de Vueltas: "+this.cantidadVueltas);
            sb.AppendLine("Tipo de competencia: "+this.TipoCompetencia.ToString());
            sb.AppendLine("-----------------------------");
            foreach (VehiculoDeCarrera v in this.competidores)
            {
                if (v.GetType()==typeof(AutoF1))
                {
                    sb.AppendLine(((AutoF1)v).MostrarDatos());
                    sb.AppendLine("*****************************");
                }else if(v.GetType() == typeof(MotoCross))
                {
                    sb.AppendLine(((MotoCross)v).MostrarDatos());
                    sb.AppendLine("*****************************");
                }
            }
            return sb.ToString();
        }
        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            bool retorno = false;
            try
            {
                if((c.competidores.Count < c.cantidadCompetidores) && !(c==v) )
                {
                    c.competidores.Add(v);
                    v.EnCompetencia = true;
                    v.VueltasRestantes = c.cantidadVueltas;
                    Random auxRandom = new Random();
                    v.CantidadCombustible = (short)auxRandom.Next(15, 100);
                    retorno= true;
                }
            }
            catch (CompetenciaNoDisponibleException exMi)
            {
               throw new CompetenciaNoDisponibleException("Competencia", "Sobregarga de operador +","Competencia incorrecta",exMi);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
            }            
            return retorno;
        }       
        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            bool retorno = false;
            if (c==v)
            {
               retorno= c.competidores.Remove(v);
                }
            return retorno;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
           return !(c == v);
        }
        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            bool retorno = false;
            if ( ( (c.TipoCompetencia == Biblioteca.ETipoCompetencia.F1) && (v.GetType()==typeof(AutoF1) ) ) ||
               ( (c.TipoCompetencia == Biblioteca.ETipoCompetencia.MotoCross) && (v.GetType() == typeof(MotoCross) ) ) )
            {
                if (c.competidores.Count > 0)
                {
                    foreach (VehiculoDeCarrera item in c.competidores)
                    {
                        if (item == v)
                        {
                            retorno = true;
                            break;
                        }
                    }
                }  
            }else
                {
                throw new CompetenciaNoDisponibleException("Competencia","Sobregarga de operador ==","El vehículo no corresponde a la competencia"); ;
                }  
            return retorno;
        }
    }
}