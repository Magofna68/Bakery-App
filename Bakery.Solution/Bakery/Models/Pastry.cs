namespace Bakery.Models
{
  public class Pastry
  {
    public int pQuantity { get; set; }
    public int pPrice { get; }
    public Pastry(int pQuantity, int pPrice)
    {
      pQuantity = 0;
    }
    public int GetPastryCost(int pQuantity)
    {
      int pPrice = 2;
      int discountNum = pQuantity / 3;
      int totalPastryCost = (pQuantity * pPrice) - discountNum;

      return totalPastryCost;
    }
  }
}