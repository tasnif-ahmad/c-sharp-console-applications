
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter amount: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("In words: " + NumberToWords(number));

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }

    static string NumberToWords(int num)
    {
        if (num == 0)
            return "Zero";

        string[] ones = {
            "", "One", "Two", "Three", "Four",
            "Five", "Six", "Seven", "Eight", "Nine",
            "Ten", "Eleven", "Twelve", "Thirteen",
            "Fourteen", "Fifteen", "Sixteen",
            "Seventeen", "Eighteen", "Nineteen"
        };

        string[] tens = {
            "", "", "Twenty", "Thirty", "Forty",
            "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
        };

        string words = "";

        if (num >= 1000)
        {
            words += ones[num / 1000] + " Thousand ";
            num %= 1000;
        }

        if (num >= 100)
        {
            words += ones[num / 100] + " Hundred ";
            num %= 100;
        }

        if (num >= 20)
        {
            words += tens[num / 10] + " ";
            num %= 10;
        }

        if (num > 0)
        {
            words += ones[num] + " ";
        }

        return words.Trim();
    }
}
