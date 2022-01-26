using System;
using System.IO;

namespace HenterForFil
{
    class Program
    {
        static void Main(string[] args)
        {
            //hente fra file
            string findtekts;
            int tæller = 0;
           
            Console.Write("Indtast hvad du vil søge efter : ");
            findtekts = Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\shoha\OneDrive\Desktop\TEC\C#\Programming\foldbold.txt");

            Console.WriteLine("Inholdet af mit kartotek ");

            foreach (string line in lines)
            {
                //Looking for some specific text
                // if (line.ToLower().Contains(findtekts))
                if (line.Contains(findtekts))
                {
                    //Console.WriteLine("Found what you searched for");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                   // Console.WriteLine("\t" + line);
                }

                if (tæller==3) //For Pagignation
                {
                    Console.Write("Tryk tast for næste side Next Side ->");
                    Console.ReadKey();
                    tæller = 0;
                    Console.Clear();

                }
                Console.WriteLine("\t" + line);
                Console.ResetColor();
                tæller++;

            }

            //string str = File.ReadAllText("test.txt");
            //str = str.Replace("some text", "some other text");
            //File.WriteAllText("test.txt", str);
            Console.WriteLine("Nu er alt hentet - Press any key to exit ");
            Console.ReadKey();

        }
    }
}
