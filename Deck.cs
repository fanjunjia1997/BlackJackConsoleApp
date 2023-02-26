public class Deck 
{
    public List<Card> deck { get; }

    public Deck(int numDeck = 2)
    {
        deck = new List<Card>(52*numDeck);
        InitializeDeck(numDeck);
        //Console.WriteLine("Deck is filled");
    }

    private void InitializeDeck(int numDeck)
    {
        for (int n = 0; n < numDeck; n++)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    deck.Add(new Card((Suit)i, (Face)j));
                }
            }
        }
    }

    public int getDeckLength()
    {
        return deck.Count();
    }


    public void checkDeck()
    {
        for (int i = 0; i < deck.Count(); i++)
        {
            Console.Write(deck[i].Suit); Console.Write(deck[i].Face); Console.Write("\n");
        }
    }

    public Card drawCard()
    {
        Random rand = new Random();
        int deckIndex = rand.Next(0, deck.Count()-1);

        Card drawnCard = deck[deckIndex];

        deck.RemoveAt(deckIndex);
        return drawnCard;
    }
}

