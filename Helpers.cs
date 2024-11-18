namespace MathGame;
using static MathGame.Operations;

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
     - Quit the game */
    public static void UserPrompts()
    {
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
            default:
                Console.WriteLine("Invalid input!");
                Console.WriteLine("GoodBye!");
                Environment.Exit(0);
                break;
        }
    }
}
