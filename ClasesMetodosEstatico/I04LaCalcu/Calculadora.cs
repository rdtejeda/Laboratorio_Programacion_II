using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I04LaCalcu
{
    internal class Calculadora
    {
        public static int Calcular(int primeOperador, int segundoOperador, char operacion)
        {
            int resultado=0;
            do
            {          
                if (operacion=='+')
                {                
                    resultado=Sumar(primeOperador, segundoOperador);
                }
                if (operacion=='-')
                {               
                    resultado=Restar(primeOperador,segundoOperador);
                }
                if (operacion=='*')
                {                
                    resultado = Multiplicar(primeOperador, segundoOperador);
                }
                if (operacion=='/')
                {
                    if (Validar(segundoOperador))
                    {
                        return resultado=Dividir(primeOperador, segundoOperador);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por 0");
                        break;
                    }
                }
            } while (false);
          return resultado;
        }
        private static int Sumar(int primeOperador, int segundoOperador)
        {
            return primeOperador+segundoOperador;
        }
        private static int Restar(int primeOperador, int segundoOperador)
        {
            return primeOperador - segundoOperador;
        }
        private static int Multiplicar(int primeOperador, int segundoOperador)
        {
            return primeOperador * segundoOperador;
        }
        private static int Dividir(int primeOperador, int segundoOperador)
        {
            return primeOperador / segundoOperador;
        }

        private static bool Validar(int segundoOperador)
        {
            bool retorno = false;
            if (segundoOperador != 0 )
            {
                retorno = true;
            }
            return retorno;
        }    
    }
}
