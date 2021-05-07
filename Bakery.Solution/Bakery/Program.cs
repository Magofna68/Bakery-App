using BakeryNameSpace;
using System;
using static System.Console;

public class Program
{
  public static void Main()
  {
    Write("\n");
    WriteLine("Welcome to our Bakery!");
    Write("\n");
    WriteLine("We have both bread & pastry options available for you.");
    WriteLine("Bread will cost you $5 per loaf, or buy 2 get one free!");
    WriteLine("Pastries will be $2 each or 3 for $5!");
    Write("\n");
    WriteLine("Please enter the quantity of loaves of bread you'd like to purchase : ");
    int userInputB = Convert.ToInt16(ReadLine());
    var bCost = BreadCost.GetBreadCost(userInputB);
    WriteLine("Perfect! And the amount of pastries? : ");
    int userInputP = Convert.ToInt16(ReadLine());
    var pCost = PastryCost.GetPastryCost(userInputP);
    // GetPastryCost(userInputP);
    WriteLine("Thank you.");
    // TotalCost Total = new TotalCost();
    // Total.GetTotalCost();
    var finalPrice = TotalCost.GetTotalCost(pCost, bCost);
    Write("Your total ends up being: $");
    Write(finalPrice);
    Read();
  }
}