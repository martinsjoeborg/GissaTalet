namespace GissaTalet.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        var game = new Core.GissaTalet();

        var list = game.numbers;

        foreach (var number in list)
        {
            Console.WriteLine(number);
        }
    }
}
