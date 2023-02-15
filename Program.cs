// start main
using System;
int userChoice = GetUserChoice(); //priming

//end main

//GetUserChoice
static int GetUserChoice()
{
    int userChoice = 0;

    DisplayMenu();
    if(IsValidChoice(userChoice)){
        return int.Parse(userChoice);
    }
    else return 0;

}

//DisplayMenu
static void DisplayMenu()
{
    Console.Clear();
    System.Console.WriteLine("Enter 1 to diplay full triangle\nEnter 2 to diplay partial triangle\nEnter 3 to exit");

}

//IsValidChoice
static bool IsValidChoice(string userInput)
{
    if(userInput=="1"  userInput=="2"  userInput=="3" ){
        return true;
    }
    return false;

}

//work the menus
 static void GetFull()
 {
     int number, i, j, count = 1;
     Console.Write("Enter ");
}

 static void GetPartial()
 {
     Random rnd = new Random();
     System.Console.Write(o);
 }

 static void SayInvalid()
 {
     System.Console.WriteLine("Invalid, try another number");
}

