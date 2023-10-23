using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssignment3
{
    public static class Bacon
    {
        public static int addNums(int a, int b)
        {
            if(b == 0)
            {
                return a + 5;
            }
            return a + b;
        }

        public static int displayAndAddTwo(int a, int b)
        {
            Console.WriteLine($"second argument {b}");
            return a + 2;
        }
    }
}
