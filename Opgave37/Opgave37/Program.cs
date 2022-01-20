using System;

namespace Opgave37
{
    class Program
    {
        static void Main(string[] args)
        {
            string by;
            int gætte = 0;
           
            do
            {
                Console.WriteLine("Gætte et navn på en by på Fyn");
                by = Console.ReadLine().ToLower();
                gætte++;

            } while (by!= "odense" && by!= "egeskov" && by != "ærø" && by != "faaborg" && by != "rynkeby");
            Console.WriteLine("Du er Korrect and du gætte {0} gange ", gætte);
            Console.ReadKey();
        }
    }
}
