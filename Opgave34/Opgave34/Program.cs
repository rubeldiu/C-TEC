using System;

namespace Opgave34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random ");
            Random RandomObj = new Random();
            int øjne;
            do
            {
                øjne = RandomObj.Next(1, 7);
                Console.WriteLine("Terning visit: {0}", øjne);
            }
            while (øjne < 6);
            Console.ReadKey();
        }
    }
}
