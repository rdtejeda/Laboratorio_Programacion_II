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
            if (monto > 0)
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
            Datos.AppendLine("Titular = " + GetTitular());
            Datos.AppendLine("Saldo = " + GetDecimal().ToString());
            retorno = Datos.ToString();
            return retorno;
        }
    }
}