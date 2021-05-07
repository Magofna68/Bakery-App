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

      int returnedCost = BakeryNameSpace.BreadCost.GetBreadCost(1);

      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void GetBreadCost_CalculateQuantityCost_15()
    {
      int value;
      int breadCost = 5;
      int expectedCost = 15;
      int returnedCost = BakeryNameSpace.BreadCost.GetBreadCost(1);
      Assert.AreEqual(expectedCost, returnedCost);
    }
  }
};