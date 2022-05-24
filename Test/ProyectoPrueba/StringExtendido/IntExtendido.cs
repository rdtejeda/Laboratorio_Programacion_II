using System;

namespace Bibiloteca
{
    public static class IntExtendido
    {
        public static string FizzBuzz(this Int32 n)
        {
            string salida = string.Empty;
            if (n % 3 == 0)
                salida += "Fizz";
            if (n % 5 == 0)
                salida += "Buzz";
            if(string.IsNullOrEmpty(salida))
                salida=n.ToString();
            return salida;
        }
    }
}
