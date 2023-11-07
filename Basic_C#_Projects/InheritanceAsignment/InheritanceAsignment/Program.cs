using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
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

            
            Employee employee3 = new Employee() {  FirstName = "Joe", LastName = "Bob", IdNumber= 56 };
            Employee employee4 = new Employee() {  FirstName = "Joe", LastName = "Slap", IdNumber= 57 };
            Employee employee5 = new Employee() {  FirstName = "Jimmy", LastName = "Bobby", IdNumber= 58 };
            Employee employee6 = new Employee() {  FirstName = "Bob", LastName = "Top", IdNumber= 59 };
            Employee employee7 = new Employee() {  FirstName = "Tim", LastName = "When", IdNumber= 60 };
            Employee employee8 = new Employee() {  FirstName = "Jim", LastName = "Mario", IdNumber= 61 };
            Employee employee9 = new Employee() {  FirstName = "Pen", LastName = "Luigi", IdNumber= 62 };
            Employee employee10 = new Employee() {  FirstName = "Quick", LastName = "Bob", IdNumber= 63 };

            List<Employee> employees = new List<Employee>() 
            {
                employee1, employee2, employee3,
                employee4, employee5, employee6,
                employee7, employee8, employee9,
                employee10
            };

            //List<Employee> joeEmployees = new List<Employee>();
            //foreach (Employee employee in employees)
            //{
            //    if (employee.FirstName.Equals("Joe"))
            //    {
            //        joeEmployees.Add(employee);
            //        Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            //    }
            //}

            List<Employee> joeEmployee = employees.Where(employee => employee.FirstName.Equals("Joe")).ToList();

            foreach (Employee employee in joeEmployee)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }

            Console.ReadKey();
        }
    }
}
