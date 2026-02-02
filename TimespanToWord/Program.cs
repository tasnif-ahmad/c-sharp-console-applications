using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("TimeSpan to Words Converter (Relative Time)");

        DateTime inputTime;

        while (true)
        {
            Console.Write("Enter date & time (dd-MM-yyyy HH:mm): ");
            string input = Console.ReadLine();

            // Try to parse user input safely
            bool valid = DateTime.TryParseExact(
                input,
                "dd-MM-yyyy HH:mm",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out inputTime
            );

            if (valid)
                break;  // Exit loop if valid input
            else
                Console.WriteLine("Invalid format! Please try again.\n");
        }

        DateTime now = DateTime.Now;
        TimeSpan diff = now - inputTime;

        string relativeTime = GetRelativeTime(diff);

        Console.WriteLine("\nRelative Time: " + relativeTime);
        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }

    static string GetRelativeTime(TimeSpan timeSpan)
    {
        bool isFuture = timeSpan.TotalSeconds < 0;
        timeSpan = isFuture ? -timeSpan : timeSpan; // absolute value

        string suffix = isFuture ? "from now" : "ago";

        if (timeSpan.TotalSeconds < 60)
            return "Just now";

        if (timeSpan.TotalMinutes < 60)
            return $"{(int)timeSpan.TotalMinutes} minutes {suffix}";

        if (timeSpan.TotalHours < 24)
            return $"{(int)timeSpan.TotalHours} hours {suffix}";

        if (timeSpan.TotalDays < 30)
            return $"{(int)timeSpan.TotalDays} days {suffix}";

        if (timeSpan.TotalDays < 365)
            return $"{(int)(timeSpan.TotalDays / 30)} months {suffix}";

        return $"{(int)(timeSpan.TotalDays / 365)} years {suffix}";
    }
}
