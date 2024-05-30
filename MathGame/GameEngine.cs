using MathGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.WriteLine(message);

            Random random = new Random();
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                int num1 = random.Next(1, 9);
                int num2 = random.Next(1, 9);

                Console.WriteLine($"What is {num1} + {num2}");
                string userAnswer = Console.ReadLine();
                if (int.Parse(userAnswer) == (num1 + num2))
                {
                    Console.WriteLine("Correct! Press Enter for the next question.");
                    score++;
                    if (i == 4) break;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect! Press Enter for the next question.");
                    if (i == 4) break;
                    Console.ReadLine();
                }
            }

            Console.WriteLine($"Final Score: {score}");
            Helpers.AddHistory(score, GameType.Addition);
            Console.WriteLine("Press Enter to Exit Game");
            Console.ReadLine();
        }

        internal void SubtractionGame(string message)
        {
            Random random = new Random();
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                int num1 = random.Next(1, 101);
                int num2 = random.Next(1, 101);

                Console.WriteLine($"What is {num1} - {num2}?");
                string userAnswer = Console.ReadLine();

                if (int.Parse(userAnswer) == (num1 - num2))
                {
                    score++;
                    Console.WriteLine("Correct! Press Enter for the next question");
                    if (i == 4) break;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect! Press Enter for the next question");
                    if (i == 4) break;
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"Final Score: {score}");
            Helpers.AddHistory(score, GameType.Subtraction);
            Console.WriteLine("Press Enter to Exit Game");
            Console.ReadLine();
        }

        internal void MultiplicationGame(string message)
        {
            Random random = new Random();
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                int num1 = random.Next(1, 101);
                int num2 = random.Next(1, 101);

                Console.WriteLine($"What is {num1} * {num2}?");
                string userAnswer = Console.ReadLine();

                if (int.Parse(userAnswer) == (num1 * num2))
                {
                    score++;
                    Console.WriteLine("Correct! Press Enter for the next question");
                    if (i == 4) break;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect! Press Enter for the next question");
                    if (i == 4) break;
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"Final Score: {score}");
            Helpers.AddHistory(score, GameType.Multiplication);
            Console.WriteLine("Press Enter to Exit Game");
            Console.ReadLine();
        }

        internal void DivisionGame(string message)
        {
            Console.WriteLine(message);

            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                int[] numbers = Helpers.GetDivisionNumbers();

                Console.WriteLine($"What is {numbers[0]} / {numbers[1]}");
                string userResponse = Console.ReadLine();

                if (int.Parse(userResponse) == (numbers[0] / numbers[1]))
                {
                    Console.WriteLine("Correct! Press enter for next question.");
                    score++;
                    if (i == 4) break;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect! Press enter for next question.");
                    if (i == 4) break;
                    Console.ReadLine();
                }
            }

            Console.WriteLine($"Final Score: {score}");
            Helpers.AddHistory(score, GameType.Division);
            Console.WriteLine("Press Enter to Exit Game");
            Console.ReadLine();
        }
    }
}
