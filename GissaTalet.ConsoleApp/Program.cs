using GissaTalet.Core;

namespace GissaTalet.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        var game = new Core.GissaTalet();
        var list = game.Numbers;

        Console.Clear();
        Writer.WelcomeMessage();
        Writer.RulesInfo();
        Random random = new Random();
        int randomIndex = random.Next(0, game.Numbers.Count);
        int randomNumber = game.Numbers[randomIndex];
        Console.WriteLine(randomNumber);

        while (true)
        {
            Console.Write("\nEnter a number: ");
            game.CheckNumber(randomNumber);
        }
    }
}