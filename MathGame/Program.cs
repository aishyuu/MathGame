
using MathGame;

Menu menu = new Menu();

string name = GetName();

DateTime date = DateTime.UtcNow;

List<string> history = new List<string>();

bool isGameOn = true;

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}