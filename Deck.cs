public class Deck 
{
    public List<Card> deck { get; }

    public Deck()
    {
        deck = new List<Card>(52);
        InitializeDeck();
        Console.WriteLine("Deck is filled");
    }

    private void InitializeDeck()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                deck.Add(new Card((Suit)i, (Face)j)); 
            }
        }
    }


    // public Card drawCard()
    // {
    //     Card card;

    //     var rand = new Random();


    //     return card;
    // }
}

