using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your annual income: ");
        double income = Convert.ToDouble(Console.ReadLine());

        double tax = 0;

        if (income <= 250000)
        {
            tax = 0;
        }
        else if (income <= 500000)
        {
            tax = (income - 250000) * 0.05;
        }
        else if (income <= 1000000)
        {
            tax = (250000 * 0.05) +
                  (income - 500000) * 0.20;
        }
        else
        {
            tax = (250000 * 0.05) +
                  (500000 * 0.20) +
                  (income - 1000000) * 0.30;
        }

        Console.WriteLine("\n===== TAX DETAILS =====");
        Console.WriteLine("Annual Income : " + income);
        Console.WriteLine("Tax Amount    : " + tax);

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
