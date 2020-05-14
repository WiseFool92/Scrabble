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
      // arrange
      Logic testTwo = new Logic();
      // act
      testTwo.GetValue();
      //assert
      Console.WriteLine(testTwo.tileValue[1]);
      Assert.AreEqual("testTwo.Dictionary[0]", testTwo.tileValue[1]);
      // Assert.AreEqual(testTwo.valueTwo, testTwo.tileValue[2]);
      // Assert.AreEqual(testTwo.valueThree, testTwo.tileValue[3]);
      // Assert.AreEqual(testTwo.valueFour, testTwo.tileValue[4]);
      // Assert.AreEqual(testTwo.valueFive, testTwo.tileValue[5]);
      // Assert.AreEqual(testTwo.valueEight, testTwo.tileValue[8]);
      // Assert.AreEqual(testTwo.valueTen, testTwo.tileValue[10]);
    }
  }
}