using System;

namespace Opgave31
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, antal;
            Console.Write("Indtaster hvilken tabel det skal være : ");
            antal = int.Parse(Console.ReadLine());
            
            for (i = 1; i <= 10; i++)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{i} X {antal} = {i * antal}");
            }
            Console.ReadKey();
        }
    }
}

