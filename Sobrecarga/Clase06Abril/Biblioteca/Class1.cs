using System;

namespace Biblioteca
{
    public class Tiempo
    {
        int hora;
        int minutos;
        int segundos;

        public Tiempo(int h, int m, int s)
        {
            this.hora = h;
            this.minutos = m;
            this.segundos = s;
        }
        public Tiempo(float h, float m, float s) : this((int)h, (int)m, (int)s)
        {
            /*
            this.hora = (int)h;
            this.minutos = (int)m;
            this.segundos = 59;
            */
        }
        public Tiempo(int h, int m) : this(h, m, 59)
        {
            /*
            this.hora = (int)h;
            this.minutos = 59;
            this.segundos = 59;
            */
        }
        public Tiempo(int h) : this(h, 59)
        {

        }

        public string Mostrar()
        {
            return $"{this.hora} : {this.minutos} : {this.segundos}";
        }

        public static bool operator ==(Tiempo t1, Tiempo t2)
        {
            return t1.hora == t2.hora && t1.minutos == t2.minutos && t1.segundos == t2.segundos;
        }
        public static bool operator !=(Tiempo t1, Tiempo t2)
        {
            return !(t1 == t2);
        }
        
        public static implicit operator Tiempo(string s)
        {
            string[] tiempoStr = s.Split(':');
            return new Tiempo(int.Parse(tiempoStr[0]), int.Parse(tiempoStr[1]), int.Parse(tiempoStr[2]));
        }

        public static explicit operator int(Tiempo t)
        {
            return ((t.hora * 60) + t.minutos) * 60 + t.segundos;
        }
        
    }
    public  class Validador
    {
        public static bool ValidarRango(int valor, int min, int max)
        {
            return valor>= min && valor<=max;
        }
        public static bool ValidarRango(float valor, float min, float max)
        {
            return valor >= min && valor <= max;
        }
        public static bool ValidarRango(string valor, int min, int max)
        {
            return valor.Length >= min && valor.Length <= max;
        }
        public static bool ValidarRango(string valor, int max)
        {
            return valor.Length >=max;
        }
        public static bool ValidarRango(string valor, ref int max)
        {
            return valor.Length >= max;
        }

    }

}
