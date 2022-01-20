using System;

namespace Opgave28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lav et program der udskriver alle hele tal fra 1 og op til 100");

            for (int i = 1; i <= 100; i++)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
        }
    }
}
