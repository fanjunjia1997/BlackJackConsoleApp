// See https://aka.ms/new-console-template for more information

Console.Title = "Black Jack The Game";
// Console.ForegroundColor = ConsoleColor.Yellow;
// Console.BackgroundColor = ConsoleColor.Red;
// Console.ResetColor();

/* Getting User Info */
Console.WriteLine("Please enter your name and press enter.");
string Name = "Unnamed";
Name = Console.ReadLine();

Console.WriteLine("Please enter your age."); 
int Age = 0;
Age = int.Parse(Console.ReadLine());

/* Initializing starting money*/
const double InitialMoney = 100.00;
double PlayerMoney = InitialMoney;

/* Control Flows */
if(Age < 21) 
{
    Console.WriteLine("Legal Age for Gambling in CA is 21"); 
    return;
}
 
// global variables 
int PlayerFirstCardScore = 0;
int PlayerSecondCardScore = 0;
int PlayerThirdCardScore = 0;
int PlayerTotalCardScore = 0;
int DealerFirstCardScore = 0;
int DealerSecondCardScore = 0;
int DealerThirdCardScore = 0;
int DealerTotalCardScore = 0;

// Console.WriteLine("Welcome {0}! Your initial money is ${1}.", Name, PlayerMoney);
Console.WriteLine($"Welcome {Name}! Your initial money is ${PlayerMoney}.");
Console.WriteLine("1. New game");
Console.WriteLine("2. Reset stats");
Console.WriteLine("3. Exit");

Console.WriteLine("\nPlease type in menu option number.");
string SelectMenuOption = Console.ReadLine();

switch(SelectMenuOption)
{
    case "1": 

        Console.WriteLine("Shuffling the deck...");
        Console.WriteLine("Done shuffling the deck...");
        Console.WriteLine("Serving the cards...");

        var RandomGenerator = new Random();

        // Player's hand
        PlayerFirstCardScore = RandomGenerator.Next(1,10);
        PlayerSecondCardScore = RandomGenerator.Next(1,10);



        var ShouldDeal = Console.ReadLine();
        if (ShouldDeal == "1")
        {
            PlayerThirdCardScore = RandomGenerator.Next(1, 10);
        }

        PlayerTotalCardScore = PlayerFirstCardScore + PlayerSecondCardScore + PlayerThirdCardScore;
        

        if (PlayerTotalCardScore > 21)
        {
            Console.WriteLine("You busted...\nGame over...\nPress any key to quit...");
            Console.ReadKey();
            break;
        }


        // Dealer's hand
        DealerFirstCardScore = RandomGenerator.Next(1,10);
        DealerSecondCardScore = RandomGenerator.Next(1,10);

        DealerTotalCardScore = DealerFirstCardScore + DealerSecondCardScore + DealerThirdCardScore;

        // Decision time
        Console.WriteLine($"Your first card score is: {PlayerFirstCardScore}");
        Console.WriteLine($"Your second card score is: {PlayerSecondCardScore}");
        Console.WriteLine($"Your third card score is: {PlayerThirdCardScore}");
        Console.WriteLine($"Your total card score is: {PlayerTotalCardScore}");
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine($"Dealer's first card score is: {DealerFirstCardScore}");
        Console.WriteLine($"Dealer's second card score is: {DealerSecondCardScore}");        
        Console.WriteLine($"Dealer total card score is: {DealerTotalCardScore}");
        Console.WriteLine("Do you want another card? \n1. Yes\n2. No"); 


        // Game Result
        if (PlayerTotalCardScore > DealerTotalCardScore){Console.WriteLine("You win!"); return;}
        else if (PlayerThirdCardScore == DealerThirdCardScore){Console.WriteLine("Tie.."); return;}
        else {Console.WriteLine("You lost!"); return;}
    
    case "2": 
        Console.WriteLine("Are you sure you want to reset your stats?\n1. Yes\n2. No");
        string PromptAnswer = Console.ReadLine();
        if (PromptAnswer == "1")
        {
            PlayerMoney = InitialMoney;
            Console.WriteLine($"Your money is reset to {PlayerMoney}.");
        }
        else if (PromptAnswer == "2")
        {
            Console.Write("Nothing happens. Need fix later.");
            //continue;
        }
        break;
    
    case "3": Console.WriteLine("Exiting BlackJack"); return;
}


Console.ReadKey();