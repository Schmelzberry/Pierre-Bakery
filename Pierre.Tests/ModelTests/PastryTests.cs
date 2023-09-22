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
    public void GetPricePastry_MultiplyPastryNumberByPrice_Int()
    { 
    
      //arrange
      Pastry testPastry = new Pastry(3);
      //act
      testPastry.GetPricePastry();
      int result = testPastry.NumberPastries * 2;
      //assert
      Assert.AreEqual(result, testPastry.GetPricePastry());
    }

     [TestMethod]
    public void GetDiscountPastry_CreateLoopThatCountsToUserInput_Array()
    { 
    // NEED TO REFACTOR USER INPUT TO BE AN ARRAY THAT COUNTS TO THE USERS
    // SPECIFIED NUMBER, THEN CAN SORT EVERY 4TH NUMBER AND RETURN NEW COUNT
    // THEN MULTIPLY NEW COUNT BY PASTRY PRICE
    // THIS STRUCTURE SHOULD WORK FOR BREAD TOO
      //arrange
      Pastry testPastry = new Pastry(4);
      //act
      testPastry.GetDiscountPastry();
      int result = testPastry.DiscountNumberPastries * 2;
      //assert
      Assert.AreEqual(result, testPastry.GetPricePastry());
    }

  }
}