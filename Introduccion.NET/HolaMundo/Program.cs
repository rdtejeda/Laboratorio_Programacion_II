using System;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hello World!";

            Console.Beep(); // Sonido por defecto.

            


            Console.WriteLine("Presione una tecla o combinación de teclas:");

            ConsoleKeyInfo teclaPresionada = Console.ReadKey(true);

            ConsoleKey tecla = teclaPresionada.Key;
            char caracter = teclaPresionada.KeyChar;
            ConsoleModifiers modificadores = teclaPresionada.Modifiers;

            Console.WriteLine("Tecla: {0}. Caracter: {1}. Modificadores: {2}", tecla, caracter, modificadores);

            Console.Clear();
            Console.Beep(1000, 1500); // Sonido de 1000hz durante 1 segundo y medio. 
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello World!");
            Environment.Exit(0);
        }
    }
}
