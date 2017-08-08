using System;
using System.Collections.Generic;

namespace Coins.Models
{
  public class Coin
  {
    private int _amountOfCents;
    private static List<object> _returnChange = new List<object> {};

    public Coin(int amountOfCents)
    {
      _amountOfCents = amountOfCents;
    }

    public List<object> ConvertToCoins()
    {
      if (_amountOfCents >= 5 && _amountOfCents < 9)
      {
        int nickel = _amountOfCents / 5;
        _returnChange.Add(nickel + " nickels");

        if (_amountOfCents % 5 != 0)
        {
          int remainder = _amountOfCents % 5;

          if (remainder < 5)
          {
            int pennies = remainder / 1;
            _returnChange.Add(pennies + " pennies");
          }
        }
        return _returnChange;
      }
      else if (_amountOfCents < 5)
      {
        int pennies = _amountOfCents / 1;
        _returnChange.Add(pennies + " pennies");
      }
      return _returnChange;
    }

    public static void ClearAll()
    {
      _returnChange.Clear();
    }
  }
}
