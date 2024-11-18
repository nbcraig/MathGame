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
