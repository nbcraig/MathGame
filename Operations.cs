using System;
using static MathGame.Helpers;

namespace MathGame;

public class Operations
{
    // Initialise gameHistory a List collection
    public static List<string> gameHistory = new List<string>();

    public static void AdditionGame()
    {
        // Initialise score
        var score = 0;

        for (int i = 0; i < 5; i++)
        {
            var numbers = GetNumbers();
            gameHistory.Add($"{numbers[0]} + {numbers[1]}");

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

        for (int i = 0; i < 5; i++)
        {
            var numbers = GetNumbers();
            gameHistory.Add($"{numbers[0]} - {numbers[1]}");

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

        for (int i = 0; i < 5; i++)
        {
            var numbers = GetNumbers();
            gameHistory.Add($"{numbers[0]} * {numbers[1]}");

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

        for (int i = 0; i < 5; i++)
        {
            var numbers = GetNumbers();
            gameHistory.Add($"{numbers[0]} / {numbers[1]}");

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
        foreach (var game in gameHistory)
        {
            Console.WriteLine(game);
        }
    }
}