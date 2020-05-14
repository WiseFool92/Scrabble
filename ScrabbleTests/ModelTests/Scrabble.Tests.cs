using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Model;

namespace Scrabble.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {

    }
    [TestMethod]
    public void UserInput_IsUserInputAString_True()
    {
      // Arrange
      Logic testOne = new Logic();
      // Act
      testOne.GetInput("string");
      // Assert
      Assert.AreEqual(typeof(string), testOne.Input.GetType());
    }

    [TestMethod]
    public void Dictionary_CreateKey_DictionaryValues()
    {
      // Arrange
      Logic testTwo = new Logic();
      // Act
      testTwo.GetValue();
      // Assert
      Console.WriteLine(testTwo.tileValue[1]);
      Assert.AreEqual("testTwo.Dictionary[0]", testTwo.tileValue[1]);
    }
  }
}