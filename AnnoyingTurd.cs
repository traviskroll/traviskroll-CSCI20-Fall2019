//Travis Kroll
//9-24-19
//prints out are we there yet the same amount of times that the kids age
using System;

class AnnoyingKid {

  public static void Main (string[] args) {

    int a;
    string A;

    //asks how old the turd is
    Console.WriteLine ("How old is your annoying turd bucket?");
    A = Console.ReadLine ();
    a = int.Parse(A);

    //prints a amount of times
    while(a > 0){
      Console.WriteLine("Are we there yet?");
      a = a-1;
    }

  }
}
