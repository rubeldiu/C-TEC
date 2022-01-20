using System;

namespace OPGAVE8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(40, 10);
            Console.WriteLine("Kære alle. Velkommen til fest.");
            Console.SetCursorPosition(2, 12);
            Console.WriteLine("Allan medbringer {0}. Per medbringer {1} {2} , Lise medbringer {3} {4} og Kim medbringer {5} {6} .", "brød",3, "tomater",5, "æbler",2, "bananer");
           
            Console.ReadKey();

        }
    }
}
