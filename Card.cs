using System;
using System.Collections.Generic;

public enum Suit 
{
    Diamonds, Clubs, Hearts, Spades
}

public enum Face
{
    Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
}

public class Card
{
    public Suit Suit { get; } 
    public Face Face { get; }
    public int Value { get; set; }
    public string FaceName { get; }
    public char Symbol { get; }
    public ConsoleColor CardColor { get; set; }

    public Card(Suit suit, Face face)
    {
        Suit = suit;
        Face = face;

        // Setting Symbol and Color
        switch (Suit)
        {
            case Suit.Diamonds: Symbol = '♦'; CardColor = ConsoleColor.Red;
                break;
            case Suit.Hearts: Symbol = '♥'; CardColor = ConsoleColor.Red;
                break;
            case Suit.Spades: Symbol = '♠'; CardColor = ConsoleColor.White; // dark theme
                break;
            case Suit.Clubs: Symbol = '♣'; CardColor = ConsoleColor.White;
                break;
        }

        // Setting Value and FaceName
        switch (Face)
        {
            case Face.King:     
                Value = 10; FaceName = "K";
                break; 
            case Face.Queen:    
                Value = 10; FaceName = "Q";
                break;
            case Face.Jack:     
                Value = 10; FaceName = "J";
                break;
            case Face.Ten:      
                Value = 10; FaceName = "10"; 
                break;
            case Face.Nine:     
                Value = 9;  FaceName = "9";
                break;
            case Face.Eight:    
                Value = 8;  FaceName = "8";
                break;
            case Face.Seven:    
                Value = 7;  FaceName = "7";
                break;
            case Face.Six:
                Value = 6; FaceName = "6";
                break;
            case Face.Five:
                Value = 5; FaceName = "5";
                break;
            case Face.Four:
                Value = 4; FaceName = "4";
                break;
            case Face.Three:
                Value = 3; FaceName = "3";
                break;
            case Face.Two:
                Value = 2; FaceName = "2";
                break;
            case Face.Ace:
                Value = 1; FaceName = "Ace";
                break;

        }
    }

}