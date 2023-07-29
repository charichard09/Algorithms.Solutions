using Algorithms.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests;

[TestClass]
public class NarcissisticTests
{
  [TestMethod]
  public void Calculate_WhenNIsOne_True()
  {
    // Arrange

    // Act
    bool result = Narcissistic.Calculate(1);

    // Assert
    Assert.AreEqual(true, result);
  }

  [TestMethod]
  public void Calculate_WhenNIsOneHundredFiftyThree_True()
  {
    // Arrange

    // Act
    bool result = Narcissistic.Calculate(153);

    // Assert
    Assert.AreEqual(true, result);
  }

  [TestMethod]
  public void Calculate_WhenNIs1652_False()
  {
    // Arrange

    // Act
    bool result = Narcissistic.Calculate(1652);

    // Assert 
    Assert.AreEqual(false, result);
  }
}