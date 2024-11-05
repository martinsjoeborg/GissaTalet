
// Välkomstmeddelande

// Regler?

// Gissa nummer

// Skriv ut liv/försök/hints

// Skicka försöken till txt-fil

// Resultat/Visa rätt nummer

// Fråga om att spela igen

using GissaTalet.Core;

namespace GissaTalet.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        var game = new Core.GissaTalet();

        var list = game.Numbers;

        foreach (var number in list)
        {
            Console.WriteLine(number);
        }

        Writer.SuccessLine("Yippi!");
    }
}

