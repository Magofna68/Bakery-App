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
      char input = 'b';
      int expectedCost = 5;

      int returnedCost = BakeryNameSpace.BreadCost.GetBreadCost('b');

      Assert.AreEqual(expectedCost, returnedCost);
    }
  }
}