using System;

namespace IncomeComparison
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("");

            //Person 1
            Console.WriteLine($"Person 1:");
            Console.WriteLine("Hourly Rate?");

            int person1Income = int.Parse(Console.ReadLine());

            Console.WriteLine("Hours worked this week?");
            int person1Hours = int.Parse(Console.ReadLine());

            //Person 2
            Console.WriteLine($"Person 2:");
            Console.WriteLine("Hourly Rate?");

            int person2Income = int.Parse(Console.ReadLine());

            Console.WriteLine("Hours worked this week?");
            int person2Hours = int.Parse(Console.ReadLine());

            var person1Total = person1Income * person1Hours;
            var person2Total = person2Income * person2Hours;

            //Output
            Console.WriteLine($"Annual Salary of Person 1: {person1Total}");
            Console.WriteLine($"Annual Salary of Person 2: {person2Total}");

            Console.WriteLine($"Does Person 1 make more money than Person 2? {person1Total > person2Total}");

            Console.ReadKey();
        }
    }
}
