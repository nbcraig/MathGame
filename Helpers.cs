using System;

namespace MathGame;

internal class Helpers
{
     public string GetName()
    {
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();
        return name;
    }
    public int[] GenerateRandomNumbers()
    {
        var random = new Random();
        int firstNumber = random.Next(1, 9);
        int secondNumber = random.Next(1, 9);
    
        return new int[2] { firstNumber, secondNumber };
    }
    public int[] GenerateDivisionRandomNumbers()
    {
        var random = new Random();
        int firstNumber = random.Next(0, 99);
        int secondNumber = random.Next(1, 99);
    
        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(0, 99);
            secondNumber = random.Next(1, 99);
        }
    
        return new int[2] { firstNumber, secondNumber };
    }
    public void CorrectAnswerDisplayText()
    {
        Console.WriteLine("Correct answer !!");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Press any key to continue");
        Console.WriteLine("'q' - Finish the game");
        Console.WriteLine("'h' - see the history");
        Console.WriteLine("----------------------------------------------------");
    
        var userInput = Console.ReadLine();
    
        if (userInput.ToLower() == "q")
        {
            Environment.Exit(0);
        }
    }
    public void WrongAnswerDisplayText()
    {
        Console.WriteLine("Wrong answer !");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Press any key to continue");
        Console.WriteLine("'q' - Finish the game");
        Console.WriteLine("'h' - see the history");
        Console.WriteLine("----------------------------------------------------");
    
        var userInput = Console.ReadLine();
    
        if (userInput.ToLower() == "q")
        {
            Environment.Exit(0);
        }
    }
}
