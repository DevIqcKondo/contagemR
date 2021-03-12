using System;

namespace contagemR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("_______________________________________");
            Console.WriteLine("O foguete será lançado após a contagem.");
            Console.WriteLine("Tecle ENTER para iniciar!");
            Console.WriteLine("_______________________________________");
            Console.ForegroundColor=ConsoleColor.Green;
            Console.ReadKey();
            Console.WriteLine("Preparar...");

            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.ReadKey();
            Console.WriteLine("Apontar...");

            Console.ForegroundColor=ConsoleColor.Red;
            Console.ReadKey();
            Console.WriteLine("FOGO!");
        }
    }
}
