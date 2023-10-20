using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Pick a number:");
            //    int num1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Pick a second number:");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Dividing the two...");

            //    int num3 = num1 / num2;
            //    Console.WriteLine($"{num1} / {num2} = {num3}");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Please type a whole number...");
            //    return;
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please don't divide by 0!");
            //}
            ////General exception handling
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            ////finally will run no matter what, when an error is caught you might want to do a different action
            //finally
            //{
            //    //typically a DB log would be here (ex. credit card transaction)
            //    Console.ReadKey();
            //}


            /*
             * Create list of ints
             * ask for number to divide each element in list by
             * loop to divide each item in list
             * display to screen
             * build try/catch block to print message for each exception
             * exceptions to check: enter 0, enter a string, maybe others?
            */

            List<int> ints = new List<int>() {1,4,9,3};
            try
            {
                Console.WriteLine("Please enter a num to divide by:");
                int divisor = Convert.ToInt32(Console.ReadLine());

                foreach (int i in ints)
                {
                    Console.WriteLine(i / divisor);
                }
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by 0!");
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

            
        }
    }
}
