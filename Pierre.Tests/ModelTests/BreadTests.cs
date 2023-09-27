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
      //act
      testBread.GetPriceBread();
      int result = 10;
      //assert
      Assert.AreEqual(result, testBread.GetPriceBread());
    }
  }
}