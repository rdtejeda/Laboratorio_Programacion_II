using System;
using Teatro;

namespace Consola_Teatro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Binario a decimal
            string input = "0";
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // Usamos la potencia de 2, según la posición
                    sum = sum + (double)Math.Pow(2, i);
                }
            }
            Console.WriteLine("El decimal es {0}",sum);

            ///Decimal aBinario
            ///
            
            method1();

            static void method1()
            {
                int decimalNumber = 2;
                int remainder;
                string binary = string.Empty;

                
                if(decimalNumber==0)
                {
                    binary="0";
                }
                else
                {
                    while (decimalNumber > 0)
                     {
                        remainder = decimalNumber % 2;
                        decimalNumber = decimalNumber/2;
                        binary = remainder.ToString() + binary;
                     }
                }
                
                
                Console.WriteLine("Binary:  {0}", binary);
            }
            
            /*
            Espectador espectador = new Espectador(1234, "pepe", "");

            espectador.NumeroTelefonicoProp = "44556677";
            espectador.DniProp = 11;

            Console.WriteLine(espectador.NumeroTelefonicoProp);
            Console.WriteLine(espectador.DniProp);
            Console.WriteLine(espectador.DniProp);

            espectador.CodigoVentaProp = 20;

            //Teatro teatrito = new Teatro();

            /*
            Espectador esp;

            esp = teatrito[2];
            esp = teatrito[1];
            esp = teatrito[5];
            esp = teatrito[6];
            */
            // teatrito[1] = new Espectador(903, "Carmela", "99933");
            // esp = teatrito["9999"];
        }
    }
}
