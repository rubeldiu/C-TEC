using System;

namespace OpgaveFile
{
    class Program
    {
        static void Main(string[] args)
        {
            RadFile();

            WriteFile();

            RadFile();
            Console.ReadKey();

        }

        public static void RadFile()
        {
            // Read the file as one string
            string text = System.IO.File.ReadAllText(@"C:\Users\shoha\OneDrive\Desktop\TEC\C#\Programming\foldbold.txt");

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
            Console.WriteLine();
        }

        public static void WriteFile()
        {
            // Write one string to a text file.

            string text = "A class is the most powerful data type in C#. Like a structure, " + "a class defines the data and behavior of the data type. ";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllText(@"C:\Users\shoha\OneDrive\Desktop\TEC\C#\Programming\foldbold.txt", text);

        }

    }
}
