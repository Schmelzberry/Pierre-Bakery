using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;

namespace Pierre.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {// arrange
    Bread testBread = new Bread(3);
    Assert.AreEqual(typeof(Bread),
    testBread.GetType());
    }
    [TestMethod]
    public void BreadNumber_CreatesInstanceOfBreadWithNumberRequested_Int()
    { 
      //arrange
      Bread testBread = new Bread(3);
      //act
      int result = 3;
      //assert
      Assert.AreEqual(testBread.NumberBread, result);
    }
    [TestMethod]
    public void GetPriceBread_MultiplyBreadNumberByPriceAndDiscountThirdLoaf_Int()
    { 
    
      //arrange
      Bread testBread = new Bread(3);
      int breadPrice = 5;
      int discountedBread = 2;
      //act
      testBread.GetPriceBread();
      int result = breadPrice * discountedBread;
      //assert
      Assert.AreEqual(result, testBread.GetPriceBread());
    }
     [TestMethod]
    public void GetPriceBreadof0_MultiplyBreadNumberByZero_Int()
    { 
    
      //arrange
      Bread testBread = new Bread(0);
      int discountedBread = 0;
      //act
      testBread.GetPriceBread();
      int result = 0;
      //assert
      Assert.AreEqual(result, testBread.GetPriceBread());
    }
  }
}