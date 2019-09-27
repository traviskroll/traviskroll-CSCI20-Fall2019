//Travis Kroll
//9-23-19
//This program will ask the user for their info and print them out a paystub
using System;

class Payroll {
  public static void Main (string[] args) {

    int Hours,Pos_Doubletime;
    string a,A,Name;
    double Rate,Doubletime_Pay, Gross_Total,Net_Total;

    //asking a user if they want to use the program
    Console.WriteLine ("Do you want to start another paystub? Yes or No");
    a = Console.ReadLine();
    A = a.ToUpper();
    while (A == "YES")
    {
      //Asking the user for their info
      Console.WriteLine ("What is the Employee's name?");
      Name = Console.ReadLine();
      Console.WriteLine ("How many hours did the employee work this week?");
      Hours = int.Parse(Console.ReadLine ());
      Console.WriteLine ("How much does this employee make an hour?");
      Rate = double.Parse(Console.ReadLine ());

      //Doing the math for the paystub
      Pos_Doubletime = Hours-40;
      Doubletime_Pay = Rate*1.5;

      //deciding on wether or no to add overtime
      if (Hours>40){
        Gross_Total = (40*Rate)+(Doubletime_Pay*Pos_Doubletime);
        Net_Total = Gross_Total-100;


      //Printing out inputs and totals for everything
        Console.WriteLine (Name+" worked "+Hours+" this week at {0:0.00}$ an hour.",Rate);
        Console.WriteLine (Name+" earned "+Pos_Doubletime+" hours overtime.");
        Console.WriteLine (Name+" earned {0:0.00}$ before healthcare insurance.", Gross_Total);
        Console.WriteLine (Name+" earned {0:0.00}$ this week.", Net_Total);
      }
      //decding on wether or not to add overtime
      if (Hours<=40){
        Gross_Total = (Hours*Rate);
        Net_Total = Gross_Total-100;

      //Printing out inputs and totals for everything
        Console.WriteLine (Name+" worked "+Hours+" this week at {0:0.00}$ an hour.",Rate);
        Console.WriteLine (Name+" earned {0:0.00}$ before healthcare insurance.", Gross_Total);
        Console.WriteLine (Name+" earned {0:0.00}$ this week.", Net_Total);
      }

      //asking the user if they want to restart with a new employee
      Console.WriteLine ("Do you want to submit another paystub? Yes or No?");
      a = Console.ReadLine();
      A = a.ToUpper();
    }

  }
}
