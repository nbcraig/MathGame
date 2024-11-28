using static MathGame.Helpers;

namespace MathGame
{
    internal class MathGame
    {
        // Initialise gameHistory a List collection
        public static List<string> gameHistory = new List<string>();

        // Initialise score
        internal static int scores;

        internal static void PlayGame(Func<int, int, int> OperationFunction, string operationSign)
        {
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

                string? userAnswer = Console.ReadLine();
                var expectedAnswer = OperationFunction(numbers[0], numbers[1]);

                if (ValidUserAnswer(userAnswer,expectedAnswer))
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

         internal static void DisplayMenu()
        {
            Console.WriteLine("Choose an operation!");
            Console.WriteLine("        A - Addition");
            Console.WriteLine("        S - Subtraction");
            Console.WriteLine("        M - Multiplication");
            Console.WriteLine("        D - Division");
            Console.WriteLine("        Q - Quit!");

            string? userInput = Console.ReadLine();

            switch (userInput.Trim().ToUpper())
            {
                // After selecting a new game,
                // a string of the game name will be added to gameHistory
                // in order to provide a more descriptive display of game history
                case "A":
                    gameHistory.Add("----Addition game start----");
                    PlayGame((a, b) => a + b, "+");
                    break;
                case "S":
                    gameHistory.Add("----Subtraction game start----");
                    PlayGame((a, b) => a - b, "-");
                    break;
                case "M":
                    gameHistory.Add("----Multiplication game start----");
                    PlayGame((a, b) => a * b, "*");
                    break;
                case "D":
                    gameHistory.Add("----Division game start----");
                    PlayGame((a, b) => a / b, "/");
                    break;
                case "Q":
                    Console.WriteLine("You're leaving the game!");
                    Console.WriteLine("GoodBye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("GoodBye!");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
