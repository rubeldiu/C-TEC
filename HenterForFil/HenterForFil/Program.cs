using System;

namespace HenterForFil
{
    class Program
    {
        static void Main(string[] args)
        {
            //hente fra file

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\shoha\OneDrive\Desktop\TEC\C#\Programming\foldbold.txt");

            Console.WriteLine("Inholdet what you searched for ");

            foreach (string line in lines)
            {
                //Search for File
                //if (line == "First Line")
                //{
                //    Console.Write("Found what you searched for");
                //}

                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("Nu er alt hentet - Press any key to exit ");
            Console.ReadKey();

        }
    }
}
