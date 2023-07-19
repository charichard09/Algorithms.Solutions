using Algorithms.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests;

[TestClass]
public class TriangularTreasureTests
{
  [TestMethod]
  public void Calculate_WhenNIsZero_Zero()
  {
    // Arrange
    int result = TriangularTreasure.Calculate(0);

    // Act

    // Assert
    Assert.AreEqual(result, 0);
  }

  [TestMethod]
  public void Calculate_WhenNIsNegativeOne_Zero()
  {
    // Arrange
    int result = TriangularTreasure.Calculate(-1);

    // Assert
    Assert.AreEqual(result, 0);
  }

  [TestMethod]
  public void Calculate_WhenNIsOne_One()
  {
    // Arrange
    int result = TriangularTreasure.Calculate(1);

    // Assert
    Assert.AreEqual(result, 1);
  }

  [TestMethod]
  public void Calculate_WhenNIsSix_Six()
  {
    // Arrange
    int result = TriangularTreasure.Calculate(3);

    // Assert
    Assert.AreEqual(result, 6);
  }
}