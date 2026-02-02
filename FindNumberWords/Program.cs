// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();

        // Split string into words
        string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Number of words = " + words.Length);

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}

