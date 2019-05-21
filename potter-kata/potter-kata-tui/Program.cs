using Potter_Kata;
using System;

namespace potter_kata_tui
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Harry Potter Book Pricing Application!");
            string s = "";
            var priceCalc = new PriceCalculator();
            while (s != "q")
            {
                Console.WriteLine("To add a book, enter a number from 1 to 5");
                Console.WriteLine("To clear your cart, press c");
                Console.WriteLine("To quit, press q.");
                s = Console.ReadLine();
                switch(s.ToLower())
                {
                    case "1":
                        priceCalc.addBook(new Book(1));
                        break;
                    case "2":
                        priceCalc.addBook(new Book(2));
                        break;
                    case "3":
                        priceCalc.addBook(new Book(3));
                        break;
                    case "4":
                        priceCalc.addBook(new Book(4));
                        break;
                    case "5":
                        priceCalc.addBook(new Book(5));
                        break;
                    case "c":
                        priceCalc.Clear();
                        break;
                    case "q":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Sorry, I didn't understand that.");
                        break;
                }

                Console.WriteLine("");
                var orderPrice = priceCalc.OrderPrice().ToString("N2");
                Console.WriteLine($@"Your total thus far is: {orderPrice} EUR");
                Console.WriteLine("");
            }
        }
    }
}
