using System;
using Humanizer;

namespace DotNetDependencies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidades:");
            HumanizeQuantities();

            System.Console.WriteLine("\nDate/Time Manipulation:");
            HumanizeDates();
        }

        static void HumanizeQuantities()
        {
            System.Console.WriteLine("case".ToQuantity(0));
            System.Console.WriteLine("case".ToQuantity(1));
            System.Console.WriteLine("case".ToQuantity(5));

        }
        static void HumanizeDates()
        {
            System.Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
            System.Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
            System.Console.WriteLine(TimeSpan.FromDays(1).Humanize());
            System.Console.WriteLine(TimeSpan.FromDays(16).Humanize());

        }
    }
}
