using System;

namespace Biblioteca
{
    public class CalculadoraString
    {
        public int Add(string numero)
        {
            int resultado=0;
            if (string.IsNullOrEmpty(numero))
            {
                return resultado;
            }
            if (numero.StartsWith("//"))
            {
                char separador = numero[2];//0 y 1 son las //
                numero = numero.Substring(2).Replace(separador, ',');
                //numero = numero.Replace(separador, ',');
            }
            //numero = numero.Trim();

            string[] partes = numero.Split(new char[] {',','\n'}, StringSplitOptions.RemoveEmptyEntries);
            /*
            if(partes.Length == 1)
            {
                return resultado = int.Parse(numero);
            }
            */
            foreach (string item in partes)
            {
                if (int.Parse(item) < 0)
                {
                    throw new NegativoNoPermitidoException(item);
                }
                resultado += int.Parse(item);
            }            
            return resultado;// = int.Parse(partes[0]) + int.Parse(partes[1]);
        }
    }
}