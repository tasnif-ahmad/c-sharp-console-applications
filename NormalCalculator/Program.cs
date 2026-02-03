using System;

class Program
{
    static void Main()
    {
        int choice;
        double num1, num2;

        do
        {
            Console.WriteLine("\n===== CALCULATOR =====");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice >= 1 && choice <= 4)
            {
                Console.Write("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                num1 = num2 = 0;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result = " + (num1 + num2));
                    break;

                case 2:
                    Console.WriteLine("Result = " + (num1 - num2));
                    break;

                case 3:
                    Console.WriteLine("Result = " + (num1 * num2));
                    break;

                case 4:
                    if (num2 != 0)
                        Console.WriteLine("Result = " + (num1 / num2));
                    else
                        Console.WriteLine("Cannot divide by zero");
                    break;

                case 5:
                    Console.WriteLine("Exiting calculator...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 5);

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
