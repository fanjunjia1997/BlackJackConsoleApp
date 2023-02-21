// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Message.WelcomePage(); Console.ReadKey(); Console.Clear();


Random rand = new Random();
int suitPick = rand.Next(1, 4);
Suit suit = Suit.Clubs;
switch (suitPick)
{
    case 1: suit = Suit.Diamonds; break;
    case 2: suit = Suit.Hearts; break;
    case 3: suit = Suit.Clubs; break;
    case 4: suit = Suit.Spades; break;
}

int facePick = rand.Next(13);
Face face = Face.Ace;
switch(facePick)
{
    case 1: face = Face.Ace; break;
    case 2: face = Face.Two; break;
    case 3: face = Face.Three; break;
    case 4: face = Face.Four; break;
    case 5: face = Face.Five; break;
    case 6: face = Face.Six; break;
    case 7: face = Face.Seven; break;
    case 8: face = Face.Eight; break;
    case 9: face = Face.Nine; break;
    case 10: face = Face.Ten; break;
    case 11: face = Face.Jack; break;
    case 12: face = Face.Queen; break;
    case 13: face = Face.King; break;
}

Card card = new Card(suit, face);
Console.WriteLine(card.Suit);
Console.WriteLine(card.Face);

//Deck deck = new Deck();


// Initialize Variables 
// string Name = "Unnamed";
// int Age = 0;
// int PlayerFirstCardScore = 0;
// int PlayerSecondCardScore = 0;
// int PlayerAdditionalCardScore = 0;
// int PlayerTotalCardScore = 0;
// int DealerFirstCardScore = 0;
// int DealerSecondCardScore = 0;
// int DealerAdditionalCardScore = 0;
// int DealerTotalCardScore = 0;
