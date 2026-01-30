using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Swapping using third variable
        int temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("After Swapping:");
        Console.WriteLine("First Number = " + num1);
        Console.WriteLine("Second Number = " + num2);

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}