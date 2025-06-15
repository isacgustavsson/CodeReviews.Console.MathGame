using ConsApps.MathGame.Models;

namespace MathGame
{
    internal class Menu
    {
    GameEngine engine = new();
    internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Hello {name}. Today is {date.DayOfWeek} the {date.Day}th and you are playing the math game.\n ");
            Console.WriteLine("Press any key to show the menu.");
            Console.ReadLine();

            var isGameOn = true;
            do
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("What game will you be playing?");
                Console.WriteLine(@"
A - Addition
S - Subtraction
M - Multiplication
D - Division
V - See Game History
Q - Quit the program");
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------");

                var GameMode = Console.ReadLine().Trim().ToLower();

                if (GameMode == "a" || GameMode == "s" || GameMode == "m" || GameMode == "d")
                {
                    GameType selectedGameType = GameType.Addition;

                    switch (GameMode)
                    {
                        case "a": selectedGameType = GameType.Addition; break;
                        case "s": selectedGameType = GameType.Subtraction; break;
                        case "m": selectedGameType = GameType.Multiplication; break;
                        case "d": selectedGameType = GameType.Division; break;
                    }

                    Console.Clear();
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine($"{selectedGameType} selected");
                    Console.WriteLine("");
                    Console.WriteLine("Please select level of difficulty");
                    Console.WriteLine(@"
x - Easy
y - Medium
z - Hard");
                    Console.WriteLine("");
                    Console.WriteLine("-------------------------------------------");
                    var Level = Console.ReadLine().Trim().ToLower();

                    switch (GameMode.Trim().ToLower())
                    {
                        case "a":
                            if (Level == "x")
                            {
                                engine.AddGame("Addition Game - Level 1", 1);
                                Console.WriteLine("");
                            }
                            else if (Level == "y")
                            {
                                engine.AddGame("Addition Game - Level 2", 2);
                                Console.WriteLine("");
                            }
                            else if (Level == "z")
                            {
                                engine.AddGame("Addition Game - Level 3", 3);
                                Console.WriteLine("");
                            }
                            break;

                        case "s":
                            if (Level == "x")
                            {
                                engine.SubGame("Subtraction game - Level 1", 1);
                                Console.WriteLine("");
                            }
                            else if (Level == "y")
                            {
                                engine.SubGame("Subtraction game - Level 2", 2);
                                Console.WriteLine("");
                            }
                            else if (Level == "z")
                            {
                                engine.SubGame("Subtraction game - Level 3", 3);
                                Console.WriteLine("");
                            }
                            break;

                        case "m":
                            if (Level == "x")
                            {
                                engine.MultGame("Multiplication game - Level 1", 1);
                                Console.WriteLine("");
                            }
                            else if (Level == "y")
                            {
                                engine.MultGame("Multiplication game - Level 2", 2);
                                Console.WriteLine("");
                            }
                            else if (Level == "z")
                            {
                                engine.MultGame("Multiplication game - Level 3", 3);
                                Console.WriteLine("");
                            }
                            break;

                        case "d":
                            if (Level == "x")
                            {
                                engine.DivGame("Division game - Level 1", 1);
                                Console.WriteLine("");
                            }
                            else if (Level == "y")
                            {
                                engine.DivGame("Division game - Level 2", 2);
                                Console.WriteLine("");
                            }
                            else if (Level == "z")
                            {
                                engine.DivGame("Division game - Level 3", 3);
                                Console.WriteLine("");
                            }
                            break;
                    }
                }
                else if (GameMode == "v" || GameMode == "q")
                {
                    switch (GameMode.Trim().ToLower())
                    {
                        case "v":
                            Helpers.PrintGames();
                            break;

                        case "q":
                            isGameOn = false;
                            break;
                    }
                }
            } while (isGameOn);
        }
    }
}