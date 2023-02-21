static class Message
{
    public static void WelcomePage()
    {
    Console.Title = "BlackJackLight";
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("  .-----------. ");
    Console.WriteLine(" /------------/|");
    Console.WriteLine("/.-----------/||");
    Console.WriteLine("| ♥       ♥  |||");
    Console.WriteLine("| BlackJack  |||");
    Console.WriteLine("|            |||");
    Console.WriteLine("|     ♥      |||");
    Console.WriteLine("|            |||");
    Console.WriteLine("| The Game   |||");
    Console.WriteLine("| ♥       ♥  ||/");
    Console.WriteLine("\\-----------./");
    Console.ResetColor();
    }

    public static void MenuPage(string Name, double PlayerMoney)
    {
    Console.WriteLine($"Welcome {Name}! Your current money is ${PlayerMoney}.");
    Console.WriteLine("1. New game");
    Console.WriteLine("2. Display player info");
    Console.WriteLine("3. Reset stats");
    Console.WriteLine("4. Exit");
    }

    public static void InitializeGame()
    {
        Console.WriteLine("Shuffling the deck...");
        Console.WriteLine("Done shuffling the deck...");
        Console.WriteLine("Serving the cards...");
    }
}