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
if(Age < 21) Console.WriteLine("Legal Age for Gambling in CA is 21"); return;

int FirstCardScore, SecondCardScore, TotalCardScore;

// Console.WriteLine("Welcome {0}! Your initial money is ${1}.", Name, PlayerMoney);
Console.WriteLine($"Welcome {Name}! Your initial money is ${PlayerMoney}.");
Console.WriteLine("1. New game");
Console.WriteLine("2. Continue");
Console.WriteLine("3. Exit");

Console.WriteLine("\nPlease type in menu option number.");
string SelectMenuOption = Console.ReadLine();

switch(SelectMenuOption)
{
    case "1": break;
    case "2": break;
    case "3": Console.WriteLine("Exiting BlackJack"); return;
}

Console.ReadKey();