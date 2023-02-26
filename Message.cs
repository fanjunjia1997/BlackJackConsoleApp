static class Message
{

    private const int playerCursorOffset = 10;
    private const int dealerCurosrOffset = 40;


    public static void ClearCurrentConsoleLine()
    {
        // need some work here
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, currentLineCursor + 1);
    }

    public static void WelcomePage()
    {
        Console.WriteLine("");
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
        Console.WriteLine("");
    Console.ResetColor();
    }

    public static void MenuPage(string Name, double PlayerMoney)
    {
        Console.WriteLine("");
        Console.WriteLine($"Welcome {Name}! Your current money is ${PlayerMoney}.");
        Console.WriteLine("1. New game");
        Console.WriteLine("2. Display player info");
        Console.WriteLine("3. Reset stats");
        Console.WriteLine("4. Exit");
        Console.WriteLine("");
    }

    public static void InitializeGame()
    {
        Console.WriteLine("");
        Console.WriteLine("Shuffling the deck...");
        Console.WriteLine("Done shuffling the deck...");
        Console.WriteLine("Serving the cards...");
        System.Threading.Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Game starting...");
        System.Threading.Thread.Sleep(1000);
        Console.Clear();
    }


    public static void ShowHandMessage(Player player, Dealer dealer, bool dealerFirstRound)
    {
        // player
        Console.SetCursorPosition(playerCursorOffset, 0);
        Console.WriteLine(player.Name + ": " + player.getHandValue());
        player.showHand(playerCursorOffset);

        Console.CursorLeft = playerCursorOffset;

        if (player.isBlackJack() == true) { Console.WriteLine("Black Jack!"); }

        // Dealer 
        Console.SetCursorPosition(dealerCurosrOffset, 0);
        if (dealerFirstRound)
        {
            if (dealer.hand[0].value == 1)
            {
                Console.WriteLine(dealer.Name + ": " + 11);
            }
            else 
            {
                Console.WriteLine(dealer.Name + ": " + dealer.hand[0].value);
            }
            
        }
        else
        {
            Console.WriteLine(dealer.Name + ": " + dealer.getHandValue());
        }
        dealer.showHand(dealerCurosrOffset, dealerFirstRound);
        

        if (player.getHandValue() <= 21)
        {
            // dealer
            //Console.SetCursorPosition(dealerCurosrOffset, dealer.hand.Count() + 1);

            Console.CursorLeft = dealerCurosrOffset;
            //Console.Write("Dealer hand value: ");
            //Console.WriteLine(dealer.getHandValue());
            if (dealerFirstRound == false && dealer.isBlackJack() == true) { Console.WriteLine("Black Jack!"); }
        }
        else { return; }
    }

    public static void HitMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Hit / Stand? \n 1) Hit \n 2) Stand");
        Console.WriteLine("");
    }

    public static double BetMessage(Player p)
    {
        Console.WriteLine("Your current balance: $" + p.balance);
        Console.WriteLine("Please place your bet");
        Console.Write("$");
        double betAmount = int.Parse(Console.ReadLine());
        Console.Clear();
        return betAmount;
    }

    public static void PayoutMessage(GameLogic gl, Player p, Dealer d, double betAmount)
    {
        Console.SetCursorPosition(25, Math.Max(d.hand.Count(), p.hand.Count()) + 2);
        Console.WriteLine(gl.ResultMsg);

        p.balance += betAmount * gl.payOutMult;
        Console.SetCursorPosition(20, Math.Max(d.hand.Count(), p.hand.Count()) + 3);
        Console.WriteLine("Your remaining balance: " + p.balance);
        Console.WriteLine("");
    }

}