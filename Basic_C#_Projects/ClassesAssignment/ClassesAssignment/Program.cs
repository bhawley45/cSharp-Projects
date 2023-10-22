using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Operations.AddFive(num));
            Console.WriteLine(Operations.MultiplySeven(num));
            Console.WriteLine(Operations.SubtractEleven(num));

            Console.ReadKey();
        }
    }
}
