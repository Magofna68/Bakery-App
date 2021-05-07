using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryNameSpace;

namespace BakeryNameSpaceTests //Change to match Title
{
  [TestClass]
  public class BakeryTests
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
      int totalBreadCost = BakeryNameSpace.BreadCost.GetBreadCost(0);
      Assert.AreEqual(expectedCost, totalBreadCost);
    }
  }
};