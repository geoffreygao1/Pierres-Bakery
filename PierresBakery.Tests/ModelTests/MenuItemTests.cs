using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierresBakery.Models;


namespace PierresBakery.Tests
{
  [TestClass]
  public class MenuItemTests : IDisposable
  {
    public void Dispose()
    {
      MenuItem.ClearAll();
    }
    // Test methods go here
    [TestMethod]
    public void Bread_ClassConstructor_Bread()
    {
      Bread test = new Bread();
      Assert.AreEqual(typeof(Bread), test.GetType());
    }

    [TestMethod]
    public void BreadPrice_GetPrice_Int()
    {
      Bread test = new Bread();
      Assert.AreEqual(5, test.Price);
    }

    [TestMethod]
    public void BreadBuyXGet1Free_GetPurchaseQuantityForDeal_Int()
    {
      Bread test = new Bread();
      Assert.AreEqual(2, test.BuyXGet1Free);
    }

    [TestMethod]
    public void BreadBuyXGet1Free_GetPriceOfInputOrderQuantity_Int()
    {
      Bread test = new Bread();
      Assert.AreEqual(10, test.getPrice(2));
    }
  }
}