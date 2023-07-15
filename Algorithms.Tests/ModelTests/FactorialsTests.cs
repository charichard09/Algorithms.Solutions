using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Models;
using System;

namespace Algorithms.Tests;

[TestClass]
public class FactorialTests
{
  [TestMethod]
  public void Calculate_NIsTwo_ReturnTwo()
  {
    // Arrange

    // Act
    int result = Factorials.Calculate(2);

    // Assert
    Assert.AreEqual(result, 2);
  }

  [TestMethod]
  public void Calculate_WhenNIsOutOfRangeAboveTwelve_ThrowOutOfRangeException()
  {
    // Arrange
    int n = 13;

    // Act

    // Assert
    Assert.ThrowsException<ArgumentOutOfRangeException>(() => Factorials.Calculate(n));
  }

  [TestMethod]
  public void Calculate_WhenNIsOutOfRangeBelowZero_ThrowOutOfRangeException()
  {
    // Arrange
    int n = -1;

    // Act

    // Assert
    Assert.ThrowsException<ArgumentOutOfRangeException>(() => Factorials.Calculate(n));
  }

  [TestMethod]
  public void Calculate_WhenNIsFive_OneHundredTwenty()
  {
    // Arrange
    int n = 5;

    // Act
    int result = Factorials.Calculate(n);

    // Assert
    Assert.AreEqual(result, 120);
  }

  [TestMethod]
  public void Calculate_WhenNIsZero_One()
  {
    // Arrange
    int n = 0;

    // Act
    int result = Factorials.Calculate(n);

    // Assert
    Assert.AreEqual(result, 1);
  }
}