using BakeryNameSpace;
using System;
using static System.Console;

public class Program
{
  public static void Main()
  {
    Write("\n");
    Write("\n");
    BackgroundColor = ConsoleColor.Black;
    Write("\n");
    WriteLine("Welcome to Pierre's Bakery!");
    WriteLine("At Pierre's we have both bread & pastry options available for you.");
    Write("\n");
    ForegroundColor = ConsoleColor.Yellow;
    WriteLine("- Bread: $5 per loaf, or buy 2 get one free!");
    Write("\n");
    BackgroundColor = ConsoleColor.Black;
    WriteLine("- Pastries: $2 each, or 3 for $5!");
    Write("\n");
    ForegroundColor = ConsoleColor.White;
    WriteLine("Please enter the quantity (loaves) you'd like to purchase : ");
    Write("\n");
    BackgroundColor = ConsoleColor.Black;
    int userInputB = Convert.ToInt16(ReadLine());
    var bCost = BreadCost.GetBreadCost(userInputB);
    Write("\n");
    WriteLine("Perfect! And the amount of pastries? : ");
    Write("\n");
    int userInputP = Convert.ToInt16(ReadLine());
    var pCost = PastryCost.GetPastryCost(userInputP);
    Write("\n");
    WriteLine("Thank you.");
    var finalPrice = TotalCost.GetTotalCost(pCost, bCost);
    ForegroundColor = ConsoleColor.Blue;
    Write("\n");
    Write("Your total ends up being: ${0} ", finalPrice);
    Read();
    Main();
  }
}