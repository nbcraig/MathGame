using System;
using static MathGame.Helpers;

namespace MathGame;

public class GameLogic
{
    // Initialise gameHistory a List collection
    public static List<string> gameHistory = new List<string>();

    public static void Menu()
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
                AdditionGame();
                break;
            case "S":
                gameHistory.Add("----Subtraction game start----");
                SubtractionGame();
                break;
            case "M":
                gameHistory.Add("----Multiplication game start----");
                MultiplicationGame();
                break;
            case "D":
                gameHistory.Add("----Division game start----");
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

    public static void AdditionGame()
    {
        // Initialise score
        var score = 0;
        // Add iterator on games played to be used when displaying the game history
        var iterator = 1;

        for (int i = 0; i < 5; i++)
        {
            var numbers = GetNumbers();
            gameHistory.Add($"Game {iterator}: {numbers[0]} + {numbers[1]}");
            iterator++;

            Console.WriteLine($"Solve {numbers[0]} + {numbers[1]}");
            string? userSolution = Console.ReadLine();

            var result = numbers[0] + numbers[1];
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

    public static void SubtractionGame()
    {
        // Initialise score
        var score = 0;
        // Add iterator on games played to be used when displaying the game history
        var iterator = 1;

        for (int i = 0; i < 5; i++)
        {
            var numbers = GetNumbers();
            gameHistory.Add($"Game {iterator}: {numbers[0]} - {numbers[1]}");
            iterator++;

            Console.WriteLine($"Solve {numbers[0]} - {numbers[1]}");
            string? userSolution = Console.ReadLine();

            var result = numbers[0] - numbers[1];
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

    public static void MultiplicationGame()
    {
        // Initialise score
        var score = 0;
        // Add iterator on games played to be used when displaying the game history
        var iterator = 1;

        for (int i = 0; i < 5; i++)
        {
            var numbers = GetNumbers();
            gameHistory.Add($"Game {iterator}: {numbers[0]} * {numbers[1]}");
            iterator++;

            Console.WriteLine($"Solve {numbers[0]} * {numbers[1]}");
            string? userSolution = Console.ReadLine();

            var result = numbers[0] * numbers[1];
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

    public static void DivisionGame()
    {
        // Initialise score
        var score = 0;
        // Add iterator on games played to be used when displaying the game history
        var iterator = 1;

        for (int i = 0; i < 5; i++)
        {
            var numbers = GetDivisionNumbers();
            gameHistory.Add($"Game {iterator}: {numbers[0]} / {numbers[1]}");
            iterator++;

            Console.WriteLine($"Solve {numbers[0]} / {numbers[1]}");
            string? userSolution = Console.ReadLine();

            var result = numbers[0] / numbers[1];
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

    public static void displayGameHistory()
    {
        Console.Clear();

        Console.WriteLine("Game History");
        Console.WriteLine("-----------------------------");
        foreach (var game in gameHistory)
        {
            Console.WriteLine($"{game}");
        }
    }
}