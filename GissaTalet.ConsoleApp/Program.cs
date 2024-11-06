using GissaTalet.Core;

namespace GissaTalet.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        var game = new Core.GissaTalet();
        var random = new Random();
        int randomNumber = game.Numbers[random.Next(game.Numbers.Count)];
        bool showHint = true;

        game.InitializeGame(); 
        Console.WriteLine(randomNumber);

        while (true)
        {
            if(game.Attempts <= 5 && showHint)
            {
                game.ShowHint(randomNumber);
                showHint = false;
            }

            Console.Write("\nYour previous guesses: ");
            game.ShowGuesses();

            Console.Write("\nEnter a number: ");
            game.CheckNumber(randomNumber);

            if (game.isGameOver || game.Attempts == 0)
            {
                if (game.Attempts == 0)
                {
                    Writer.ErrorLine("\n--- GAME OVER 😢 --- ");
                    Writer.Info($"The random number was {randomNumber}\n");
                }
                break;
            }
        }
    }
}