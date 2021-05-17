using Bakery.Models;
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
    int breadNum = int.Parse(ReadLine());

    Write("\n");
    WriteLine("Perfect! And the amount of pastries? : ");
    Write("\n");
    int pQuantity = int.Parse(ReadLine());
    Write("\n");
    WriteLine("Thank you.");
    if (breadNum >= 0 && pQuantity >= 0)
    {
      Bread userSelectedB = new Bread(breadNum, 5);
      Pastry userSelectedP = new Pastry(pQuantity, 2);
      int finalPrice = (userSelectedB.GetBreadCost(breadNum) + userSelectedP.GetPastryCost(pQuantity));
      ForegroundColor = ConsoleColor.Blue;
      Write("\n");
      Write("Your total ends up being: ${0} ", finalPrice);
      Read();
      Main();
    }
  }
}