using GissaTalet.Core;

namespace GissaTalet.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        var game = new Core.GissaTalet();
        var list = game.Numbers;

        Writer.WelcomeMessage();
        Writer.RulesInfo();

        while (true)
        {

        Console.Write("\nEnter a number: ");
        game.CheckNumber();
        
        }
    }
}