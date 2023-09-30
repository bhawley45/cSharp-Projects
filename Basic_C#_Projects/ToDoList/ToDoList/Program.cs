using System;

var toDoList = new List<string>();
char inputChar;

Console.WriteLine("Hello!");
Console.WriteLine("Welcome to the To-Do 2.2");

do
{
    PrintWelcomeMessage();
    string userInput = Console.ReadLine();

    //Convert userInput toUpper() to simplify validation
    if (IsCharacter(userInput.ToUpper(), out inputChar))
    {
        switch (inputChar)
        {
            case 'S':
                seeList();
                break;
            case 'A':
                addItem();
                break;
            case 'R':
                removeItem();
                break;
            case 'E':
                exitProgram();
                break;
            default:
                Console.WriteLine("Please make a valid choice!");
                break;
        }
    }
    //Add nice spacer between iterations
    Console.WriteLine();
}
while (inputChar != 'E');


void seeList()
{
    if (IsEmpty(toDoList))
    {
        return;
    }

    Console.WriteLine();
    var length = toDoList.Count;

    //Print out each item with index starting at 1
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"{i + 1}. {toDoList[i]}");
    }
}

void addItem()
{
    string description;
    do
    {
        Console.WriteLine();
        Console.WriteLine("Enter the TODO description: ");
        description = Console.ReadLine();
    }
    while (!IsDescriptionValid(description));

    toDoList.Add(description);
}

void removeItem()
{
    if (IsEmpty(toDoList))
    {
        return;
    }

    int index;
    do
    {
        Console.WriteLine();
        Console.WriteLine("Select the index of the TODO you want to remove: ");
        seeList();
    }
    while (!IsIndexValid(out index)) ;

    //Subtract 1 from index for list, since list's index starts at 0...
    Console.WriteLine($"TODO removed: {toDoList.ElementAt(index - 1)}");
    toDoList.RemoveAt(index - 1);
}

void exitProgram()
{
    Console.WriteLine();
    Console.WriteLine("To-Do-aloo!");
    Console.WriteLine("Press any key to exit...");

    //Require keypress to end program
    Console.ReadLine();
}





void PrintWelcomeMessage()
{
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd a todo");
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]xit");
}

bool IsCharacter(string input, out char result)
{
    //Default valude for result
    result = 'N';

    if (char.TryParse(input, out result))
    {
        return true;
    }
    return false;
}

bool IsNumber(string input, out int result)
{
    //Default valude for result
    result = 'N';

    if (int.TryParse(input, out result))
    {
        return true;
    }
    return false;
}

bool IsEmpty(List<string> items)
{
    //Early return for empty list
    if (items.Count == 0)
    {
        Console.WriteLine();
        Console.WriteLine("No TODOs have been added yet.");
        return true;
    }
    return false;
}

bool IsDescriptionValid(string description)
{
    //If whitespace, empty, or null... ask for new input
    if (string.IsNullOrWhiteSpace(description))
    {
        Console.WriteLine("The description cannot be empty.");
        return false;
    }

    //If item already in list...
    if (toDoList.Contains(description))
    {
        Console.WriteLine($"{description} already exists! Try again...");
        return false;
    }

    //Once all checks are passed...
    Console.WriteLine($"TODO successfully added: {description}");
    return true;
}

bool IsIndexValid(out int index)
{
    var userInput = Console.ReadLine();

    //If whitespace, empty, or null... ask for new input
    if (string.IsNullOrWhiteSpace(userInput))
    {
        Console.WriteLine("Selected index cannot be empty.");
        index = 0;
        return false;
    }

    if (int.TryParse(userInput, out index) && (index <= toDoList.Count) && (index > 0))
    {
        return true;
    }
    
    Console.WriteLine("Please make a valid choice!");
    return false;
}