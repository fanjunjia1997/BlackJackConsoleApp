using System;
using System.Collections.Generic;

public enum RoundResult
{
    PLAYER_WIN,
    PLAYER_BUST,
    PLAYER_BLACKJACK,
    DEALER_WIN,
    PUSH
}


public class GameLogic
{

    public double payOutMult { get; }
    public RoundResult Result { get; set; }
    public string ResultMsg = "result msg null";

    public GameLogic(RoundResult r) 
    {
        Result = r; 

        switch (Result)
        {
            case RoundResult.PLAYER_WIN:
                payOutMult = 1.0;
                ResultMsg = "You win!";
                break;
            case RoundResult.PLAYER_BUST:
                payOutMult = -1.0;
                ResultMsg = "You bust!";
                break;
            case RoundResult.PLAYER_BLACKJACK:
                payOutMult = 1.5;
                ResultMsg = "Player Black Jack!";
                break;
            case RoundResult.DEALER_WIN:
                payOutMult = -1.0;
                ResultMsg = "Dealer Win!";
                break;
            case RoundResult.PUSH:
                payOutMult = 0;
                ResultMsg = "Push!";
                break;
        }
    
    }



}