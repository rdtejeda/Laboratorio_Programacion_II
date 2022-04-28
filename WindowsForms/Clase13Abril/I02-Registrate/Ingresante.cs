using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02_Registrate
{
    internal class Ingresante
    {
        private string[] curso = new string[3];
        private string direccion;
        private string edad;
        private string genero;
        private string nombre;
        private string pais;

       //public Ingresante()
        //{
       //}
        // 
        public Ingresante(string[] curso, string direccion, string edad, string genero, string nombre, string pais)//:this() 
        {
            this.curso = curso;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }
        public string Mostra()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Datos nuevx ingresante");
            sb.AppendLine($"Nombre = {this.nombre}");            
            sb.AppendLine($"Direccion = {this.direccion}");
            sb.AppendLine($"Edada = {this.edad}");
            sb.AppendLine($"Genero = {this.genero}");            
            sb.AppendLine($"Pais = {this.pais}");
            sb.AppendLine("Curos/s:");
            for (int i = 0; i < curso.Length; i++)
            {
                sb.AppendLine(this.curso[i]);
            }         


            return sb.ToString();
        }
    }
}
