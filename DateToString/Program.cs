using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter date (dd-MM-yyyy): ");
        string input = Console.ReadLine();

        // Convert string → DateTime
        DateTime date = DateTime.ParseExact(input, "dd-MM-yyyy", null);

        Console.WriteLine("\nDifferent Formats:");

        Console.WriteLine("dd/MM/yyyy : " + date.ToString("dd/MM/yyyy"));
        Console.WriteLine("MM/dd/yyyy : " + date.ToString("MM/dd/yyyy"));
        Console.WriteLine("yyyy-MM-dd : " + date.ToString("yyyy-MM-dd"));
        Console.WriteLine("dd MMM yyyy : " + date.ToString("dd MMM yyyy"));
        Console.WriteLine("Full Format : " + date.ToString("dddd, dd MMMM yyyy"));

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();

       
        Console.ReadLine();
    }
}
