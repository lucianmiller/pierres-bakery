using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(0);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetAmountBought_ReturnsAmountBought_Int()
    {
      //Arrange
      int amount = 10;

      //Act
      Bread newBread = new Bread(amount);
      int result = newBread.AmountBought;

      //Assert
      Assert.AreEqual(amount, result);
    }

    [TestMethod]
    public void GetCurrentPrice_ReturnsCurrentPriceFor0Bread_Int()
    {
      //Arrange
      int totalPrice = 0;

      //Act
      Bread newBread = new Bread(0);
      int result = newBread.CurrentPrice;

      //Assert
      Assert.AreEqual(totalPrice, result);
    }

    [TestMethod]
    public void BreadPrice_ReturnsPriceOfOneBread_Int()
    {
      //Arrange
      int totalPrice = 5;

      //Act
      Bread newBread = new Bread(1);
      newBread.BreadPrice();
      int result = newBread.CurrentPrice;

      //Assert
      Assert.AreEqual(totalPrice, result);
    }

    [TestMethod]
    public void BreadPrice_ReturnsPriceOfThreeBread_Int()
    {
      //Arrange
      int totalPrice = 10;
      
      //Act
      Bread newBread = new Bread(3);
      newBread.BreadPrice();
      int result = newBread.CurrentPrice;

      //Assert
      Assert.AreEqual(totalPrice, result);
    }
  }
}