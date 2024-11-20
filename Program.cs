using static MathGame.MathGame;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your name!");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello {name}! Welcome to the MathGame!");

        DisplayMenu();
    }
}