using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
namespace PastryTests.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
        [TestMethod]
    public void GetQuantity_ReturnQuantity_Quantity()
    {
      int quantity = 1;
      Pastry newPastry = new Pastry(quantity);
      int result = newPastry.Quantity;
      Assert.AreEqual(quantity, result);
    }
  }
}
