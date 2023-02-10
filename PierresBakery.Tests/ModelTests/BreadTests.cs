using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierresBakery.Models;


namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
    }
    // Test methods go here
    [TestMethod]
    public void Bread_ClassConstructor_Bread()
    {
      Bread test = new Bread();
      Assert.AreEqual(typeof(Bread), test.GetType());
    }
  }
}