git//Travis Kroll 
//9-5-19
//This program will take and entered amount of $, apply a fee that coinstar would take out and return the amount of $ you'd recieve back and the amount of coins that made up the $ you entered. 

using System;

class CoinStar {
  public static void Main () {
    
    double Fee,Money,Act_Money,Change ;
    int Act_Change,Qtr,ChangeQtr,Dime,ChangeDime,ChangeNickel,Nickel,Penny ;
    string A;
    
    Fee = 0.109;

    //Requesting amount of $ to be processed in the program
    Console.WriteLine ("Hello World");
    Console.WriteLine ("Will you please enter an amount of $ to be processed by the machine.(please don't forget the decimal point)");
    A = Console.ReadLine ();
    Money = double.Parse(A); 
  
    //Converting the amount of $ to change
    Change = Money*100;
    Act_Change = (int) Change;

    //Finding and applying the "fee" for using the coinstar
    Act_Money = (Money-((Act_Change*Fee)/100));

    //Finding the amount of quarters in the Money
    Qtr = Act_Change/25;
    ChangeQtr = Act_Change%25;
  
    //Finding the amount of dimes 
    Dime = ChangeQtr/10;
    ChangeDime = ChangeQtr%10;

    //Finding the amount of nickels
    Nickel = ChangeDime/5;
    ChangeNickel = ChangeDime%5;

    //Finding the amount of pennies
    Penny = ChangeNickel/1;
    
    
    //Telling how many of each coin were entered 
    Console.WriteLine ("The amount of Quarters you had were "+Qtr+".");
    Console.WriteLine ("The amount of Dimes you had were "+Dime+".");
    Console.WriteLine ("The amount of Nickels you had were "+Nickel+".");
    Console.WriteLine ("The amount of Pennies you had were "+Penny+".");
  
    Console.WriteLine ("The amount of $ you entered was "+Money+" and the total $ tendered after the 10.9% fee is ${0:0.00}.",Act_Money);









  }
}