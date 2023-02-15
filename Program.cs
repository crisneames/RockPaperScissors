

bool gameStart = true;


    string rock = @"


    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)

";

    string paper = @"

     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)


";

    string scissors = @"

    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)


";

int playerWins = 0;
int computerWins = 0;

do
{
   
    
    Console.WriteLine($"------------------------------\nPlayer Wins : {playerWins} | Computer : {computerWins}\n ----------------------------- ");


    Console.WriteLine("What would you like to throw?\n1) Rock\n2 Paper\n3) Scissors");

    int input = Convert.ToInt32(Console.ReadLine());

    int computerInput = new Random().Next(1, 3);
    //Console.WriteLine($"Player Wins : {playerWins}\nComputer Wins: {computerWins}");



    // int input = Convert.ToInt32(Console.ReadLine());

    // int computerInput = new Random().Next(1, 3);
    Console.WriteLine("\nPLAYER");

    if (input == 1) {
        Console.WriteLine(rock);
    
    } else if (input == 2)
    {
        Console.WriteLine(paper);
    } else if (input == 3)
    {
        Console.WriteLine(scissors);

    } else
    {
        break;
    }

    Console.WriteLine("\nVs.");

    Console.WriteLine("\nCOMPUTER");

    if (computerInput == 1)
    {
        Console.WriteLine(rock);

    }
    else if (computerInput == 2)
    {
        Console.WriteLine(paper);
    }
    else if (computerInput == 3)
    {
        Console.WriteLine(scissors);

    }
    else
    {
        break;
    }

    if (input == 1 && computerInput == 3 || input == 2 && computerInput == 1 || input == 3 && computerInput == 2)
    {
        playerWins += 1;
    }
    else if (computerInput == 1 && input == 3 || computerInput == 2 && input == 1 || computerInput == 3 && input == 2)
    {
        computerWins += 1;
    }
    else {
        Console.WriteLine("DRAW!");
    }

    Console.ReadKey();
    Console.Clear();

    if (playerWins == 3)
    {
        Console.WriteLine("\r\n _______   __                                                __       __  __                      __ \r\n/       \\ /  |                                              /  |  _  /  |/  |                    /  |\r\n$$$$$$$  |$$ |  ______   __    __   ______    ______        $$ | / \\ $$ |$$/  _______    _______ $$ |\r\n$$ |__$$ |$$ | /      \\ /  |  /  | /      \\  /      \\       $$ |/$  \\$$ |/  |/       \\  /       |$$ |\r\n$$    $$/ $$ | $$$$$$  |$$ |  $$ |/$$$$$$  |/$$$$$$  |      $$ /$$$  $$ |$$ |$$$$$$$  |/$$$$$$$/ $$ |\r\n$$$$$$$/  $$ | /    $$ |$$ |  $$ |$$    $$ |$$ |  $$/       $$ $$/$$ $$ |$$ |$$ |  $$ |$$      \\ $$/ \r\n$$ |      $$ |/$$$$$$$ |$$ \\__$$ |$$$$$$$$/ $$ |            $$$$/  $$$$ |$$ |$$ |  $$ | $$$$$$  | __ \r\n$$ |      $$ |$$    $$ |$$    $$ |$$       |$$ |            $$$/    $$$ |$$ |$$ |  $$ |/     $$/ /  |\r\n$$/       $$/  $$$$$$$/  $$$$$$$ | $$$$$$$/ $$/             $$/      $$/ $$/ $$/   $$/ $$$$$$$/  $$/ \r\n                        /  \\__$$ |                                                                   \r\n                        $$    $$/                                                                    \r\n                         $$$$$$/                                                                     \r\n");
                 break;
    } else if(computerWins == 3)
    {
        Console.WriteLine("\r\n  ______                                                 __                                __       __  __                      __ \r\n /      \\                                               /  |                              /  |  _  /  |/  |                    /  |\r\n/$$$$$$  |  ______   _____  ____    ______   __    __  _$$ |_     ______    ______        $$ | / \\ $$ |$$/  _______    _______ $$ |\r\n$$ |  $$/  /      \\ /     \\/    \\  /      \\ /  |  /  |/ $$   |   /      \\  /      \\       $$ |/$  \\$$ |/  |/       \\  /       |$$ |\r\n$$ |      /$$$$$$  |$$$$$$ $$$$  |/$$$$$$  |$$ |  $$ |$$$$$$/   /$$$$$$  |/$$$$$$  |      $$ /$$$  $$ |$$ |$$$$$$$  |/$$$$$$$/ $$ |\r\n$$ |   __ $$ |  $$ |$$ | $$ | $$ |$$ |  $$ |$$ |  $$ |  $$ | __ $$    $$ |$$ |  $$/       $$ $$/$$ $$ |$$ |$$ |  $$ |$$      \\ $$/ \r\n$$ \\__/  |$$ \\__$$ |$$ | $$ | $$ |$$ |__$$ |$$ \\__$$ |  $$ |/  |$$$$$$$$/ $$ |            $$$$/  $$$$ |$$ |$$ |  $$ | $$$$$$  | __ \r\n$$    $$/ $$    $$/ $$ | $$ | $$ |$$    $$/ $$    $$/   $$  $$/ $$       |$$ |            $$$/    $$$ |$$ |$$ |  $$ |/     $$/ /  |\r\n $$$$$$/   $$$$$$/  $$/  $$/  $$/ $$$$$$$/   $$$$$$/     $$$$/   $$$$$$$/ $$/             $$/      $$/ $$/ $$/   $$/ $$$$$$$/  $$/ \r\n                                  $$ |                                                                                             \r\n                                  $$ |                                                                                             \r\n                                  $$/                                                                                              \r\n");
            break;
    } 
   
       
} while (gameStart == true);

