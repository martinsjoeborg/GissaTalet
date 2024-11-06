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
            Console.Write("Your have guessed: ");
            game.ShowGuesses();

            Console.Write("\nEnter a number: ");
            game.CheckNumber();
        
        }
    }
}