using static MathGame.Operations;
/*
1. You need to create a Math game containing the 4 basic operations

2. The divisions should result on INTEGERS ONLY and dividends 
should go from 0 to 100. 
Example: Your app shouldn't present the division 7/2 to the user,
since it doesn't result in an integer.

3. Users should be presented with a menu to choose an operation

4. You should record previous games in a List and there should 
be an option in the menu for the user to visualize a history of previous games.

5. You don't need to record results on a database. 
Once the program is closed the results will be deleted.
*/

/*
1. Try to implement levels of difficulty.

2. Add a timer to track how long the user takes to finish the game.

3. Create a 'Random Game' option where the players will be presented 
with questions from random operations

4. To follow the DRY Principle, try using just one method for all games. 
Additionally, double check your project and try to find opportunities to 
achieve the same functionality with less code, avoiding repetition when possible.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        // Prompt the user to write their name
        Console.WriteLine("Enter your name!");
        string? name = Console.ReadLine();

        Console.WriteLine($"Hello {name}! Welcome to the MathGame!");


        Menu();

        
        void Menu()
        {
            Console.WriteLine("Choose an operation!");
            Console.WriteLine("A - Addition");
            Console.WriteLine("S - Subtraction");
            Console.WriteLine("M - Multiplication");
            Console.WriteLine("D - Division");
            Console.WriteLine("H - Show History");
            Console.WriteLine("Q - Quit!");

            string? userInput = Console.ReadLine();

            switch (userInput)
            {
                case "A":
                    AdditionGame();
                    break;
                case "S":
                    SubtractionGame();
                    break;
                case "M":
                    MultiplicationGame();
                    break;
                case "D":
                    DivisionGame();
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