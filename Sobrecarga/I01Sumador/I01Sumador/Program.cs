using System;
using Bibioteca;
/*
Ejercicio I01 - Sumador
Consigna
Crear un proyecto de tipo biblioteca de clases y agregar la clase Sumador.
Crear dos constructores:
Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
Sumador() inicializa cantidadSumas en cero. Reutilizará al primer constructor.
El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:
En el caso de Sumar(long, long) sumará los valores numéricos
En el de Sumar(string, string) concatenará las cadenas de texto.
Crear un proyecto de consola y agregar un objeto del tipo Sumador en el método Main y probar el código.
Seguido:
Generar una conversión explícita que retorne cantidadSumas.
Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. El resultado será un long correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento.
Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. Deberá retornar true si ambos sumadores tienen igual valor en el atributo cantidadSumas.
Agregar un segundo objeto del tipo Sumador en el método Main y probar el código.
*/

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implemento constructor sobrecargado
            Sumador sumadorEnCero = new Sumador();
            Sumador sumadorEnDiez = new Sumador(10);
            Sumador sumadorEnOnce = new Sumador(11);

            //Uso metodo Sumar sobrecargado
            long resultadoLong = sumadorEnCero.Sumar(10, 15);
            string resultadoString = sumadorEnDiez.Sumar("BY ", "by");

            //Muestro resultados de constructo y metod sumar sobrecargados
            Console.WriteLine($"Resultado l+l {resultadoLong}");
            Console.WriteLine($"Cantidad de Sumas {sumadorEnCero.GetCantidadDeSumas()}");
            Console.WriteLine($"Resultado s+s {resultadoString}");
            Console.WriteLine($"Cantidad de Sumas {sumadorEnDiez.GetCantidadDeSumas()}");

            //Uso conversion explicita
            Console.WriteLine($"Resultado l+l {resultadoLong}");
            Console.WriteLine($"Cantidad de Sumas {(int)sumadorEnCero}");
            Console.WriteLine($"Resultado s+s {resultadoString}");
            Console.WriteLine($"Cantidad de Sumas {(int)sumadorEnDiez}");

            //uso Sobrecarga de + y |
            Console.WriteLine($"La suma del atributo cantidad de sumas de ambos objetos es {sumadorEnCero+sumadorEnDiez}");
            Console.WriteLine($"Son iguales los atributos de O en cero y O en diez {sumadorEnCero|sumadorEnDiez}");
            if(sumadorEnDiez|sumadorEnOnce)
            {
                Console.WriteLine("Es true");
            }            
            Console.WriteLine($"Son iguales los atributos de O operado y O en once {sumadorEnOnce | sumadorEnDiez}");
        }
    }
}
