// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();   // user input

        int length = text.Length;           // length of string

        Console.WriteLine("Length of string = " + length);

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}

