// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Message.WelcomePage(); Console.ReadKey(); Console.Clear();
Console.WriteLine("What is your name?");
string playerName = "";
playerName = Console.ReadLine();
Console.Clear();

Player p = new Player(playerName);
Dealer dealer = new Dealer("Dealer");

Message.InitializeGame();
double betAmount = Message.BetMessage(p);

Deck deck = new Deck();

p.getCard(deck.drawCard());
dealer.getCard(deck.drawCard());
p.getCard(deck.drawCard());
dealer.getCard(deck.drawCard());

Message.ShowHandMessage(p, dealer, true);


// Player's turn
Message.HitMessage();
var hitDecision = Console.ReadLine();

if (hitDecision == "1")
{
    do
    {
        Console.Clear();
        p.hitCard(deck);
        Message.ShowHandMessage(p, dealer, true);
        if (p.getHandValue() > 21)
        {
            hitDecision = "0";
        }
        else 
        {
            Console.WriteLine("\n\nHit / Stand? \n 1) Hit \n 2) Stand");
            hitDecision = Console.ReadLine();
        }
    } while (hitDecision == "1");
}


// Dealer's turn
// show hole card 
Console.Clear();
Message.ShowHandMessage(p, dealer, false);    
dealer.hitCard(deck, p);
//Console.WriteLine("Cards left in the deck: " + deck.getDeckLength());

// Calculating results
GameLogic gameLogic = new GameLogic(getGameResult(p, dealer));
System.Threading.Thread.Sleep(1000);
Message.PayoutMessage(gameLogic, p, dealer, betAmount);

Console.ReadKey();


// Helpers
static RoundResult getGameResult(Player p, Dealer d)
{
    if (p.getHandValue() > 21) { return RoundResult.PLAYER_BUST; }
    else if (p.hand[0].value == 1 && p.hand[1].value == 10) { return RoundResult.PLAYER_BLACKJACK; }
    else if (p.hand[0].value == 10 && p.hand[1].value == 1) { return RoundResult.PLAYER_BLACKJACK; }
    else if (d.getHandValue() > 21) { return RoundResult.PLAYER_WIN; }
    else if (p.getHandValue() > d.getHandValue()) { return RoundResult.PLAYER_WIN; }
    else if (p.getHandValue() == d.getHandValue()) { return RoundResult.PUSH; }
    else { return RoundResult.DEALER_WIN; }
}

