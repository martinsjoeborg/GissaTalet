
namespace GissaTalet.Core;

public class GissaTalet
{
    public int Attempts { get; set; } = 10;
    public List<int> Numbers { get; set; } = Enumerable.Range(1, 100).ToList();
    public bool isGameOver { get; set; } = false;

    public void SaveGuesses(int number)
    {
        string filePath = "../GissaTalet.Core/Logger.txt";
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(number);
        }
    }

    public void ClearGuesses()
    {
        string filePath = "../GissaTalet.Core/Logger.txt";
        File.WriteAllText(filePath, string.Empty);
    }

    public void ShowGuesses()
    {
        string filePath = "../GissaTalet.Core/Logger.txt";
        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            if (int.TryParse(line, out int number))
            {
                Console.Write($"{number} ");
            }
        }
    }

public void CheckNumber(int randomNumber)
{
    string answer = Console.ReadLine()!.Trim();

    if (userExit(answer)) return;

    if (int.TryParse(answer, out int input) && (input > 0 && input <= 100))
    {
        HandleGuess(input, randomNumber);
    }
    else
    {
        InvalidInput();
    }
}

private bool userExit(string answer)
{
    if (answer.ToLower() == "exit")
    {
        Writer.DarkCyan("\nLooks like you're giving up already! Don't worry — there's always next round! 😅\n");
        isGameOver = true;
        return true;
    }
    return false;
}

private void HandleGuess(int input, int randomNumber)
{
    SaveGuesses(input);

    if (input != randomNumber)
    {
        Writer.ErrorLine("\nWrong guess. Try again");
        Attempts--;
        Writer.InfoLine($"You have {Attempts} attempts left..");
    }
    else
    {
        Writer.SuccessLine("\nYou got it! 🥳");
        Writer.InfoLine($"The number was {randomNumber} and you had {Attempts} attempts left.\n");
        ClearGuesses();
        isGameOver = true;
    }
}

private void InvalidInput()
{
    Writer.ErrorLine("\nPlease enter a number from 1 to 100.");
    Attempts--;
    Writer.InfoLine($"You have {Attempts} attempts left.");
}

public void InitializeGame()
{
        Console.Clear();
        ClearGuesses();
        Writer.DarkCyan("--- WELCOME TO GUESS THE NUMBER 🥳 ---");
        Writer.RulesInfo();
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

    public static void DarkCyan(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void RulesInfo()
    {
        Console.WriteLine($"- You start off with 10 attempts");
        Console.WriteLine("- Invalid guesses decreases your attempts by 1");
        Console.WriteLine("- The numbers are between 1 and 100");
        Console.WriteLine("- Write EXIT to exit the game");
    }
}
