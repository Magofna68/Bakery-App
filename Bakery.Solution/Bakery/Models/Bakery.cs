using System.Collections.Generic;
using System;

namespace BakeryNameSpace
{
  public class BreadCost
  {
    int userInput;
    public static int GetBreadCost(int value)
    {
      int userInput = value;
      int breadCost = 5;

      int totalFree = userInput / 3;
      int totalBreadCost = (userInput - totalFree) * breadCost;

      return totalBreadCost;
    }
  }

  public class PastryCost
  {
    int pQuantity;
    public static int GetPastryCost(int input)
    {
      int pQuantity = input;
      int pastryCost = 2;
      int discountNum = pQuantity / 3;
      // double totalDiscount = discountNum * (.5);
      int totalPastryCost = (pQuantity * pastryCost) - discountNum;
      // int totalPastryCost = Convert.ToInt32(updatedPastryCost);

      return totalPastryCost;
    }
  }
}