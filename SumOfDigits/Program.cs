using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int temp = number;

        while (temp != 0)
        {
            sum += temp % 10;   // get last digit
            temp /= 10;         // remove last digit
        }

        Console.WriteLine("Sum of digits = " + sum);

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
