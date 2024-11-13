using System;
using static MathGame.Helpers;

namespace MathGame;

internal class Operations
{
    public void SubtractionGame()
    {
        var score = 0;
        do
        {
            Console.Clear();
            // Present numbers to the user
            int[] numbers = GenerateRandomNumbers();
            Console.WriteLine("Solve the following:\n");
            Console.WriteLine($"{numbers[0]} - {numbers[1]}");
            var userSolution = Console.ReadLine();
            // Parse solution as integer
            if (int.Parse(userSolution) == numbers[0] - numbers[1])
            {
                score++;
                CorrectAnswerDisplayText();
            }
            else
            {
                WrongAnswerDisplayText();
            }
        }
        while (true);
    }
    public void MultiplicationGame()
    {
        var score = 0;
        do
        {
            Console.Clear();
            // Present numbers to the user
            int[] numbers = GenerateRandomNumbers();
            Console.WriteLine("Solve the following:\n");
            Console.WriteLine($"{numbers[0]} * {numbers[1]}");
            var userSolution = Console.ReadLine();
            // Parse solution as integer
            if (int.Parse(userSolution) == numbers[0] * numbers[1])
            {
                score++;
                CorrectAnswerDisplayText();
            }
            else
            {
                WrongAnswerDisplayText();
            }
        }
        while (true);
    }
    public void DivisionGame()
    {
        var score = 0;
        do
        {
            Console.Clear();
            // Present numbers to the user
            int[] numbers = GenerateDivisionRandomNumbers();
            Console.WriteLine("Solve the following:\n");
            Console.WriteLine($"{numbers[0]} / {numbers[1]}");
            var userSolution = Console.ReadLine();
            // Parse solution as integer
            if (int.Parse(userSolution) == numbers[0] / numbers[1])
            {
                score++;
                CorrectAnswerDisplayText();
            }
            else
            {
                WrongAnswerDisplayText();
            }
        }
        while (true);
    }
}
