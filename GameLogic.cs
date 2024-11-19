using static Program;
using static MathGame.Helpers;

namespace MathGame
{
    internal class GameLogic
    {
        internal static void PlayGame(Func<int, int, int> OperationFunction, string operationSign)
        {
            // Initialise score
            var score = 0;
            // Add iterator on games played to be used when displaying the game history
            var iterator = 1;

            for (int i = 0; i < 5; i++)
            {
                int[] numbers;
                if (operationSign == "/")
                { numbers = GetDivisionNumbers(); }
                else
                { numbers = GetNumbers(); }


                gameHistory.Add($"Game {iterator}: {numbers[0]} {operationSign} {numbers[1]}");
                iterator++;

                Console.WriteLine($"Solve {numbers[0]} {operationSign} {numbers[1]}");
                string? userSolution = Console.ReadLine();

                var result = OperationFunction(numbers[0], numbers[1]);
                if (int.Parse(userSolution) == result)
                {
                    score++;
                    Console.WriteLine("success");
                }
                else
                    Console.WriteLine("failure");
            }

            Console.WriteLine($"Your score is {score}");

            UserPrompts();
        }
    }
}
