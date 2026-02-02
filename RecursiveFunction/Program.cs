using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter base number: ");
        int baseNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter exponent: ");
        int exponent = Convert.ToInt32(Console.ReadLine());

        int result = Power(baseNum, exponent);

        Console.WriteLine($"{baseNum}^{exponent} = {result}");

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();   // waits for Enter key
    }

    // Recursive function
    static int Power(int baseNum, int exponent)
    {
        if (exponent == 0)
            return 1;

        return baseNum * Power(baseNum, exponent - 1);
    }
}
