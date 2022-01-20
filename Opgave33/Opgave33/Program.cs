using System;

namespace Opgave33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast tal : ");
            int tal = int.Parse(Console.ReadLine());

            while (tal != 50){
                Console.WriteLine("Udfør program");
                Console.WriteLine("Indlæs Tal");
                tal = int.Parse(Console.ReadLine());
            }
            Console.Write("While Slut");
            Console.Write("  Stop");
            Console.ReadKey();


        }
    }
}
