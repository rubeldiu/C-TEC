using System;

namespace Temperaturomregning
{
    class Program
    {
        static void Main(string[] args)
        {
            // C = (F – 32) *5 / 9; Where F = Fahrenheit and C = Celsius.

            double fahrenheit, celsius;

            //Skriver på skærmen
            Console.Write("venligst, indtast en temperatur i Fahrenheit : ");
            fahrenheit = double.Parse(Console.ReadLine());

            // beregning 
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.ForegroundColor = ConsoleColor.Green;


            Console.WriteLine($" Fahrenheit {fahrenheit} temperaturen i Celsius bliver : {celsius:N2}");
            // vent på tastetryk
            Console.ReadKey();
        }
    }
}
