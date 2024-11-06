
namespace GissaTalet.Core;

public class GissaTalet
{
    public int Attempts { get; set; } = 10;
    public List<int> Numbers { get; set; } = Enumerable.Range(1, 100).ToList();
    public List<int> Guesses { get; set; } = [];
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

    public void ShowHint(int randomNumber)
    {
        // SKRIV SHOWHINT FUNKTION
        switch (randomNumber)
        {
            case <= 100 and >= 90:
                Writer.SuccessLine("Hint: The number is somewhere between 90 and 100");
                break;
            case <= 89 and >= 80:
                Writer.SuccessLine("Hint: The number is somewhere between 80 and 89");
                break;
            case <= 79 and >= 70:
                Writer.SuccessLine("Hint: The number is somewhere between 70 and 79");
                break;
            case <= 69 and >= 60:
                Writer.SuccessLine("Hint: The number is somewhere between 60 and 69");
                break;
            case <= 59 and >= 50:
                Writer.SuccessLine("Hint: The number is somewhere between 50 and 59");
                break;
            case <= 49 and >= 40:
                Writer.SuccessLine("Hint: The number is somewhere between 40 and 49");
                break;
            case <= 39 and >= 30:
                Writer.SuccessLine("Hint: The number is somewhere between 30 and 39");
                break;
            case <= 29 and >= 20:
                Writer.SuccessLine("Hint: The number is somewhere between 20 and 29");
                break;
            case <= 19 and >= 10:
                Writer.SuccessLine("Hint: The number is somewhere between 10 and 19");
                break;
            case < 10:
                Writer.SuccessLine("Hint: The number is somewhere between 50 and 59");
                break;

        }

    }

public void CheckNumber(int randomNumber)
{
    string answer = Console.ReadLine()!.Trim();

    if (HandleExit(answer, randomNumber)) return;

    if (int.TryParse(answer, out int input) && (input > 0 && input <= 100))
    {
        if (!Guesses.Contains(input))
        {
            Guesses.Add(input);
        }

            else
        {
            Writer.ErrorLine("\nYou have already guessed that number.");
            return;
        }

        HandleGuess(input, randomNumber);
        Guesses.Add(input);
    }
    else
    {
        InvalidInput();
    }
}

public bool HandleExit(string answer, int randomNumber)
{
    if (answer.ToLower() == "exit")
    {
        Writer.DarkCyan("\nLooks like you're giving up already! Don't worry, there's always next round! 😅");
        Writer.Info($"The number you were trying to guess was {randomNumber}\n");
        isGameOver = true;
        return true;
    }
    return false;
}

public void HandleGuess(int input, int randomNumber)
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
        isGameOver = true;
    }
}

public void InvalidInput()
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
