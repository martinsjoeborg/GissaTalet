using GissaTalet.Core;

namespace GissaTalet.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        var game = new Core.GissaTalet();
        var list = game.Numbers;
        Random random = new Random();
        int randomIndex = random.Next(0, game.Numbers.Count);
        int randomNumber = game.Numbers[randomIndex];
        Console.WriteLine(randomNumber);

        game.InitializeGame(); // Console Clear, Rensar Logger.txt (lagrar gissningar)
                               // Skriver ut välkomst, och skriver ut hur spelet funkar

        while (true)
        {

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