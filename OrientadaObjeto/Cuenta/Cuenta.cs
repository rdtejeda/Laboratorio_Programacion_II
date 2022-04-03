using System;
using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        #region atributos;
        public string titular;
        public decimal cantidad;
        #endregion
        /// <summary>
        /// Un constructor que permita inicializar todos los atributos.
        /// </summary>
        /// <param name="titular">Nombre del titular de la cuenta</param>
        /// <param name="cantidad">Monto acreditado en la cuenta</param>
        public Cuenta(string titular, decimal cantidad)
        {           
            this.titular = titular; 
            this.cantidad = cantidad;            
        }
        /// <summary>
        /// Get que retorna el Titular de la cuenta
        /// </summary>
        /// <returns></returns>
        public string GetTitular()
        {
            return titular;
        }
        /// <summary>
        /// Get que retorna la cantidad
        /// </summary>
        /// <returns></returns>
        public decimal GetDecimal()
        {
            return cantidad;
        }
        /// <summary>
        /// Recibe un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
        /// </summary>
        /// <param name="monto"></param>
        public void Retirar(decimal monto)
        {
            this.cantidad -= monto;
        }
        /// <summary>
        /// Recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada
        /// </summary>
        /// <param name="monto">Monto a ingresar</param>
        public void Ingresar(decimal monto)
        {
            if(monto>0)
            {              
                this.cantidad += monto;                
            }            
        }
        /// <summary>
        ///  Retornará una cadena de texto con todos los datos de la cuenta
        /// </summary>
        /// <returns>Un StringBuilder con todos los datos</returns>
        public string Mostrar()
        {
            StringBuilder Datos = new StringBuilder();
            string retorno;
            Datos.AppendLine("Datos de la cuenta");
            Datos.AppendLine("Titular = "+GetTitular());
            Datos.AppendLine("Saldo = "+GetDecimal().ToString());
            retorno =Datos.ToString();
            return retorno;
        }
        /// <summary>
        /// Inicializa una Cuenta
        /// </summary>
        /// <returns>Objeto Inicializado</returns>
        public Cuenta IniciarCuenta()
        {
            Cuenta nuevaCuenta = new Cuenta("", 0);
            string entrada;
            string titularBuffer;
            decimal cantidadBuffer;
            bool volver = true;
            do
            {
                Console.WriteLine("Ingrese Titular de la Cuenta");
                titularBuffer = Console.ReadLine();
                Console.WriteLine("Ingrese Monto Deposito Inicial");
                entrada = Console.ReadLine();
                if (decimal.TryParse(entrada, out cantidadBuffer) && cantidadBuffer > 0)
                {
                    nuevaCuenta = new Cuenta(titularBuffer, cantidadBuffer);
                    Console.WriteLine(nuevaCuenta.Mostrar());
                    volver = false;
                }
                else
                {
                    Console.WriteLine("Ingrese Datos validos");
                }
            } while (volver);
            return nuevaCuenta;
        }
        /// <summary>
        /// Operar la cuenta para Depositos y Extracciones
        /// </summary>
        /// <param name="nuevaCuenta">Cueta a Operar</param>
        public void Operar(Cuenta nuevaCuenta)
        {
            string operar;
            string entro;
            decimal monto = 0;
            do
            {
                Console.WriteLine("Escriba Para Depositar 'Ingresar', Para Extraer 'Retirar', Para Salir 'Salir'");
                operar = Console.ReadLine();
                if (operar == "Ingresar" || operar == "Retirar")
                {
                    Console.WriteLine("Ingres Monto");
                    entro = Console.ReadLine();
                    decimal.TryParse(entro, out monto);
                    switch (operar)
                    {
                        //INGRESAR
                        case "Ingresar":
                            nuevaCuenta.Ingresar(monto);
                            Console.WriteLine(nuevaCuenta.Mostrar());
                            break;
                        //RETIRAR
                        case "Retirar":
                            nuevaCuenta.Retirar(monto);
                            Console.WriteLine(nuevaCuenta.Mostrar());
                            break;
                        default:
                            break;
                    }
                }
            } while (operar != "Salir");
        }
    }
}