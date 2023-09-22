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
      Pastry testPastry = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }
     [TestMethod]
    public void PastryNumber_CreatesInstanceOfPastryWithNumberRequested_Int()
    { //arrange
    //act
    //assert
      Pastry testPastry = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }

     [TestMethod]
    public void GetPrice_MultiplyPastryNumberByPrice_Int()
    public void GetPricePastry_MultiplyPastryNumberByPrice_Int()
    { 

      //arrange
      Pastry testPastry = new Pastry(3);
      //act
      testPastry.GetPrice();
      testPastry.GetPricePastry();
      int result = testPastry.NumberPastries * 2;
      //assert
      Assert.AreEqual(result, testPastry.GetPrice());
      Assert.AreEqual(result, testPastry.GetPricePastry());
    }

  }
}