using ConsApps.MathGame.Models;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>
        {
            //new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            // new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            // new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            // new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            // new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            // new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            // new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
            // new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
            // new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
            // new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
            // new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
            // new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
            // new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 }, 
        };

        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType,
            });
        }
        internal static void PrintGames()
        {

            var gamesToPrint = games;
            Console.Clear();
            Console.WriteLine("Game History");
            Console.WriteLine("-------------------------------------------");
            foreach (var game in gamesToPrint)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
            }
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();

        }
        internal static int[] GetDivNumbers()
        {
            var random = new Random();
            var first = random.Next(1, 9);
            var second = random.Next(1, 9);
            var third = random.Next(1, 99);
            var fourth = random.Next(1, 99);
            var fifth = random.Next(1, 999);
            var sixth = random.Next(1, 999);

            var result = new int[6];
            {
                result[0] = first;
                result[1] = second;
                result[2] = third;
                result[3] = fourth;
                result[4] = fifth;
                result[5] = sixth;
            }
            
            Console.WriteLine(result);

            return result;
        }
        internal static string? ValidateResult(string? result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again.");
                result = Console.ReadLine();
            }
            return result;
        }
        internal static string getName()
        {
            Console.WriteLine("Please type your name..");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty. Try Again.");
                name = Console.ReadLine();
            }
            return name;
        }
    }
}