// start main
int userChoice = GetUserChoice(); //priming
do 
{
    RouteEm(userChoice);
    userChoice = GetUserChoice();
} while (userChoice !=3);
//end main

//GetUserChoice
static int GetUserChoice()
{
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)){
        return int.Parse(userChoice);
    }
    else return 0;

}

//DisplayMenu
static void DisplayMenu()
{
    Console.Clear();
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");

}

//IsValidChoice
static bool IsValidChoice(string userInput)
{
    if(userInput == "1" || userInput == "2" || userInput == "3" ){
        return true;
    }
    return false;

}

//work the menus
//GetFull
 static void GetFull()
 {
     Random rand = new Random();
     int number = rand.Next(3, 10); //should generate random rows
     for(int e = 1; e <= number; e++) {
        for(int g = 1; g <= e; g++)
            System.Console.WriteLine("* ");
            System.Console.WriteLine();
     }
     PauseAction();
}

//GetPartial
 static void GetPartial()
 {
     Random rand = new Random();
     int rows = rand.Next(3, 10);
     for(int e = 1; e <= rows; e++) {
        for(int g = 1; g <= e; g++) {
            if(g == 1 || e == g || e == rows) {
                System.Console.WriteLine("* ");
            }
            else {
                int number = new Random().Next(2);
                if(number == 0) {
                    System.Console.WriteLine("* ");
                }
            else {
                System.Console.WriteLine("  ");
            }
            }
        }
        System.Console.WriteLine();
    }
    PauseAction();
 }

//SayInvalid
 static void SayInvalid()
 {
     System.Console.WriteLine("Invalid, try another input");
     PauseAction();
}

//RouteEm
static void RouteEm(int menuChoice) 
{
    if(menuChoice == 1){
        GetFull();
    }
    else if(menuChoice == 2){
        GetPartial();
    }
    else if(menuChoice != 3){
        SayInvalid();
    }
}

//The Pause thing
static void PauseAction()
{
    System.Console.WriteLine("Press any key to continue:");
    Console.ReadKey();
}