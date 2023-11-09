using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number input program :)");
            Console.WriteLine(" - you enter the number, we give it back -");
            var input = Console.ReadLine();

            File.WriteAllText(@"C:\Users\bhawl\Downloads\Log\log.txt", $"user input: {input}");
            Console.WriteLine(File.ReadAllText(@"C:\Users\bhawl\Downloads\Log\log.txt"));

            Console.ReadKey();
        }
    }
}
