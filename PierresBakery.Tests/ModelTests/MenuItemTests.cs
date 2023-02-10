using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PierresBakery.Models;


namespace PierresBakery.Tests
{
  [TestClass]
  public class MenuItemTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
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
      Assert.AreEqual(10, test.getPrice(3));
      Assert.AreEqual(15, test.getPrice(4));
      Assert.AreEqual(20, test.getPrice(5));
      Assert.AreEqual(20, test.getPrice(6));
      Assert.AreEqual(25, test.getPrice(7));
    }

    [TestMethod]
    public void Pastry_ClassConstructor_Bread()
    {
      Pastry test = new Pastry();
      Assert.AreEqual(typeof(Pastry), test.GetType());
    }

    [TestMethod]
    public void PastryPrice_GetPrice_Int()
    {
      Pastry test = new Pastry();
      Assert.AreEqual(2, test.Price);
    }

    [TestMethod]
    public void PastryBuyXGet1Free_GetPurchaseQuantityForDeal_Int()
    {
      Pastry test = new Pastry();
      Assert.AreEqual(3, test.BuyXGet1Free);
    }
    [TestMethod]
    public void PastryBuyXGet1Free_GetPriceOfInputOrderQuantity_Int()
    {
      Pastry test = new Pastry();
      Assert.AreEqual(4, test.getPrice(2));
      Assert.AreEqual(6, test.getPrice(3));
      Assert.AreEqual(6, test.getPrice(4));
      Assert.AreEqual(8, test.getPrice(5));
      Assert.AreEqual(10, test.getPrice(6));
      Assert.AreEqual(12, test.getPrice(7));
      Assert.AreEqual(12, test.getPrice(8));
    }
    [TestMethod]
    public void Order_OrderConstructor_Order()
    {
      Pastry testItem = new Pastry();
      Order testOrder = new Order();
      testOrder.addToOrder(testItem, 1);
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void OrderItems_getOrderPrice_int()
    {
      Order testOrder = new Order();
      Pastry testPastry = new Pastry();
      Bread testBread = new Bread();
      testOrder.addToOrder(testPastry, 1);
      testOrder.addToOrder(testBread, 1);
      Assert.AreEqual(7, testOrder.getOrderPrice());
    }

    [TestMethod]
    public void OrderItems_getOrderPricewithDeals_int()
    {
      Order testOrder = new Order();
      Pastry testPastry = new Pastry();
      Bread testBread = new Bread();
      testOrder.addToOrder(testPastry, 4);
      testOrder.addToOrder(testBread, 1);
      Assert.AreEqual(11, testOrder.getOrderPrice());
    }

    [TestMethod]
    public void OrderItems_getOrderwithDuplicatesPrice_int()
    {
      Order testOrder = new Order();
      Pastry testPastry = new Pastry();
      Bread testBread = new Bread();
      testOrder.addToOrder(testPastry, 1);
      testOrder.addToOrder(testBread, 1);
      Bread dupBread = new Bread();
      testOrder.addToOrder(dupBread, 1);
      Assert.AreEqual(12, testOrder.getOrderPrice());
    }
  }
}