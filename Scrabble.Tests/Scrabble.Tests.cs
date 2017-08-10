using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System.Collections.Generic;
using System;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void GetLetterScore_GetAppropriateScoreOfOneScore_True()
    {
      //Arrange
      ScrabbleGame testScrabble = new ScrabbleGame('A');
      int expected = 1;
      //Act
      int actual = testScrabble.GetLetterScore();
      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetLetterScore_GetAppropriateScoreOfAnyLetter_True()
    {
      //Arrange
      ScrabbleGame testScrabble = new ScrabbleGame('K');
      int expected = 5;
      //Act
      int actual = testScrabble.GetLetterScore();
      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetWordScore_GetTotalWordScore_True()
    {
      //Arrange
      ScrabbleGame testScrabble = new ScrabbleGame("jonathan");
      int expected = 18;
      //Act
      int actual = testScrabble.GetWordScore();
      //Assert
      Assert.AreEqual(expected, actual);
    }
  }
}
