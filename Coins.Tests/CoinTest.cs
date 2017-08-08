using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Coins.Models;
using System;

namespace Coins.Tests
{
  [TestClass]
  public class CoinTest : IDisposable
  {
  [TestMethod]
  public void ConvertToCoins_Convert1to1_1()
  {
    Coin testCoin = new Coin(1);
    List<object> expected = new List<object> {"1 pennies"};
    List<object> actual = testCoin.ConvertToCoins();
    CollectionAssert.AreEqual(expected, actual);
  }
  [TestMethod]
  public void ConvertToCoins_ConvertToFourPennies_4Pennies()
  {
    Coin testCoin = new Coin(4);
    List<object> expected = new List<object> {"4 pennies"};
    List<object> actual = testCoin.ConvertToCoins();
    CollectionAssert.AreEqual(expected,actual);
  }
  [TestMethod]
  public void ConvertToCoins_ConvertToNickel_1Nickel()
  {
    Coin testCoin = new Coin(5);
    List<object> expected = new List<object>{"1 nickels"};
    List<object> actual = testCoin.ConvertToCoins();
    CollectionAssert.AreEqual(expected,actual);
  }
  [TestMethod]
  public void ConvertToCoins_ConvertToNickelsAndPennies_1Pennies1Nickel()
  {
    Coin testCoin = new Coin(6);
    List<object> expected = new List<object>{"1 nickels", "1 pennies"};
    expected.ForEach(Console.WriteLine);
    List<object> actual = testCoin.ConvertToCoins();
    actual.ForEach(Console.WriteLine);
    CollectionAssert.AreEqual(expected, actual);
  }

  public void Dispose()
    {
      Coin.ClearAll();
    }
  }
}
