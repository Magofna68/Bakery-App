using System.Collections.Generic;
using System;


namespace BakeryNameSpace
{
  public class BreadCost
  {
    public static int GetBreadCost(int userInputB)
    {
      int breadNum = userInputB;
      int breadCost = 5;

      int totalFree = userInputB / 3;
      int totalBreadCost = (breadNum - totalFree) * breadCost;

      return totalBreadCost;
    }
  }

  public class PastryCost
  {
    public static int GetPastryCost(int userInputP)
    {
      int pQuantity = userInputP;
      int pastryCost = 2;
      int discountNum = pQuantity / 3;
      int totalPastryCost = (pQuantity * pastryCost) - discountNum;

      return totalPastryCost;
    }
  }
  public class TotalCost
  {
    public static int GetTotalCost(int totalPastryCost, int totalBreadCost)
    {
      int finalPrice = totalPastryCost + totalBreadCost;

      return finalPrice;
    }
  }
}
