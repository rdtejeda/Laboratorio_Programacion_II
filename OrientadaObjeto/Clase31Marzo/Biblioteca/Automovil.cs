using System;

namespace Entidades
{
    public class Automovil
    {
        public const int velocidadMaximaPermitida = 60;
        private string patente;
        private short cantidadPuertas;
        private static short cantidadRudas;

        static Automovil()
        {
            Automovil.cantidadRudas = 4;
        }
        public Automovil(string patente)
        {
            this.SetPatente(patente);
            this.cantidadPuertas = 5;
        }
        public Automovil(string patente, short cantidadPuertas)
        {
            this.SetPatente(patente);
            this.cantidadPuertas=cantidadPuertas;
        }

        public void SetPatente(string patente)
        {
            this.patente = patente;
        }
    }
    
}
