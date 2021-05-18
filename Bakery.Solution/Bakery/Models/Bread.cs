
namespace Bakery.Models
{
  public class Bread
  {
    public int breadNum { get; set; }
    public int breadPrice { get; }
    public Bread(int breadNum, int breadPrice)
    {
      breadNum = 0;
    }
    public static int GetBreadCost(int breadNum)
    {
      int breadPrice = 5;
      int totalFree = breadNum / 3;
      int totalBreadCost = (breadNum - totalFree) * breadPrice;

      return totalBreadCost;
    }
  }
}