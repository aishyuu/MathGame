using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new GameEngine();

        void ShowOptions()
        {
            Console.WriteLine($@"What are ya gonna play? You got:
H - Game History
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
            Console.WriteLine("-----------------------------------------------------------");
        }

        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date}. This is your math's game. That's great that you're working on improving yourself\n");

            ShowOptions();

            do
            {
                string gameSelected = Console.ReadLine();

                switch (gameSelected.ToLower().Trim())
                {
                    case "a":
                        gameEngine.AdditionGame("Addition Selected!");
                        break;

                    case "s":
                        gameEngine.SubtractionGame("Subtraction Selected!");
                        break;

                    case "m":
                        gameEngine.MultiplicationGame("Multiplication Selected!");
                        break;

                    case "d":
                        gameEngine.DivisionGame("Division Selected");
                        break;

                    case "h":
                        Helpers.GetHistory();
                        break;

                    case "q":
                        Console.WriteLine("Good Games!");
                        Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        Environment.Exit(1);
                        break;
                }
                Console.Clear();
                ShowOptions();
            } while (true);
        }
    }
}
