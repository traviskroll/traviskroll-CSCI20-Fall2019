//Travis Kroll
//9-19-19
//Asks a series of questions to the user to find out what kind of animal they are

using System;

class twentyquestions{

  string A,B,C,c,b,a;
//Runs through a series of questions that leads to a land animal
  public void Land ()
  {
    Console.WriteLine ("Would you rather eat plants or animals?");
    A = Console.ReadLine ();
    A = A.ToUpper ();
    if (A == "PLANTS")
    {
      Console.WriteLine ("Would you rather be big or small?");
      a = Console.ReadLine ();
      a = a.ToUpper ();
        if (a == "BIG")
        Console.WriteLine ("You are a Giraffe!");
        else
        Console.WriteLine ("You are a Koala Bear!");
    }
    else
    {
      Console.WriteLine ("Would you rather be big or small?");
      a = Console.ReadLine ();
      a = a.ToUpper ();
        if (a == "BIG")
        Console.WriteLine ("You are a Lion!");
        else
        Console.WriteLine ("You are a Snake!");
    }
  }
// Runs through a series of questions that leads to a Airborne animal
  public void Air ()
  {
    Console.WriteLine ("Would you rather eat plants or animals?");
    B = Console.ReadLine ();
    B = B.ToUpper ();
    if (B == "PLANTS")
    {
      Console.WriteLine ("Would you rather be big or small?");
      b = Console.ReadLine ();
      b = b.ToUpper ();
        if (b == "BIG")
        Console.WriteLine ("You Are A Duck!");
        else
        Console.WriteLine ("You are a Humming Bird!");
    }
    else{
      Console.WriteLine ("Would you rather be big or small?");
      b = Console.ReadLine ();
      b = b.ToUpper ();
        if (b == "BIG")
        Console.WriteLine ("You are an Eagle!");
        else
        Console.WriteLine ("You are a Hawk!");
    }
  }
//Runs through the various questions towards a sea animal
  public void Water ()
  {
    Console.WriteLine ("Would you rather eat plants or animals?");
    C = Console.ReadLine ();
    C = C.ToUpper ();
    if (C == "PLANTS")
    {
      Console.WriteLine ("Would you rather be big or small?");
      c = Console.ReadLine ();
      c = c.ToUpper ();
        if (b == "BIG")
        Console.WriteLine ("You are a Flatback Sea Turtle!");
        else
        Console.WriteLine ("You are a Horseshoe crab!");
    }
    else{
      Console.WriteLine ("Would you rather be big or small?");
      c = Console.ReadLine ();
      c = c.ToUpper ();
        if (b == "BIG")
        Console.WriteLine ("You are a Killer Whale!");
        else
        Console.WriteLine ("You are a Piranah!");
    }
  }
//Starts the series of questions that calls a land, sea, or air function
  public static void Main (){
    Console.WriteLine ("Would you like to Fly, Swim, or Run?");
    A = Console.ReadLine ();
    A = A.ToUpper ();
    switch (A)
    {
      case "FLY":
          Air ();
          break;
      case "RUN":
          Land ();
          break;
      case "SWIM":
          Water ();
          break;
      default:
          Console.WriteLine("Invalid option");
          break;
    }
  }
}
