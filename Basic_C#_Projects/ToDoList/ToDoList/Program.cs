using System.Diagnostics;

Console.WriteLine("Hello!");
Console.WriteLine("What would you like to do?");
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

//reads line from console and assigns to variable
string userInput = Console.ReadLine();


//require keypress to continue program, in this case terminate
Console.ReadKey();