using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleAppAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] strings = { "apple", "pear", "orange" };

            //Console.WriteLine("Enter a verb: ");
            //var verb = Console.ReadLine();

            //for(int i = 0; i < strings.Length; i++)
            //{
            //    strings[i] += (" " + verb);
            //}

            ////Print each element in strings[]
            //foreach(string s in strings)
            //{
            //    Console.WriteLine(s);
            //}


            //Console.WriteLine("Please enter the number 2: ");
            //int input = int.Parse(Console.ReadLine());
            //while (input < 2)
            //{
            //    Console.WriteLine("Dawg that's not 2...");
            //    input = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Bro, 2 and greater are the best numbers");

            //Console.WriteLine("Please enter a number >5: ");
            //input = int.Parse(Console.ReadLine());
            //while (input <= 5)
            //{
            //    Console.WriteLine("Dawg that's not >5...");
            //    input = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Bro, 5 and lesser numbers stink...");



            List<string> myStrings = new List<string>() { "apples", "bananas", "volkswagen", "ford", "ford" };
            List<string> duplicates = new List<string>();
            Console.WriteLine("search list:");
            var text = Console.ReadLine();

            //make duplicate string string...
            for(int i = 0; i < myStrings.Count; i++)
            {
                for(int j = 0; j < myStrings[i].Length; j++)
                {
                    if (myStrings[i] == myStrings[j])
                    {
                        //Add duplicate string to appropriate list
                        duplicates.Add(myStrings[i]);
                    }
                }
            }

            while (!myStrings.Contains(text))
            {
                Console.WriteLine($"{text} does not exist in the provided list. \nPlease try again... \n");

                //retry input
                text = Console.ReadLine();
            }
            Console.WriteLine($"\nYour text, {text}, exists at index {myStrings.IndexOf(text)}");

            //Print duplicates
            Console.WriteLine("\nDuplicates:");
            foreach(var item in duplicates)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
