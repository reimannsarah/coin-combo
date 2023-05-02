using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombo.Models;
using System.Collections.Generic;
using System;

namespace CoinCombo.Tests
{
  [TestClass]
  public class RegisterTests
  {
    [TestMethod]
    public void RegisterConstructor_CreatesInstanceOfRegister_Register()
    {
      Register newRegister = new Register(72);
      Assert.AreEqual(typeof(Register), newRegister.GetType());
    }

    [TestMethod]
    public void RegisterConstructor_StoresChangeAmt_Register()
    {
      int expected = 72;
      Register newRegister = new Register(72);
      Assert.AreEqual(expected, newRegister.Change);
    }

    [TestMethod]
    public void CoinCounter_CountsNumberOfCoinsEqualToChange_List()
    {
      List<int> expected = new List<int> {2, 2, 0, 2};
      Register newRegister = new Register(72);
      CollectionAssert.AreEqual(expected, newRegister.CoinCounter());
    }
  }
}