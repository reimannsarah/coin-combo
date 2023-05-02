// using System;
using System.Collections.Generic;

namespace CoinCombo.Models
{
  public class Register
  {
    public int Change { get; set; }
    public static List<int> Coins = new List<int> {25, 10, 5, 1};
    
    public Register(int change)
    {
      Change = change;
    }
    public List<int> CoinCounter()
    {
      List<int> coinAmts = new List<int> {};
      int remainingChange = this.Change;
      foreach (int coin in Coins)
      {
      int coinAmt = (int)(remainingChange / coin);
      coinAmts.Add(coinAmt);
      remainingChange = remainingChange % coin;
      }
      return coinAmts;
    }
  }
}