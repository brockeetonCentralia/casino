string art = @"
__        _______ _     ____ ___  __  __ _____   _____ ___  
\ \      / / ____| |   / ___/ _ \|  \/  | ____| |_   _/ _ \ 
 \ \ /\ / /|  _| | |  | |  | | | | |\/| |  _|     | || | | |
  \ V  V / | |___| |__| |__| |_| | |  | | |___    | || |_| |
 __\_/\_/  |_____|_____\____\___/|_|__|_|_____| _ |_|_\___/ 
|_   _| | | | ____|  / ___|  / \  / ___|_ _| \ | |/ _ \     
  | | | |_| |  _|   | |     / _ \ \___ \| ||  \| | | | |    
  | | |  _  | |___  | |___ / ___ \ ___) | || |\  | |_| |    
  |_| |_| |_|_____|  \____/_/   \_\____/___|_| \_|\___/     ";

Console.WriteLine(art);

Console.WriteLine("Here's $100 on us");
int userAmount = 100;
RandNumGame(userAmount);

static void RandNumGame(int userAmount)
{
    Console.WriteLine($"Your Money: ${userAmount}");
    
    Console.WriteLine("PICK A NUMBER 1 THROUGH 25");
    int userPick = Convert.ToInt32(Console.ReadLine());

    if ( userPick  < 1 || userPick > 25)
    {
        Console.WriteLine("Thats an invalid choice. How about we try again.");
        RandNumGame(userAmount);
    }    

    Console.WriteLine("Choose An Amount to Bet: ");
    int userBet = Convert.ToInt32(Console.ReadLine());

    if (userBet > userAmount || userBet <= 0)
    {
        Console.WriteLine("Thats an invalid bet. How about we try again. ");
        RandNumGame(userAmount);
    }

    Thread.Sleep(1000);

    userAmount = userAmount - userBet;
    Console.WriteLine($"Your Money: ${userAmount}");

    Thread.Sleep(1000);

    Console.WriteLine("ALL BETS CLOSED");

    Thread.Sleep(1000);

    Console.WriteLine("Here we GO!");

    Thread.Sleep(1000);

    Random rand = new Random();
    int theNumber = rand.Next(1, 26);
    Console.WriteLine($"THE NUMBER: {theNumber}");

    Thread.Sleep(1000);

    if ( userBet == theNumber )
    {
        Console.WriteLine("BIG WINNER!!");
        userAmount = userAmount + (userBet + userBet);
        Console.WriteLine($"Your Money: ${userAmount}");
        Console.WriteLine("Play Again? Press 1 || or press any key to quit.");
        string playAgain = Console.ReadLine();
        if ( playAgain == "1")
        {
            RandNumGame(userAmount);
        }
        else
        {
            Console.WriteLine($"Thank you for playing! You leave with ${userAmount}");
        }
    }
    else
    {
        Console.WriteLine("That's Unfortunate.");
        Console.WriteLine($"Your Money: {userAmount}");
        Console.WriteLine("Play Again? Press 1 || or press any key to quit.");
        string playAgain = Console.ReadLine();
        if (playAgain == "1")
        {
            RandNumGame(userAmount);
        }
        else
        {
            Console.WriteLine($"Thank you for playing! You leave with ${userAmount}");
        }
    }
}