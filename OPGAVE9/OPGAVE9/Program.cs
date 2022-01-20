using System;

namespace OPGAVE9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.SetCursorPosition(40, 10);
            Console.WriteLine("Simpel tekst på skærm!");
            // Console.Beep(440, 2000);
            Console.ReadKey();
        }
    }
}
