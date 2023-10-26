using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() {FirstName = "Bob", LastName = "Smith" };
            employee.sayName();

            Console.ReadLine();
        }
    }
}
