string welcomeart = @"
__        _______ _     ____ ___  __  __ _____   _____ ___  
\ \      / / ____| |   / ___/ _ \|  \/  | ____| |_   _/ _ \ 
 \ \ /\ / /|  _| | |  | |  | | | | |\/| |  _|     | || | | |
  \ V  V / | |___| |__| |__| |_| | |  | | |___    | || |_| |
 __\_/\_/  |_____|_____\____\___/|_|__|_|_____| _ |_|_\___/ 
|_   _| | | | ____|  / ___|  / \  / ___|_ _| \ | |/ _ \     
  | | | |_| |  _|   | |     / _ \ \___ \| ||  \| | | | |    
  | | |  _  | |___  | |___ / ___ \ ___) | || |\  | |_| |    
  |_| |_| |_|_____|  \____/_/   \_\____/___|_| \_|\___/     ";

string bigwinnerart = @"
 ____ ___ ____  __        _____ _   _ _   _ _____ ____  _ 
| __ )_ _/ ___| \ \      / /_ _| \ | | \ | | ____|  _ \| |
|  _ \| | |  _   \ \ /\ / / | ||  \| |  \| |  _| | |_) | |
| |_) | | |_| |   \ V  V /  | || |\  | |\  | |___|  _ <|_|
|____/___\____|    \_/\_/  |___|_| \_|_| \_|_____|_| \_(_)";

string betsclosedart = @"
 ____  _____ _____ ____     ____ _     ___  ____  _____ ____  
| __ )| ____|_   _/ ___|   / ___| |   / _ \/ ___|| ____|  _ \ 
|  _ \|  _|   | | \___ \  | |   | |  | | | \___ \|  _| | | | |
| |_) | |___  | |  ___) | | |___| |__| |_| |___) | |___| |_| |
|____/|_____| |_| |____/   \____|_____\___/|____/|_____|____/ ";


Console.WriteLine(welcomeart);

Console.WriteLine("Here's $100 on us");
int userAmount = 100;
RandNumGame(userAmount, bigwinnerart, betsclosedart);

static void RandNumGame(int userAmount, string bigwinnerart, string betsclosedart)
{
    Console.WriteLine($"Your Money: ${userAmount}");
    
    Console.WriteLine("PICK A NUMBER 1 THROUGH 25");
    int userPick = Convert.ToInt32(Console.ReadLine());

    if ( userPick  < 1 || userPick > 25)
    {
        Console.WriteLine("Thats an invalid choice. How about we try again.");
        RandNumGame(userAmount, bigwinnerart, betsclosedart);
    }    

    Console.WriteLine("Choose An Amount to Bet: ");
    int userBet = Convert.ToInt32(Console.ReadLine());

    if (userBet > userAmount || userBet <= 0)
    {
        Console.WriteLine("Thats an invalid bet. How about we try again. ");
        RandNumGame(userAmount, bigwinnerart, betsclosedart);
    }

    Thread.Sleep(1000);

    userAmount = userAmount - userBet;
    Console.WriteLine($"Your Money: ${userAmount}");

    Thread.Sleep(1000);

    Console.WriteLine(betsclosedart);

    Thread.Sleep(1000);

    Console.WriteLine("Here we GO!");

    Thread.Sleep(1000);

    Random rand = new Random();
    int theNumber = rand.Next(1, 26);
    //int theNumber = 1; //forcewin
    Console.WriteLine($"THE NUMBER: {theNumber}");

    Thread.Sleep(1000);

    if ( userPick == theNumber )
    {
        Console.WriteLine(bigwinnerart);
        userAmount += userBet * 2;
        Console.WriteLine($"Your Money: ${userAmount}");
        Console.WriteLine("Play Again? Press 1 || or press any key to quit and [ENTER].");
        string playAgain = Console.ReadLine();
        if ( playAgain == "1")
        {
            RandNumGame(userAmount, bigwinnerart, betsclosedart);
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
        Console.WriteLine("Play Again? Press 1 || or press any key to quit and [ENTER].");
        string playAgain = Console.ReadLine();
        if (playAgain == "1")
        {
            RandNumGame(userAmount, bigwinnerart, betsclosedart);
        }
        else
        {
            Console.WriteLine($"Thank you for playing! You leave with ${userAmount}");
        }
    }
}