using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Linq;


namespace BreadTests.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetNumber_ReturnNumber_Number()
    {
      int quantity = 1;
      Bread newBread = new Bread(quantity);
      int result = newBread.Quantity;
      Assert.AreEqual(quantity, result);
    }
    [TestMethod]
    public void SetNumber_SetNewNumber_Number()
    {
      int quantity = 1;
      Bread newBread = new Bread(quantity);
      int newQuantity = 2;
      newBread.Quantity = newQuantity;
      int result = newBread.Quantity;
      Assert.AreEqual(newQuantity, result);
    }
    [TestMethod]
    public void BreadCost_BreadCostRegularPrice_Int()
    {
      int quantity = 2;
      double breadCost = 10;
      Bread newBread = new Bread(quantity);
      Assert.AreEqual(breadCost, newBread.BreadCost());
    }
  }
}
