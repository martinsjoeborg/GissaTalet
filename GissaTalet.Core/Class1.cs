namespace GissaTalet.Core;

public class Class1
{
    public int Attempts {get; set;} = 10;
}

public class Writer
{
    public static void InfoLine(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
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
}