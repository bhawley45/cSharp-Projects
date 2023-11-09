using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var currentTime = DateTime.Now;
            Console.WriteLine($"The current time is: {currentTime}\n");
            Console.WriteLine("How many hours would you like to add?");
            var numOfHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The time in {numOfHours} hours will be {currentTime.AddHours(numOfHours)}");
            Console.ReadKey();
        }
    }
}
