using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("===== ONLINE EXAM SYSTEM =====\n");

        // Question 1
        Console.WriteLine("1. What is the capital of India?");
        Console.WriteLine("a) Mumbai");
        Console.WriteLine("b) New Delhi");
        Console.WriteLine("c) Kolkata");
        Console.WriteLine("d) Chennai");
        Console.Write("Your answer: ");
        char ans1 = char.ToLower(Console.ReadLine()[0]);

        if (ans1 == 'b')
            score++;

        // Question 2
        Console.WriteLine("\n2. Which keyword is used to define a class in C#?");
        Console.WriteLine("a) struct");
        Console.WriteLine("b) define");
        Console.WriteLine("c) class");
        Console.WriteLine("d) object");
        Console.Write("Your answer: ");
        char ans2 = char.ToLower(Console.ReadLine()[0]);

        if (ans2 == 'c')
            score++;

        // Question 3
        Console.WriteLine("\n3. Which loop executes at least once?");
        Console.WriteLine("a) for");
        Console.WriteLine("b) while");
        Console.WriteLine("c) foreach");
        Console.WriteLine("d) do-while");
        Console.Write("Your answer: ");
        char ans3 = char.ToLower(Console.ReadLine()[0]);

        if (ans3 == 'd')
            score++;

        // Result
        Console.WriteLine("\n===== RESULT =====");
        Console.WriteLine("Total Questions: 3");
        Console.WriteLine("Correct Answers: " + score);
        Console.WriteLine("Score: " + score + "/3");

        if (score == 3)
            Console.WriteLine("Excellent!");
        else if (score == 2)
            Console.WriteLine("Good!");
        else
            Console.WriteLine("Needs Improvement!");

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
