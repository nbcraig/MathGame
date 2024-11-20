using static MathGame.MathGame;
    
namespace MathGame;

internal class Helpers
{
    // Generate numbers for the operations, except division
    internal static int[] GetNumbers()
    {
        Random random = new ();
        int firstNumber = random.Next(0, 10);
        int secondNumber = random.Next(0, 10);

        return [firstNumber, secondNumber];
    }

    // Number generator that handle division specifications
    internal static int[] GetDivisionNumbers()
    {
        var numbers = new int[2];
        var random = new Random();
        int firstNumber = random.Next(0, 100);
        int secondNumber = random.Next(1, 10);

        // Verifies if firstNumber / secondNumber results in an integer
        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(0, 100);
            secondNumber = random.Next(1, 10);
        }

        numbers = [firstNumber, secondNumber];

        return numbers;
    }

    // Self explanatory
    internal static bool ValidUserAnswer(string userAnswer, int expectedAnswer)
    {
        try
        {
            return int.Parse(userAnswer) == expectedAnswer;
        }
        catch
        {
            return false;
        }

    }

    /* After each round, give the user the choice to:
     - See history
     - Quit the game 
     - Play new game */
    internal static void UserPrompts()
    {
        Console.Clear();
        Console.WriteLine("Game Over!");
        Console.WriteLine("Choose an action:");
        Console.WriteLine("-----------------------------");
        Console.WriteLine(@"            H - See History
            S - Display score
            Q - Quit Game
            N - New Game");

        var userInput = Console.ReadLine();
        switch (userInput.Trim().ToUpper())
        {
            case "H":
                DisplayGameHistory();
                break;
            case "Q":
                Console.Clear();
                Console.WriteLine("You're leaving the game!");
                Console.WriteLine("GoodBye!");
                Environment.Exit(0);
                break;
            case "S":
                Console.Clear();
                DisplayScore();
                break;
            case "N":
                // Call the menu function for the user
                // to start a new game
                Console.Clear();
                DisplayMenu();
                break;
            default:
                Console.WriteLine("Invalid input!");
                Console.WriteLine("GoodBye!");
                Environment.Exit(0);
                break;
        }
    }

    internal static void DisplayGameHistory()
    {
        Console.Clear();

        Console.WriteLine("Game History");
        Console.WriteLine("-----------------------------");
        foreach (var game in gameHistory)
        {
            Console.WriteLine($"{game}");
        }
    }

    internal static void DisplayScore()
    {
       Console.WriteLine($"YOUR SCORE IS: {score}");
    }
}
