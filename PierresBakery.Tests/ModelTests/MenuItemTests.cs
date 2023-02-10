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
      MenuItem test = new MenuItem();
      Assert.AreEqual(typeof(MenuItem), test.GetType());
    }

    [TestMethod]
    public void BreadPrice_GetPrice_Int()
    {
      MenuItem test = new MenuItem();
      Assert.AreEqual(5, test.Price);
    }

    [TestMethod]
    public void BuyXGet1Free_GetPurchaseQuantityForDeal_Int()
    {
      MenuItem test = new MenuItem();
      Assert.AreEqual(2, test.BuyXGet1Free);
    }
  }
}