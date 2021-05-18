using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace BakeryNameSpaceTests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void GetBreadCost_VerifyCost_5()
    {
      int value;
      int breadCost = 5;
      int expectedCost = 5;

      int totalBreadCost = Bakery.Models.Bread.GetBreadCost(1);

      Assert.AreEqual(expectedCost, totalBreadCost);
    }

    [TestMethod]
    public void GetBreadCost_CalculateQuantityCost_10()
    {
      int value;
      int breadCost = 5;
      int expectedCost = 10;
      int totalBreadCost = Bakery.Models.Bread.GetBreadCost(2);
      Assert.AreEqual(expectedCost, totalBreadCost);
    }

    [TestMethod]
    public void GetBreadCost_CalcFreeBread_15()
    {
      int value;
      int breadCost = 5;
      int expectedCost = 10;
      int totalBreadCost = Bakery.Models.Bread.GetBreadCost(3);
      Assert.AreEqual(expectedCost, totalBreadCost);
    }

    [TestMethod]
    public void GetBreadCost_EntireFunctionality_30()
    {
      int value;
      int breadCost = 5;
      int expectedCost = 30;
      int totalBreadCost = Bread.GetBreadCost(8);
      Assert.AreEqual(expectedCost, totalBreadCost);
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void GetPastryCost_VerifyCost_2()
    {
      int input;
      int pastryCost = 2;
      int expectedCost = 2;

      int totalPastryCost = Bakery.Models.Pastry.GetPastryCost(1);

      Assert.AreEqual(expectedCost, totalPastryCost);
    }

    [TestMethod]
    public void GetPastryCost_VerifyDiscount_15()
    {
      int input;
      int pastryCost = 2;
      int expectedCost = 15;

      int totalPastryCost = Bakery.Models.Pastry.GetPastryCost(9);

      Assert.AreEqual(expectedCost, totalPastryCost);
    }

    [TestMethod]
    public void GetPastryCost_VerifyAccuratePricing_12()
    {
      int input;
      int pastryCost = 2;
      int expectedCost = 12;

      int totalPastryCost = Bakery.Models.Pastry.GetPastryCost(7);

      Assert.AreEqual(expectedCost, totalPastryCost);
    }
  }
};