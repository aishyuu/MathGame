using MathGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> history = new List<Game>
        {
            new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
            new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
            new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
            new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
    };

        internal static int[] GetDivisionNumbers()
        {
            Random random = new Random();

            int num1 = random.Next(1, 100);
            int num2 = random.Next(1, 100);

            while ((num1 % num2) != 0)
            {
                num1 = random.Next(1, 100);
                num2 = random.Next(1, 100);
            }

            return new int[] { num1, num2 };
        }

        internal static void GetHistory()
        {
            IEnumerable<Game> gamesQuery = history.Where(x => x.Type == GameType.Division);
            foreach (Game game in gamesQuery)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
            }
            Console.WriteLine("Press enter to return to Main Menu");
            Console.ReadLine();
        }

        internal static void AddHistory(int score, GameType gameMode)
        {
            history.Add(new Game { Score = score, Date = DateTime.Now, Type = gameMode });
        }
    }
}
