using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        string strength = CheckPasswordStrength(password);

        Console.WriteLine("Password Strength: " + strength);

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }

    static string CheckPasswordStrength(string password)
    {
        if (password.Length < 6)
            return "Weak (Too short)";

        bool hasUpper = false;
        bool hasLower = false;
        bool hasDigit = false;
        bool hasSpecial = false;

        foreach (char ch in password)
        {
            if (char.IsUpper(ch))
                hasUpper = true;
            else if (char.IsLower(ch))
                hasLower = true;
            else if (char.IsDigit(ch))
                hasDigit = true;
            else
                hasSpecial = true;
        }

        if (hasUpper && hasLower && hasDigit && hasSpecial)
            return "Strong";

        if ((hasUpper || hasLower) && hasDigit)
            return "Medium";
        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();

        return "Weak";

    }
}
