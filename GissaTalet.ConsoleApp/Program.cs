
// Välkomstmeddelande

// Regler?

// Gissa nummer (gissa ett nummer från 1-100... X för att avsluta..)

// Kolla om det redan har gissats

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

        while (true)
        {
        Console.Write("Enter a number: ");
        game.CheckNumber();
        }
    }
}