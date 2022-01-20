using System;

namespace Opgave41
{
    class Program
    {
        static void Main(string[] args)
        {
            string tast;
            do
            {
                Console.WriteLine("Hamidul Menu");
                Console.WriteLine("1. vælg ");
                Console.WriteLine("2. vælg ");
                Console.WriteLine("3. vælg ");
                Console.WriteLine("9. afslut ");
                tast = Console.ReadLine();

            switch (tast)
            {
                case "1":
                    Console.WriteLine("Du har trykket på 1 tast return");
                        Console.ReadKey();
                        break;
                case "2":
                    Console.WriteLine("Du har trykket på 2 tast return");
                        Console.ReadKey();
                        break;
                case "3":
                    Console.WriteLine("Du har trykket på 3 tast return");
                        Console.ReadKey();
                        break;
                
                default:
                        if(tast !="9")
                        {
                            Console.WriteLine("Du har ikke tastet 1,2, eller 3 tast return");
                            Console.ReadKey();
                        }
                    
                    break;
            }
            } while (tast != "9");
            Console.WriteLine("Du har nu afsluttet program");
            Console.ReadKey();

        }
    }
}
