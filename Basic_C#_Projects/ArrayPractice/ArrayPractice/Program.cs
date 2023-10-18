using System;
using System.Collections.Generic;

namespace ArrayPractice
{
    internal class Program
    {
        static void Main()
        {
            string[] strings = { "pear", "apple", "orange" };
            int[] ints = { 1, 2, 3 };

            Console.WriteLine("Select an index from strings array: ");
            int userSelection = int.Parse(Console.ReadLine());
            if (userSelection <= strings.Length)
            {
                Console.WriteLine($"Information at that index: {strings[userSelection]}");
            }
            else
            {
                Console.WriteLine("That index does not exist...");
            }

            Console.WriteLine("Select an index from ints array: ");
            userSelection = int.Parse(Console.ReadLine());
            if (userSelection <= ints.Length)
            {
                Console.WriteLine($"Information at that index: {ints[userSelection]}");
            }
            else
            {
                Console.WriteLine("That index does not exist...");
            }

            Console.ReadKey();
        }
    }
}
