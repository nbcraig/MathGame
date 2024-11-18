namespace MathGame;

using static MathGame.GameLogic;

internal class Helpers
{
    // Generate numbers for the operations, except division
    public static int[] GetNumbers()
    {
        var random = new Random();
        int firstNumber = random.Next(0, 100);
        int secondNumber = random.Next(0, 100);

        return [firstNumber, secondNumber];
    }

    // Number generator that handle division specifications
    public static int[] GetDivisionNumbers()
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

    /* Give the user the choice to:
     - See history
     - Quit the game 
     - Play new game*/
    public static void UserPrompts()
    {
        Console.WriteLine("Game Over!");
        Console.WriteLine("Choose an action:");
        Console.WriteLine("-----------------------------");
        Console.WriteLine(@"\n
H - See History
Q - Quit Game
N - New Game");

        var userInput = Console.ReadLine();
        switch (userInput)
        {
            case "H":
                displayGameHistory();
                break;
            case "Q":
                Console.WriteLine("You're leaving the game!");
                Console.WriteLine("GoodBye!");
                Environment.Exit(0);
                break;
            case "N":
                // Call the menu function for the user
                // to choose a new game
                Console.Clear();
                Menu();
                break;
            default:
                Console.WriteLine("Invalid input!");
                Console.WriteLine("GoodBye!");
                Environment.Exit(0);
                break;
        }
    }
}
