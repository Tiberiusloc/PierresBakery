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
      int number = 1;
      Bread newBread = new Bread(number);
      int result = newBread.Number;
      Assert.AreEqual(number, result);
    }
    [TestMethod]
    public void SetNumber_SetNewNumber_Number()
    {
      int number = 1;
      Bread newBread = new Bread(number);
      int newNumber = 2;
      newBread.Number = newNumber;
      int result = newBread.Number;
      Assert.AreEqual(newNumber, result);
    }
  }
}
