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
}