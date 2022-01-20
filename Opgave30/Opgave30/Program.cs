using System;

namespace Opgave30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lav et program der udskriver alle hele tal fra 0 til 100 med spring på 5");
            for (int i = 0; i <= 100; i=i+5)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
        }
    }
}
