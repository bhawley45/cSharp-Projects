using System;

namespace StudentReport
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy \n ~ Student Daily Report \n");

            //Ask for name
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            //Ask for current course
            Console.WriteLine("What course are you on?");
            var course = Console.ReadLine();

            //Ask for page number
            Console.WriteLine("What page number?");
            var pageNum = Console.ReadLine();

            //Ask if user needs help
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            var needHelp = Convert.ToBoolean(Console.ReadLine());

            //Ask for input on positive experiences
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            var positiveFeedback = Console.ReadLine();

            //Other feedback
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            var otherFeedback = Console.ReadLine();

            //Ask hours studied
            Console.WriteLine("How many hours did you study today?");
            var studyHours = Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will repsond shortly. Have a great day!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
