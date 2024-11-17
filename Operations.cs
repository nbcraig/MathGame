using System;
using static MathGame.Helpers;

namespace MathGame;

public class Operations
{
    public static void AdditionGame()
    {
        var score = 0;

        for (int i = 0; i < 5; i++)
        {
            var numbers = GetNumbers();
            Console. WriteLine($"Solve {numbers[0]} + {numbers[1]}");
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
    }
}