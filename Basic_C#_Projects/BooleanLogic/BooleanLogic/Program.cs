using System;
using System.Net;

namespace BooleanLogic
{
    internal class Program
    {
        private static object contiue;

        static void Main()
        {
            Console.WriteLine("Hello! Welcome to the Car Insurance Guru");

            Console.WriteLine("Please enter you age:");
            var applicantAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? (y/n)");
            bool hasDUI = false;
            switch (Console.ReadLine())
            {
                case "Y":
                case "y":
                    hasDUI = true;
                    break;
            }

            Console.WriteLine("How many speeding tickets have you had?");
            var numOfTickets = int.Parse(Console.ReadLine());


            //Determine if eligible
            if(applicantAge > 15 && !hasDUI && numOfTickets <= 3)
            {
                Console.WriteLine("You qualified!!");
            }
            else
            {
                Console.WriteLine("Sorry, you didn't meet our requirements :(");
            }

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
