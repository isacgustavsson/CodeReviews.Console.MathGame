using ConsApps.MathGame.Models;

namespace MathGame
{
    internal class GameEngine
    {
        internal void AddGame(string message, int gameLevel)
        {
            var score = 0;
            var random = new Random();
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                if (gameLevel == 1)
                {
                    firstNumber = random.Next(1, 9);
                    secondNumber = random.Next(1, 9);
                }
                else if (gameLevel == 2)
                {
                    firstNumber = random.Next(1, 99);
                    secondNumber = random.Next(1, 99);
                }
                else if (gameLevel == 3)
                {
                    firstNumber = random.Next(1, 999);
                    secondNumber = random.Next(1, 999);
                }
                else return;

                Console.WriteLine("");
                Console.WriteLine($"{firstNumber} + {secondNumber}");

                Console.WriteLine("");
                var result = Console.ReadLine();
                Console.WriteLine("");
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Correct answer! Type any key for the next question..");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect answer. Type any key for the next question..");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game Over! Your final score is: {score}");
                }
            }

            Helpers.AddToHistory(score, GameType.Addition, gameLevel);
        }

        internal void SubGame(string message, int gameLevel)
{
    var score = 0;
    var random = new Random();
    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                if (gameLevel == 1)
                {
                    firstNumber = random.Next(1, 9);
                    secondNumber = random.Next(1, 9);
                }
                else if (gameLevel == 2)
                {
                    firstNumber = random.Next(1, 99);
                    secondNumber = random.Next(1, 99);
                }
                else if (gameLevel == 3)
                {
                    firstNumber = random.Next(1, 999);
                    secondNumber = random.Next(1, 999);
                }
                else return;

                Console.WriteLine("");
                Console.WriteLine($"{firstNumber} - {secondNumber}");

                Console.WriteLine("");
                var result = Console.ReadLine();
                Console.WriteLine("");
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Correct answer. Type any key for the next question..");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect answer. Type any key for the next question..");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game Over. Your final score is {score}.");
                }
            }
    Helpers.AddToHistory(score, GameType.Subtraction, gameLevel );
}
        internal void MultGame(string message, int gameLevel)
{
    var score = 0;
    var random = new Random();
    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                if (gameLevel == 1)
                {
                    firstNumber = random.Next(1, 9);
                    secondNumber = random.Next(1, 9);
                }
                else if (gameLevel == 2)
                {
                    firstNumber = random.Next(1, 99);
                    secondNumber = random.Next(1, 99);
                }
                else if (gameLevel == 3)
                {
                    firstNumber = random.Next(1, 999);
                    secondNumber = random.Next(1, 999);
                }
                else return;

                Console.WriteLine("");
                Console.WriteLine($"{firstNumber} * {secondNumber}");

                Console.WriteLine("");
                var result = Console.ReadLine();
                Console.WriteLine("");
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Correct answer. Type any key for the next question..");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect answer. Type any key for the next question..");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game Over. Your final score is: {score}");
                }
            }
        Helpers.AddToHistory(score, GameType.Multiplication, gameLevel);
}
        internal void DivGame(string message, int gameLevel)
{
            var score = 0;
            var firstNumber = 0;
            var secondNumber = 0;

       for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                var divNumbers = Helpers.GetDivNumbers();

                if (gameLevel == 1)
                {
                    firstNumber = divNumbers[0];
                    secondNumber = divNumbers[1];

                    Console.WriteLine("");
                    Console.WriteLine($"{divNumbers[0]} / {divNumbers[1]}");
                }
                else if (gameLevel == 2)
                {
                    firstNumber = divNumbers[2];
                    secondNumber = divNumbers[3];

                    Console.WriteLine("");
                    Console.WriteLine($"{divNumbers[2]} / {divNumbers[3]}");
                }
                else if (gameLevel == 3)
                {
                    firstNumber = divNumbers[4];
                    secondNumber = divNumbers[5];

                    Console.WriteLine("");
                    Console.WriteLine($"{divNumbers[4]} / {divNumbers[5]}");
                }

                Console.WriteLine("");
                var result = Console.ReadLine();
                Console.WriteLine("");
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Correct answer. Type any key for the next question..");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect answer. Type any key for the next question..");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game Over. Your final score is: {score}");
                }
            }
    Helpers.AddToHistory(score, GameType.Division, gameLevel);
}
    }
}