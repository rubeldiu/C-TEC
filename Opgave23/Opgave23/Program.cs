using System;

namespace Opgave23
{
    class Program
    {
        static void Main(string[] args)

        {
            char størrelsen;
            int count;
            double totalprisen =0,total=0;
            double rabat = 0;
            Console.SetCursorPosition(40, 10);
            Console.WriteLine("købe T-shirt");
            Console.SetCursorPosition(20, 12);
            Console.WriteLine("SMALL koster 120 kr. MEDIUM koster 160 kr.LARGE koster 185 kr.");
            Console.SetCursorPosition(20, 14);
            Console.Write("Indsæt størrelsen på T-shirt størrelse Small (S), Medium(M) eller Large(L) : ");
            størrelsen = char.Parse(Console.ReadLine().ToLower());
            Console.SetCursorPosition(20, 16);
            Console.Write("Hvor mange vil du købe ? Hvis du Køber man mere end 10 stk. skal man have en rabat på 5%. : ");
            count = int.Parse(Console.ReadLine());
            if(størrelsen=='s' && count > 10)
            {
                totalprisen = 120 * count;
                rabat = totalprisen * 0.05;
                total = totalprisen - rabat;
                Console.SetCursorPosition(20, 18);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Din pris er {totalprisen}. Du får {rabat} i rabat. Efter rabatten er fratrukket er totalpris:  {total}");

            }
            if (størrelsen == 's' && count <= 10)
            {
                totalprisen = 120 * count;
                Console.SetCursorPosition(20, 18);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Prisen er :  {totalprisen}");
            }
            if (størrelsen == 'm' && count > 10)
            {
                totalprisen = 160 * count;
                rabat = totalprisen * 0.05;
                total = totalprisen - rabat;
                Console.SetCursorPosition(20, 18);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Din pris er {totalprisen}. Du får {rabat} i rabat. Efter rabatten er fratrukket er totalpris:  {total}");

            }
            if (størrelsen == 'm' && count <= 10)
            {
                totalprisen = 160 * count;
                Console.SetCursorPosition(20, 18);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Prisen er :  {totalprisen}");
            }
            if (størrelsen == 'l' && count > 10)
            {
                totalprisen = 185 * count;
                rabat = totalprisen * 0.05;
                total = totalprisen - rabat;
                Console.SetCursorPosition(20, 18);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Din pris er {totalprisen}. Du får {rabat} i rabat. Efter rabatten er fratrukket er totalpris:  {total}");

            }
            if (størrelsen == 'l' && count <= 10)
            {
                totalprisen = 185 * count;
                Console.SetCursorPosition(20, 18);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Prisen er : {totalprisen}");
            }

            Console.ReadKey();

        }
    }
}
