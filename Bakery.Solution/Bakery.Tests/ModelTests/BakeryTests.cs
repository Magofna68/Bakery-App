using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryNameSpace;

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

      int totalBreadCost = BakeryNameSpace.BreadCost.GetBreadCost(1);

      Assert.AreEqual(expectedCost, totalBreadCost);
    }

    [TestMethod]
    public void GetBreadCost_CalculateQuantityCost_10()
    {
      int value;
      int breadCost = 5;
      int expectedCost = 10;
      int totalBreadCost = BakeryNameSpace.BreadCost.GetBreadCost(2);
      Assert.AreEqual(expectedCost, totalBreadCost);
    }

    [TestMethod]
    public void GetBreadCost_CalcFreeBread_15()
    {
      int value;
      int breadCost = 5;
      int expectedCost = 10;
      int totalBreadCost = BakeryNameSpace.BreadCost.GetBreadCost(3);
      Assert.AreEqual(expectedCost, totalBreadCost);
    }

    [TestMethod]
    public void GetBreadCost_EntireFunctionality_30()
    {
      int value;
      int breadCost = 5;
      int expectedCost = 30;
      int totalBreadCost = BakeryNameSpace.BreadCost.GetBreadCost(8);
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

      int totalPastryCost = BakeryNameSpace.PastryCost.GetPastryCost(1);

      Assert.AreEqual(expectedCost, totalPastryCost);
    }

    [TestMethod]
    public void GetPastryCost_VerifyDiscount_10()
    {
      int input;
      int pastryCost = 2;
      int expectedCost = 10;

      int totalPastryCost = BakeryNameSpace.PastryCost.GetPastryCost(6);

      Assert.AreEqual(expectedCost, totalPastryCost);
    }
  }
};