//Travis Kroll
//9-17-19
//This program will ask you a series of questions to tell you what kind of animal you could be

using system;
class twentyquestions{

  string A,B,C,c,b,a;

  public static void Land ()
  {
    Console.WriteLine ("Would you rather eat plants or animals?");
    A = command.ToUpper (Console.ReadLine ());
    if (A == "PLANTS")
    {
      Console.WriteLine ("Would you rather be big or small?");
      a = command.ToUpper (Console.ReadLine ());
        if (a == "BIG")
        Console.WriteLine ();
        else
    }
    else{

    }
  }
  public static void Air ()
  {
    Console.WriteLine ("Would you rather eat plants or animals?");
    B = command.ToUpper (Console.ReadLine ());
    if (B == "PLANTS")
    {
      Console.WriteLine ("Would you rather be big or small?");
      b = command.ToUpper (Console.ReadLine ());
        if (b == "BIG")
        Console.WriteLine ("You Are A Duck!");
        else
        Console.WriteLine ("You are a Humming Bird!");
    }
    else{
      Console.WriteLine ("Would you rather be big or small?");
      b = command.ToUpper (Console.ReadLine ());
        if (b == "BIG")
    }
  }
  public static void Water ()
  {
    Console.WriteLine ("Would you rather eat plants or animals?");
    C = command.ToUpper (Console.ReadLine ());
    if (C == "PLANTS")
    {
      Console.WriteLine ("Would you rather be big or small?");
      c = command.ToUpper (Console.ReadLine ());
        if (b == "BIG")
        Console.WriteLine ();
        else
    }
    else{

    }
  }
  public static void main (){
    Console.WriteLine ("Would you like to Fly, Swim, or Run?");
    A = command.ToUpper (Console.ReadLine ());
    switch (A)
    {
      case "FLY":
          handleAir ();
          break;
      case "RUN":
          handleLand ();
          break;
      case "SWIM":
          handleWater ();
          break;
      default:
          Console.WriteLine("Invalid option");
          break;
    }
  }
}
