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
        [TestMethod]
    public void SetQuantity_SetQuantity_Quantity()
    {
      int quantity = 1;
      Pastry newPastry = new Pastry(quantity);
      int updatedQuantity = 2;
      newPastry.Quantity = updatedQuantity;
      int result = newPastry.Quantity;
      Assert.AreEqual(updatedQuantity, result);
    }
        [TestMethod]
    public void PastryCost_ReturnPastryRegularCost_Int()
    {
      int quantity = 1;
      double pastryCost = 2;
      Pastry newPastry = new Pastry(quantity);
      Assert.AreEqual(pastryCost, newPastry.PastryCost());
    }
    [TestMethod]
    public void PastryCost_ReturnPastryDealCost_Int()
    {
      int quantity = 3;
      double pastryCost = 5;
      Pastry newPastry = new Pastry(quantity);
      Assert.AreEqual(pastryCost, newPastry.PastryCost());
    }
  }
}
