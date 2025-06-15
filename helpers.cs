using ConsApps.MathGame.Models;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>();

        internal static void AddToHistory(int gameScore, GameType gameType, int gameLevel)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType,
                Level = gameLevel
            });
        }
        internal static void PrintGames()
        {
            var gamesToPrint = games;
            Console.Clear();
            Console.WriteLine("Game History");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("");
            
            foreach (var game in gamesToPrint)
            {
                Console.WriteLine($"{game.Date} | {game.Type} | Level: {game.Level} | Score: {game.Score}");
            }

            Console.WriteLine("");
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

            var result = BuildResultArray(first, second, third, fourth, fifth, sixth);

            return result;
        }

        internal static int[] BuildResultArray(int first, int second, int third, int fourth, int fifth, int sixth)
        {
            return new[] { first, second, third, fourth, fifth, sixth };
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
        internal static string GetName()
        {
            Console.Clear();
            Console.WriteLine("Please type your name..");
            Console.WriteLine("");
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