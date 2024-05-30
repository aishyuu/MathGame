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
        internal static List<Game> history = new List<Game>();

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
            foreach (Game game in history)
            {
                Console.WriteLine($"{game.Date} - {game.GameType}: {game.Score}pts");
            }
            Console.WriteLine("Press enter to return to Main Menu");
            Console.ReadLine();
        }

        internal static void AddHistory(int score, GameType gameMode)
        {
            history.Add(new Game { Score = score, Date = DateTime.Now, GameType = gameMode });
        }
    }
}
