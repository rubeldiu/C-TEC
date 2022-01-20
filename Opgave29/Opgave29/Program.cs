using System;

namespace Opgave29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lav et program der udskriver alle hele tal fra 100 og ned til 1");
            for (int i = 100; i >= 1; i--)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
        }
    }
}
