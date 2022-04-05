using System;
using System.Text;  
/*
Ejercicio I07 - Recibo de sueldo
Se debe pedir el ingreso por teclado del valor hora, el nombre,la antigüedad (en años)
y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

Se pide calcular el importe a cobrar teniendo en cuenta que el total
(que resulta de multiplicar el valor hora por la cantidad de horas trabajadas),
hay que sumarle la cantidad de años trabajados multiplicados por $150,
y al total de todas esas operaciones restarle el 13% en concepto de descuentos.

Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora,
el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.

IMPORTANTE
Utilizar sentencias de iteración y selectivas.
No es necesario ni se deben utilizar vectores/arrays.
*/
namespace I07_ReciboDeSueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int valorHora;
            string nombre;
            int antiguedad;
            int horasTrabajadas;
            int totalBruto =0;
            int totalNeto=0;
            const int valorAntiguedad = 150;
            StringBuilder Datos = new StringBuilder();
            char seguirCargando;
            do
            {
                //Pido
                Console.WriteLine("Ingrese nombre de empleado");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese antigüedad (en años)");
                entrada = Console.ReadLine();
                int.TryParse(entrada, out antiguedad);
                Console.WriteLine("Ingrese cantidad de horas trabajadas en el mes");
                entrada = Console.ReadLine();
                int.TryParse(entrada, out horasTrabajadas);
                Console.WriteLine("Ingrese valor hora");
                entrada = Console.ReadLine();
                int.TryParse(entrada, out valorHora);
                //Calculo
                totalBruto = (int)((horasTrabajadas * valorHora) + (antiguedad * valorAntiguedad));
                totalNeto = (int)(totalBruto * 0.87);
                //Armo recibo´s
                Datos.AppendLine("Recibo de Sueldo de " + nombre);
                Datos.AppendLine("Antiguedad = " + antiguedad);
                Datos.AppendLine("El valor de la hora es = " + valorHora);
                Datos.AppendLine("Total Bruto= " + totalBruto);
                Datos.AppendLine("Total Neto = " + totalNeto);
                Datos.AppendLine();
                //¿Otro?
                Console.WriteLine("Para cargar otor empleado S");
                seguirCargando = (char)Console.Read();
            } while (seguirCargando == 'S');
            Console.WriteLine(Datos);           
        }       
	}   
}
