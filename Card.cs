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
    public int value { get; set; }
    public string FaceName { get; } = "";
    public char Symbol { get; }
    public ConsoleColor cardColor { get; set; }

    public Card(Suit suit, Face face)
    {
        Suit = suit;
        Face = face;

        // Setting Symbol and Color
        switch (Suit)
        {
            case Suit.Diamonds: Symbol = '♦'; cardColor = ConsoleColor.Red;
                break;
            case Suit.Hearts: Symbol = '♥'; cardColor = ConsoleColor.Red;
                break;
            case Suit.Spades: Symbol = '♠'; cardColor = ConsoleColor.White; // dark theme
                break;
            case Suit.Clubs: Symbol = '♣'; cardColor = ConsoleColor.White;
                break;
        }

        // Setting Value and FaceName
        switch (Face)
        {
            case Face.King:     
                value = 10; FaceName = "K";
                break; 
            case Face.Queen:    
                value = 10; FaceName = "Q";
                break;
            case Face.Jack:     
                value = 10; FaceName = "J";
                break;
            case Face.Ten:      
                value = 10; FaceName = "10"; 
                break;
            case Face.Nine:     
                value = 9;  FaceName = "9";
                break;
            case Face.Eight:    
                value = 8;  FaceName = "8";
                break;
            case Face.Seven:    
                value = 7;  FaceName = "7";
                break;
            case Face.Six:
                value = 6; FaceName = "6";
                break;
            case Face.Five:
                value = 5; FaceName = "5";
                break;
            case Face.Four:
                value = 4; FaceName = "4";
                break;
            case Face.Three:
                value = 3; FaceName = "3";
                break;
            case Face.Two:
                value = 2; FaceName = "2";
                break;
            case Face.Ace:
                value = 1; FaceName = "Ace";
                break;

        }
    }

}