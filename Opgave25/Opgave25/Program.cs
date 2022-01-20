using System;

namespace Opgave25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enklæring af variable
            string username, password;
            //inddatæring af værdier
            Console.Write(" Venligst indtast brugernavn : ");
            username = Console.ReadLine();
            Console.Write(" Venligst indtast password : ");
            password = Console.ReadLine();

            //besultninger og beregninger
            if(username== "hamidul" && password == "123456")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Adgang til systemet");
                Console.Write("Tryk en tast for at fortsætte");
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Username and password is wrong");
            }

            //udskrivning
            Console.WriteLine("Programmet afsluttes - tryk en tast");
            Console.ReadKey();

        }
    }
}
