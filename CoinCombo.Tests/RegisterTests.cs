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
      Register newRegister = new Register();
      Assert.AreEqual(typeof(Register), newRegister.GetType());
    }
  }
}