using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int newNum = AddFive.Action(7);
            Console.WriteLine(newNum);

            decimal newDec = AddFive.Action(7.0m);
            Console.WriteLine(newDec);

            int otherNum = AddFive.Action("75");
            Console.WriteLine(otherNum);

            Console.ReadKey();
        }
    }
}
