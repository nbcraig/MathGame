using MathGame;
using static MathGame.Helpers;
using static MathGame.Operations;


var date = DateTime.UtcNow;
var name = Helpers.GetName();

// Initialise the list of games played
var gamehistory = new List<string>();

Menu(name);

void AdditionGame()
{
    var score = 0;
    Console.Clear();

    for (var i = 0; i > 5; i++)
    {
        // Present numbers to the user
        int[] numbers = GenerateRandomNumbers();
        Console.WriteLine("Solve the following:\n");
        Console.WriteLine($"{numbers[0]} + {numbers[1]}");
        var userSolution = Console.ReadLine();
        // Parse solution as integer
        if (int.Parse(userSolution) == numbers[0] + numbers[1])
        {
            score++;
            CorrectAnswerDisplayText();

            // Record the game to gameHistory
            gamehistory.Add($"Addition Game {numbers[0]} + {numbers[1]} = {numbers[0] + numbers[1]} :)");
        }
        else
        {
            WrongAnswerDisplayText();
            gamehistory.Add($"Addition Game {numbers[0]} + {numbers[1]} = {numbers[0] + numbers[1]} != {userSolution} :(");
        }
    }
}

void Menu(string name)
{

    Console.WriteLine("----------------------------------------------------------");
    Console.WriteLine($"Hello {name}. Welcome to the Math Game - Started at {date}");
    Console.WriteLine("\n");

    var isGameOn = true;

    do
    {
        Console.WriteLine($@"Choose an option:
        A - Addition
        S - Subtraction
        M - Multiplication
        D - Division
        H - Show game history
        Q - Quit");
        Console.WriteLine("----------------------------------------------------------");

        var optionSelected = Console.ReadLine();

        switch (optionSelected.ToUpper().Trim())
        {
            case "A":
                AdditionGame();
                break;
            case "S":
                //SubtractionGame();
                break;
            case "M":
                //MultiplicationGame();
                break;
            case "D":
                //DivisionGame();
                break;
            case "H":
                //ShowGameHistory();
                break;
            case "Q":
                Console.WriteLine("GoodBye !");
                isGameOn = false;
                break;
            default:
                Console.WriteLine("Invalid input");
                Environment.Exit(0);
                break;
        }
    }
    while (isGameOn);
}
