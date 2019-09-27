//Travis Kroll
//9-26-19
//This will take user inputs and calculate the population of foxes and rabits for a specific year in the future

using System;

class FoxesAndRabbits {
  public static void Main (string[] args) {

    double Foxes,Rabbits,Year,FutureYear,B_Fox,B_Rab,D_Fox,D_Rab,RabbitsForYear,FoxesForYear,CurrentYear;
    int Fox,Rab;

    //Establishing Static Variables
    B_Rab = .2;
    D_Rab = .005;
    B_Fox = .001;
    D_Fox = .2;
    CurrentYear = 2019;

    //Establishing Year and initial populations to guesstimate for
    Console.WriteLine ("Please enter the year you would like to calculate the population of foxes and rabbits for");
    Year = double.Parse(Console.ReadLine());

    Console.WriteLine("What is the current population of foxes in some area?");
    Foxes = double.Parse(Console.ReadLine());

    Console.WriteLine ("What is the current population of rabbits in some area?");
    Rabbits = double.Parse(Console.ReadLine());

    //Running through calculations for my years
    for(FutureYear=Year-2019;FutureYear>0;FutureYear=FutureYear-10)
    {
      RabbitsForYear = (Rabbits)+(Rabbits*B_Rab)-(Rabbits*(Foxes*D_Rab));
      FoxesForYear = Foxes+(Foxes*(Rabbits*B_Fox))-(Foxes*D_Fox);

      Rab = (int)RabbitsForYear;
      Fox = (int)FoxesForYear;

      //Printing out the # of rabbits and foxes for each year
      Console.WriteLine (Rab+" is the current population of rabbits for that area in "+CurrentYear);
      Console.WriteLine (Fox+" is the current population of foxes for that area in "+CurrentYear);


      CurrentYear=CurrentYear+10;
      Rabbits = RabbitsForYear;
      Foxes = FoxesForYear;

    }

  }
}
