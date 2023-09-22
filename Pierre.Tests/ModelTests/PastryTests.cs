using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
namespace Pierre.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    { //arrange
      Pastry testPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }

     [TestMethod]
    public void PastryNumber_CreatesInstanceOfPastryWithNumberRequested_Int()
    { //arrange
    //act
    //assert
      int customerOrder = 3;
      Pastry testPastry = new Pastry(customerOrder);
      int result = testPastry.customerOrder;
      Assert.AreEqual(customerOrder, result);
    }

  }
}