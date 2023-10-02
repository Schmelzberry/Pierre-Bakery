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
    { 
      Pastry testPastry = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }
     [TestMethod]
    public void PastryNumber_CreatesInstanceOfPastryWithNumberPastriesRequested_Int()
    { 
      Pastry testPastry = new Pastry(3);
      int result = 3;
      Assert.AreEqual(result, testPastry.NumberPastries);
    }
     [TestMethod]
    public void GetPricePastry_MultiplyPastryNumberByPriceAndDiscountFourthPastry_Int()
    { 
    
      //arrange
      Pastry testPastry = new Pastry(5);
      int pastryPrice = 2;
      int discountedPastries = 4;
      //act
      testPastry.GetPricePastry();
      int result = pastryPrice * discountedPastries;
      //assert
      Assert.AreEqual(result, testPastry.GetPricePastry());
    }

     [TestMethod]
    public void GetPricePastryof0_MultiplyPastryNumberByZero_Int()
    { 
    
      //arrange
      Pastry testPastry = new Pastry(0);
      int discountedPastries = 0;
      //act
      testPastry.GetPricePastry();
      int result = 0;
      //assert
      Assert.AreEqual(result, testPastry.GetPricePastry());
    }
    

  }
}