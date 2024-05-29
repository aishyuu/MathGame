Console.WriteLine("Please type your name");

var name = Console.ReadLine();
var date = DateTime.UtcNow;

Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine($"Hello {name.ToUpper()}. It's {date}. This is your math's game. That's great that you're working on improving yourself\n");
Console.WriteLine($@"What are ya gonna play? You got:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
Console.WriteLine("-----------------------------------------------------------");

var gameSelected = Console.ReadLine();

switch(gameSelected.ToLower().Trim())
{
    case "a":
        Console.WriteLine("Addition Selected");
        break;

    case "s":
        Console.WriteLine("Subtraction Selected");
        break;

    case "m":
        Console.WriteLine("Multiplication Selected");
        break;

    case "d":
        Console.WriteLine("Multiplication Selected");
        break;

    default:
        Console.WriteLine("Invalid Input");
        break;
}