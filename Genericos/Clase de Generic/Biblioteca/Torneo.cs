using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Torneo<T> where T: Equipo
    {
        private List<T> equipos;
        private string nombre;

        public Torneo(string nombre)
        {
            this.equipos = new List<T>();
            this.nombre = nombre;
        }

        
        public string Nombre { get{ return nombre;} }
            
        /// <summary>
        /// Sobrecarga ==
        /// </summary>
        /// <param name="t"> Tipo Torneo<T> </t></param>
        /// <param name="tipo"> dato tipo T </param>
        /// <returns> Retorna True si el equipo esta en la lista </returns>
        public static bool operator ==(Torneo<T> t, T tipo)
        {
            bool retorno = false;
            if(t is not null && tipo is not null)
            {
                foreach (T item in t.equipos)
                {
                    if (item==tipo)
                    {
                        retorno = true;
                    }
                }
            }
            return  retorno;
        }
        /// <summary>
        /// Sobrecarga !=
        /// </summary>
        /// <param name="t"> Tipo Torneo<T> </t></param>
        /// <param name="tipo"> dato tipo T </param>
        /// <returns> Retorna True si el equipo no esta en la lista </returns>
        public static bool operator !=(Torneo<T> t, T tipo)
        {
            return !(t==tipo);
        }
        /// <summary>
        /// Sobrecarga de +
        /// </summary>
        /// <param name="t"> Tipo Torneo<T> </t></param>
        /// <param name="tipo"> dato tipo T </param>
        /// <returns> Retorna true si logra sumar elk elemento a ala lista </returns>
        public static bool operator +(Torneo<T> t, T tipo)
        {
            bool retorno = false;
            if (t is not null && tipo is not null)
            {
                if(t!=tipo)
                {
                    t.equipos.Add(tipo);
                    retorno = true;
                }
            }
            return retorno;
        }
        /// <summary>
        ///  Mostrar retornará los datos del equipos y de los equipos participantes.
        /// </summary>
        /// <returns> string con datos </returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
           // if(this is not null)
            sb.AppendLine($"Torneo: {this.Nombre}");
            if (this.equipos.Count>0)
            {
                foreach (T item in this.equipos)
                {
                     sb.AppendLine(item.Ficha());
                }
            }else
            {
                throw new NoHayEquiposAnotadosException("No hay suficiente cantidad de equipos anotados");
               // sb.AppendLine("No hay equipos anotados");
            }            
            return sb.ToString();
        }
        /// <summary>
        /// Recibe dos elementos del tipo T, que deberán ser del tipo Equipo o sus herencias
        /// Calcula utilizando la clase Random un resultado del partido. 
        /// </summary>
        /// <param name="tipo1"></param>
        /// <param name="tipo2"></param>
        /// <returns>Retornará el resultado como un string</returns>
        private string CalcularPartido(T tipo1, T tipo2)
        {
            StringBuilder sb = new StringBuilder();
            Random rand = new Random();
            if (tipo1 is EquipoFutbol && tipo2 is EquipoFutbol)
            {
                sb.Append($"{tipo1.Nombre} {rand.Next(1, 5)} - {tipo2.Nombre} {rand.Next(1, 5)}");
            }
            if (tipo1 is EquipoBasquet && tipo2 is EquipoBasquet)
            {
                sb.Append($"{tipo1.Nombre} {rand.Next(50, 120)} - {tipo2.Nombre} {rand.Next(50, 120)}");
            }
            return sb.ToString();
        }
        /// <summary>
        /// Toma dos equipos de la lista al azar y calculará el resultado del partido a través del método CalcularPartido.
        /// Si nohay equipos suficntes para jugar devulve ArgumenExcep
        /// </summary>
        public string JugarPartido 
        { 
            get
            {
                string retorno = string.Empty;
                try
                {
                    Random random = new Random();
                    int indice1, indice2;
                    if (this.equipos.Count >= 2)
                    {
                        indice1 = random.Next(0, this.equipos.Count - 1);
                        indice2 = random.Next(0, this.equipos.Count - 1);
                        while (indice1 == indice2)
                        {
                            indice2 = random.Next(0, this.equipos.Count - 1);
                        }
                        retorno=CalcularPartido(this.equipos[indice2], this.equipos[indice1]);
                        return retorno;
                    }
                    throw new ArgumentException($"En el torneo {this.Nombre} no hay suficiente equipos cargados para jugar");
                }
                catch (Exception)
                {
                    throw;
                }
                return retorno;
            }
        }
    }
}
