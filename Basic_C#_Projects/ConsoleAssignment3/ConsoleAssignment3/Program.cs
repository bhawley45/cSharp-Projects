using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"output: {Bacon.displayAndAddTwo(2,5)}");

            int num1 = getNum();
            Console.WriteLine("\nType 0 to skip... (adds 5)");
            int num2 = getNum();

            Console.WriteLine(Bacon.addNums(num1, num2));
            Console.ReadKey();
        }

        public static int getNum()
        {
            Console.WriteLine("\nPlease enter a number:");

            int num = -1;
            while (num == -1)
            {
                string input = Console.ReadLine();
                try
                {
                    num = Convert.ToInt32(input);
                }
                catch
                {
                    Console.WriteLine("Please enter a valid integer...");
                }
            }
            return num;
        }
    }
}
