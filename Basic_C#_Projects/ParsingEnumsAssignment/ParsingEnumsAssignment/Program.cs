using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week");

            var exit = false;
            while (!exit)
            {
                var input = Console.ReadLine();

                try
                {
                    DaysOfWeek today = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), input);   
                    Console.WriteLine($"\nThanks, now I remember, today is {today} :)");
                    exit = true; //exit while loop
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("\nPlease enter an ACTUAL day of the week.");
                }
            }
            Console.ReadLine();
        }

        enum DaysOfWeek
        {
            Monday,
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
