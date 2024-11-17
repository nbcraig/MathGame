namespace MathGame;

internal class Helpers
{
    public static int[] GetNumbers()
    {
        var random = new Random();
        int firstNumber = random.Next(0, 100);
        int secondNumber = random.Next(0, 100);

        return [firstNumber, secondNumber];
    }
}
