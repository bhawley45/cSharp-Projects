using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssignment2
{
    public static class AddFive
    {
        public static int Action(int num) => num + 5;

        public static decimal Action(decimal dec) => dec / 5.0m;

        public static int Action(string s)
        {
            try
            {
                return int.Parse(s) + 5;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
