// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char ch = Console.ReadKey().KeyChar;   // takes single character input

        int asciiValue = (int)ch;              // type casting char to int

        Console.WriteLine("\nASCII Value of " + ch + " = " + asciiValue);

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
