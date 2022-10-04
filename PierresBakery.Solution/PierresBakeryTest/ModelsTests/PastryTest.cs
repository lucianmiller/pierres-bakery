using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTest
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(0);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetAmountBought_ReturnsAmountBought_Int()
    {
      //Arrange
      int amount = 10;

      //Act
      Pastry newPastry = new Pastry(amount);
      int result = newPastry.AmountBought;

      //Assert
      Assert.AreEqual(amount, result);
    }
  }
}