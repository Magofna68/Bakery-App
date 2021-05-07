using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryNameSpace;

namespace BakeryNameSpaceTests //Change to match Title
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadCost_VerifyCost_5()
    {
      int value;
      int breadCost;
      int expectedCost = 5;

      int returnedCost = BakeryNameSpace.BreadCost.GetBreadCost(1, 5);

      Assert.AreEqual(expectedCost, returnedCost);
    }

    // [TestMethod]
    // public void 
  }
};