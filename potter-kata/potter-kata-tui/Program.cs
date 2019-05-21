using System;

namespace potter_kata_tui
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Harry Potter Book Pricing Application!");
            Console.WriteLine();
            var s = Console.ReadLine();
            Console.WriteLine($"You put in {s}");
            Environment.Exit(0);
        }
    }
}
