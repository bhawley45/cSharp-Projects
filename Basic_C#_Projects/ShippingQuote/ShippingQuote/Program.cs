using System;

namespace ShippingQuote
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the weight of you package:");
            int weight = int.Parse(Console.ReadLine());

            if(weight > 50)
            {
                Console.WriteLine("Package too heacy to be shipped via Package Express. Have a good day!");
                return;
            }

            Console.WriteLine("Please enter the Height of you package:");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Width of you package:");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Length of you package:");
            double length = double.Parse(Console.ReadLine());

            if (height > 50 || width > 50 || length > 50) 
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            double quote = ((height * width * length) * weight) / 100;
            Console.WriteLine($"Your estimated shipping cost is: ${Math.Round(quote, 2)}");
            //Round quote to 2 decimal places

            Console.ReadKey();
        }
    }
}
