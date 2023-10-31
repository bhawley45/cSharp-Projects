using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAsignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() {FirstName = "Sample", LastName = "One", IdNumber = 55};
            employee1.SayName();
            Employee employee2 = new Employee() {FirstName = "Sample", LastName = "Two", IdNumber = 55};
            employee2.SayName();

            Console.WriteLine(employee1 == employee2);

            Console.ReadKey();
        }
    }
}
