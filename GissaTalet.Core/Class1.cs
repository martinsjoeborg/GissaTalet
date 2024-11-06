
namespace GissaTalet.Core;

public class GissaTalet
{
    public int Attempts { get; set; } = 10;
    public List<int> Numbers { get; set; } = Enumerable.Range(1, 100).ToList();

    public void SaveGuesses(int number)
    {
        string filePath = "../GissaTalet.Core/Logger.txt";
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(number);
        }
    }

    public void CheckNumber()
    {
        string answer = Console.ReadLine()!.Trim();

        if (int.TryParse(answer, out int input) && (input > 0 && input <= 100))
        {
            SaveGuesses(input);
        }

        else
        {
            Writer.ErrorLine("\nPlease enter a number from 1 to 100.");
            Attempts--;
            Writer.InfoLine($"You have {Attempts} attempts left.");
        }
    }
}

public class Writer
{
    public static void InfoLine(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void Info(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void ErrorLine(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void SuccessLine(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void WelcomeMessage()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("--- WELCOME TO GUESS THE NUMBER 🥳 ---");
        Console.ResetColor();
    }

    public static void RulesInfo()
    {
        Console.WriteLine($"* You start off with 10 attempts");
        Console.WriteLine("* Invalid guesses decreases your attempts by 1");
        Console.WriteLine("* The numbers are between 1 and 100.");
    }
}
