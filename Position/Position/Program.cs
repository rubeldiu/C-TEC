using System;

namespace Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(1, 1);
            Console.Write("x 1,1");
            Console.SetCursorPosition(20, 1);
            Console.Write("x 20,1");
            Console.SetCursorPosition(1, 15);
            Console.Write("x 1,15");
            Console.SetCursorPosition(20, 15);
            Console.Write("x 20,15");
            Console.ReadKey();
        }
    }
}
