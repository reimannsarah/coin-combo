using System;
using CoinCombo.Models;
// using System;
// using CoinCombo.Models;
using CoinCombo.UserInterfaceModels;
using System.Collections.Generic;
// using CoinCombo.UserInterfaceModels;

namespace CoinCombo
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to the:");
      Console.WriteLine($"{WelcomeBanner.Welcome}");
      GetChange();
    }
    static void GetChange()
    {
      Console.WriteLine("Enter a number you'd like to combinate");
      string input = Console.ReadLine();
      int amount = Int32.Parse(input);
      Register userInput = new Register(amount);
      PrintCoinAmts(userInput);
    }

    static void PrintCoinAmts(Register amount)
    {
      List<int> coins = amount.CoinCounter();
      Console.WriteLine($"{coins[0]} Quarters");
      Console.WriteLine($"{coins[1]} Dimes");
      Console.WriteLine($"{coins[2]} Nickels");
      Console.WriteLine($"{coins[3]} Pennies");
    }
  }
}