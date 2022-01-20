using System;

namespace Opgave42New
{
    class Program
    {
        static void Main(string[] args)
        {
            string tast;
            Console.WriteLine("Vælg dine læskedrikke, Tryk på 1 på Coca-Cola , 2  på Pepsi , 3 på  Mountain Dew , 4 på Sprite , eller 5 på Fanta på tastaturet: ");
            tast = Console.ReadLine();

            switch (tast)
            {
                case "1":
                    Console.WriteLine("Du vælger Coca-Cola og det koster 7 dkk");
                    break;
                case "2":
                    Console.WriteLine("Du vælger Pepsi og det koster 6 dkk");
                    break;
                case "3":
                    Console.WriteLine("Du vælger Mountain Dew og det koster 8 dkk");
                    break;
                case "4":
                    Console.WriteLine("Du vælger Sprite og det koster 7,5 dkk");
                    break;
                case "5":
                    Console.WriteLine("Du vælger Fanta og det koster 4 dkk");
                    break;
                default:
                    Console.WriteLine("Du har ikke tastet 1,2,3,4 eller 5 tast return");
                    break;
            }
            Console.ReadKey();

        }
    }
}
