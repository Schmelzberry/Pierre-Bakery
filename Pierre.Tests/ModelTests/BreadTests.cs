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
    Bread testBread = new Bread(4);
    Assert.AreEqual(typeof(Bread),
    testBread.GetType());
    }
  }
}