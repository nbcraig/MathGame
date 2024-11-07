// Implement gameHistory!!

var date = DateTime.UtcNow;
var name = GetName();

var gamehistory = new List<string>();

Menu(name);

void AdditionGame()
{
    var score = 0;
    do
    {
        Console.Clear();
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
        }
        else
        {
            WrongAnswerDisplayText();
            if (Console.ReadLine() == "Q".ToLower().Trim())
            {
                Console.WriteLine(@$"Goodbye :)
Your score is {score}");
                Environment.Exit(0);
            }
        }
    }
    while (true);
}
void SubtractionGame()
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
            if (Console.ReadLine() == "Q".ToLower().Trim())
            {
                Console.WriteLine(@$"Goodbye :)
Your score is {score}");
                Environment.Exit(0);
            }
        }
        else
        {
            WrongAnswerDisplayText();
        }
    }
    while (true);
}
void MultiplicationGame()
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
            if (Console.ReadLine() == "Q".ToLower().Trim())
            {
                Console.WriteLine($"Your score is {score}");
                Environment.Exit(0);
            }
        }
    }
    while (true);
}
void DivisionGame()
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
            if (Console.ReadLine() == "Q".ToLower().Trim())
            {
                Console.WriteLine($"Your score is {score}");
                Environment.Exit(0);
            }
        }
    }
    while (true);
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
        Q - Quit");
        Console.WriteLine("----------------------------------------------------------");

        var gameSelected = Console.ReadLine();

        switch (gameSelected.ToUpper().Trim())
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
                Console.WriteLine("GoodBye !");
                isGameOn = false;
                break;
            default:
                Console.WriteLine("Invalid input");
                Environment.Exit(0);
                break;
        }
    }
    while(isGameOn);

    
}
string GetName()
{
    Console.WriteLine("Enter your name");
    var name = Console.ReadLine();
    return name;
}
int[] GenerateRandomNumbers()
{
    var random = new Random();
    int firstNumber = random.Next(1, 9);
    int secondNumber = random.Next(1, 9);

    return new int[2] { firstNumber, secondNumber };
}
int[] GenerateDivisionRandomNumbers()
{
    var random = new Random();
    int firstNumber = random.Next(0, 99);
    int secondNumber = random.Next(1, 99);

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(0, 99);
        secondNumber = random.Next(1, 99);
    }

    return new int[2] {firstNumber, secondNumber};
}
void CorrectAnswerDisplayText()
{
    Console.WriteLine("Correct answer !!");
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("Press any key to continue");
    Console.WriteLine("'q' - Finish the game");
    Console.WriteLine("'h' - see the history");
    Console.WriteLine("----------------------------------------------------");
}

void WrongAnswerDisplayText()
{
    Console.WriteLine("Wrong answer !");
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("Press any key to continue");
    Console.WriteLine("'q' - Finish the game");
    Console.WriteLine("'h' - see the history");
    Console.WriteLine("----------------------------------------------------");
}