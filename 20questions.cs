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
    If (A == "PLANTS")
    {
      Console.WriteLine ("Would you rather be big or small?");
      a = command.ToUpper ();
    }
    else{

    }
  }
  public static void Air ()
  {
    Console.WriteLine ("Would you rather eat plants or animals?");
    B = command.ToUpper (Console.ReadLine ());
    If (B == "PLANTS")
    {
      Console.WriteLine ("Would you rather be big or small?");
      b = command.ToUpper ();
    }
    else{

    }
  }
  public static void Water ()
  {
    Console.WriteLine ("Would you rather eat plants or animals?");
    C = command.ToUpper (Console.ReadLine ());
    If (C == "PLANTS")
    {
      Console.WriteLine ("Would you rather be big or small?");
      c = command.ToUpper ();
    }
    else{

    }
  }
  public static void main (){
    Console.WriteLine ("Would you like to Fly, Swim, or Run?");
    A = command.ToUpper (Console.ReadLine ());
    switch ()
    {
      case "FLY":
          handleAir ();
      case "RUN":
          handleLand ();
      case "SWIM":
          handleWater ();
    }
  }
}
