﻿using System;

namespace Opgave40
{
    class Program
    {
        static void Main(string[] args)
        {
            string tast;
            Console.WriteLine("Tryk på 1 på tastaturet:");
            Console.WriteLine("Tryk på 2  på tastaturet:");
            Console.WriteLine("Tryk på 3 på tastaturet: ");
            tast = Console.ReadLine();

            switch (tast)
            {
                case "1":
                    Console.WriteLine("Du har trykket på 1 tast return");
                    break;
                case "2":
                    Console.WriteLine("Du har trykket på 2 tast return");
                    break;
                case "3":
                    Console.WriteLine("Du har trykket på 3 tast return");
                    break;
                default:
                    Console.WriteLine("Du har ikke tastet 1,2 eller 3 tast return");
                    break;
            }
            Console.ReadKey();

        }
    }
}
