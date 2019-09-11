//Travis Kroll 
//9-10-19
//This program will take input from a "customer" and process/print a reciept with the number of oz, tip, tax, topping costs, discount, and total price. 

using System;
class YogurtShop {
  public static void Main () {
    
    double Original_Oz,NumberToppings,Discount,Tip,Tax,RealOz,OzPrice,TopPrice,TaxedTotal,TotalTax,RealDiscount,RealTip,FinalTotal,PreTip,PreDiscount;
    string A,B,C,D;
    
    Tax = .0725;
    
    //requesting info from the customer about their order
    Console.WriteLine ("Hello Customer!");
    Console.WriteLine ("How many Oz of yogurt would you like?");
    A = Console.ReadLine ();
    Original_Oz = double.Parse(A);

    Console.WriteLine ("How many toppings would you like? They cost 50 cents each.");
    B = Console.ReadLine ();
    NumberToppings = double.Parse(B);

    Console.WriteLine ("If you have a coupon please enter the percent of discount. For example if you have a 25% off, please just enter 25. If you don't have a coupon, please enter 0. The max discount is 50%!!");
    C = Console.ReadLine ();
    Discount = double.Parse(C);

    Console.WriteLine ("If you would like to give a tip please enter the percent you would like to tip. For example a 20% tip would be entered as 20. For no tip please enter 0.");
    D = Console.ReadLine ();
    Tip = double.Parse (D);

    //Computing different totals for the reciept 
    RealOz = (Original_Oz-.25);
    OzPrice = RealOz*.17;
    TopPrice = NumberToppings*.50;
    TotalTax = (OzPrice+TopPrice)*Tax;
    TaxedTotal = (OzPrice+TopPrice+TotalTax);

    //Applying tip and discount 
    PreDiscount = Discount/100;
    RealDiscount = TaxedTotal*PreDiscount;
    PreTip = Tip/100;
    RealTip = TaxedTotal*PreTip;

    //Calculating total 
    FinalTotal = TaxedTotal-RealDiscount+RealTip;

    //Printing out totals 
    Console.WriteLine ("# of Oz ordered without a cup: "+RealOz);
    Console.WriteLine ("Topping Costs: ${0:0.00}",TopPrice);
    Console.WriteLine ("Sales tax: ${0:0.00}",TotalTax);
    Console.WriteLine ("Your discount of "+Discount+"% saved you ${0:0.00}",RealDiscount);
    Console.WriteLine ("Your "+Tip+"% came out to a total of ${0:0.00}",RealTip);
    Console.WriteLine ("Your order came to a grand total of ${0:0.00}",FinalTotal);
    Console.WriteLine ("Thank you, come again soon!");
  }
}