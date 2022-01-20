using System;

namespace TeoriOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            //int Variabel;
            // Variabel = Console.Read(); //Konverter char til ASCII.
            Console.Write("Calculation ");
            //for (int i = 0; i < 4; i++)
            //{
            //    System.Threading.Thread.Sleep(1000);
            //    Console.Write(".");

            //    Console.Write(DateTime.Now.ToString("E"+"MMddmmssff"));
            //}
            // Console.Write(DateTime.Now.ToString("MMddmmssff"));

            //Console.WriteLine("{0:N2}", Math.Round(156.356, 1));
            //Console.WriteLine("{0}", Math.Max(30, 87));
            //Console.WriteLine("{0,20}", "Der var engang");


            
            var date = DateTime.Now;
            DateTime nextSunday = date.AddDays(7 - (int)date.DayOfWeek);
            Console.Write("{0:D}",nextSunday);

            

            Console.ReadKey();
        }
    }
}
