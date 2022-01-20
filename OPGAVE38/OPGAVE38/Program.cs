using System;

namespace OPGAVE38
{
    class Program
    {
        static void Main(string[] args)
        {
            string type;
            double pris = 0, rabat=0,afterRabat=0;
            int antal, dag;
            Console.WriteLine("Køb af T-shirt");
            Console.WriteLine("SMALL koster 120 kr. MEDIUM koster 160 kr. LARGE koster 185 kr.");
           

            do
            {
                Console.Write("Indtast størrelse type (L/M/S) : ");
                type = Console.ReadLine().ToUpper();

            } while (type!="L" && type !="M" && type!="S");

            do
            {
               
                Console.Write("Hvor mange vil du købe ? Hvis du Køber man mere end 10 stk. skal man have en rabat på 5%. : ");
                antal = int.Parse (Console.ReadLine());

            } while (antal  < 1 || antal >24);
            Console.WriteLine("Nu er din indtastning godkendt  ");

            if (type == "S") pris = 120 * antal;
            if (type == "M") pris = 160 * antal;
            if (type == "L") pris = 185 * antal;

            if (antal>10)
            {
                rabat = pris * 0.05;
                afterRabat = pris - rabat;
                Console.WriteLine("Din pris er {0}. Du får {1} i rabat. Efter rabatten er fratrukket er totalpris:  {2}",pris,rabat,afterRabat);
            }
            else
            {
                Console.WriteLine("Pris in DKK  {0} ",pris);
            }


            Console.ReadKey();
           
        }
    }
}
