class Participant
{
    public string Name { get; set; }
    public List<Card> hand = new List<Card>();

    public Participant(string _name) { Name = _name; }

    public void getCard(Card card)
    {
        hand.Add(card);
    }

    private int handVal = 0;
    public int getHandValue() 
    {
        handVal = 0;
        var aceCounter = 0;
        foreach (Card c in hand)
        {
            if (c.Face == Face.Ace)
            {
                handVal += 11;
                aceCounter++;
            }
            else
            {
                handVal += c.value;
            }

        }

        while (handVal > 21 && aceCounter > 0)
        {
            handVal -= 10;
            aceCounter--;
        }

        return handVal;
     }

    public virtual void showHand(int cursorLeftOffset, bool dealerFirstRound) 
    {
        foreach (Card c in hand)
        {
            Console.CursorLeft = cursorLeftOffset;
            Console.ForegroundColor = c.cardColor;
            Console.WriteLine(c.Symbol + " " + c.FaceName);
            Console.ResetColor();
        }
    }


    public bool isBlackJack()
    {
        if (hand[0].value == 10 && hand[1].value == 1) { return true; } // Face Card + Ace
        else if (hand[0].value == 1 & hand[1].value == 10) { return true; } // Ace + Face Card
        else { return false; }
    } 

}



class Player : Participant
{
    public double balance { get; set; } = 100.00;

    public Player(string _name) : base(_name) { }

    public override void showHand(int cursorLeftOffset, bool dealerFirstRound = false)
    {
        base.showHand(cursorLeftOffset=10, false);
    }

    public void hitCard(Deck deck)
    {
        hand.Add(deck.drawCard());
    }
}


class Dealer : Participant
{
    public Dealer(string _name) : base(_name) { }

    public override void showHand(int cursorLeftOffset, bool dealerFirstRound)
    {
        // Don't want to show the second card dealer has during the first round
        if (dealerFirstRound == true)
        {
            Console.CursorLeft = cursorLeftOffset;
            Console.ForegroundColor = hand[0].cardColor;
            Console.WriteLine(hand[0].Symbol + " " + hand[0].FaceName);
            Console.ResetColor();
            Console.CursorLeft = cursorLeftOffset;
            Console.WriteLine("<Hole Card>");
        }
        else 
        {
            base.showHand(cursorLeftOffset = 40, dealerFirstRound = false);
        }
    }


    public void hitCard(Deck deck, Player p)
    {
        
        if (this.getHandValue() >= 17)
        {
            return;
        }
        else 
        {
            while (this.getHandValue() < 17 && p.getHandValue() <= 21)
            {
                hand.Add(deck.drawCard());
                System.Threading.Thread.Sleep(1000);
                Message.ShowHandMessage(p, this, false);
            }
        }
    }

}