Console.WriteLine("WELCOME TO THE CASINO!!");

Console.WriteLine("Here's $100 on us");

RandNumGame();

//need to get user amount to save after rouhnd is over
static void RandNumGame()
{
    int userAmount = 100;
    int newUserAmount;

    Console.WriteLine($"Your Money: {userAmount}");
    
    Console.WriteLine("PICK A NUMBER 1 THROUGH 100");
    int userPick = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Choose An Amount to Bet: ");
    int userBet = Convert.ToInt32(Console.ReadLine());

    Thread.Sleep(1000);

    userAmount = userAmount - userBet;
    Console.WriteLine($"Your Money: {userAmount}");

    Thread.Sleep(1000);

    Console.WriteLine("ALL BETS CLOSED");

    Thread.Sleep(1000);

    Console.WriteLine("Here we GO!");

    Thread.Sleep(1000);

    Random rand = new Random();
    int theNumber = rand.Next(1, 100);
    Console.WriteLine($"THE NUMBER: {theNumber}");

    Thread.Sleep(1000);

    if ( userBet == theNumber )
    {
        Console.WriteLine("BIG WINNER!!");
        newUserAmount = userAmount + (userBet + userBet);
        Console.WriteLine($"Your Money: {userAmount}");
        Console.WriteLine("Play Again? Press 1");
        string playAgain = Console.ReadLine();
        if ( playAgain == "1")
        {
            RandNumGame();
        }
        else
        {
            return;
        }
    }
    else
    {
        newUserAmount = userAmount;
        Console.WriteLine("That's Unfortunate.");
        Console.WriteLine($"Your Money: {userAmount}");
        Console.WriteLine("Play Again? Press 1");
        string playAgain = Console.ReadLine();
        if (playAgain == "1")
        {
            RandNumGame();
        }
        else
        {
            return;
        }
    }
}