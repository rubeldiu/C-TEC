using System;
using System.Threading;

namespace Opgave24
{
    class Program
    {
        static void Main(string[] args)
        {
            string værelsestype;
            double pris = 0, euro;
            int antal, dag;
            Console.WriteLine("Hotelreservation – bestilling");
            Console.WriteLine("Enkeltværelse koster 765 kr. Dobbeltværelse koster 980 kr. Familieværelse koster 1250 kr.");
            Console.Write("Vælg værelsestype E(Enkeltværelse)/D(Dobbeltværelse)/F(Familieværelse): ");
            værelsestype = Console.ReadLine().ToLower();           
            Console.Write("Hvor mange (antal) værelser :");
            antal = int.Parse(Console.ReadLine());
            Console.Write("Hvor mange dage (antal overnatninger)?  :");
            dag = int.Parse(Console.ReadLine());

            if (værelsestype == "e") pris = 765 * antal * dag;
            if (værelsestype == "d") pris = 980 * antal * dag;
            if (værelsestype == "f") pris = 1250 * antal * dag;

            euro = pris*0.13;

            Console.WriteLine($"Du vælger værelsestype {værelsestype} og dag {dag} ,Pris in DKK  {pris:N2} og Euro {euro:N2}");
            Console.ReadKey();


        }
    }
}
