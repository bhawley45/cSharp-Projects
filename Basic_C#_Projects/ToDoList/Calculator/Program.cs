using System;

//Print Welcome message
Console.WriteLine("Hello! Welcome to the SimpleCalc 3000");

//Ask User for FIRST Operand (Couldn't figure out how to overload GetOperand())
int firstOperand = GetOperand(string.Empty);

//Ask user for SECOND Operand
int secondOperand = GetOperand(" second");

//Ask user for operation, perform it, then print to console
ValidateAndCalculate(firstOperand, secondOperand);

//require keypress to continue program, in this case terminate
Console.WriteLine("Press any key to close...");
Console.ReadKey();


int GetOperand(string notFirst)
{
    Console.WriteLine($"Input a{notFirst} number: ");
    var userInput = Console.ReadLine();
    return ConvertToInt(userInput);
}

//Convert to integer (NO invalid input handling)
int ConvertToInt(string input)
{
    return int.Parse(input);
 
}

//Print options for avalable operations
void PrintOptions()
{
    Console.WriteLine("What would you like to do with these numbers?");
    Console.WriteLine("[A]dd");
    Console.WriteLine("[S]ubtract");
    Console.WriteLine("[M]ultiply");
}


void ValidateAndCalculate(int num1, int num2)
{
    string statement;
    int result;

    while (true)
    {
        //Print initial options and get user input
        PrintOptions();
        var userInput = Console.ReadLine();

        //Handle null case first
        if(string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine("Please enter a value...");
            continue;
        }

        //convert input to uppercase
        userInput = userInput.ToUpper();

        if(userInput == "A")
        {
            //Add Operands
            result = num1+num2;
            statement = $"{num1} + {num2} = ";
            break;
        }
        else if(userInput == "S")
        {
            //Subtract Operands
            result = num1 - num2;
            statement = $"{num1} - {num2} = ";
            break;
        }
        else if(userInput == "M")
        {
            //Multiply Operands
            result = num1 * num2;
            statement = $"{num1} x {num2} = ";
            break;
        }
        else
        {
            Console.WriteLine("Invalid choice...");
            continue;
        }
    }

    //Output results to console
    Console.WriteLine(statement + result);
}