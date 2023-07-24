using Algorithms.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests;

[TestClass]
public class PigLatinTests
{
  [TestMethod]
  public void Calculate_WhenInputIsEmpty_Empty()
  {
    // Arrange
    string result = PigLatin.Calculate("");
    // Act

    // Assert
    Assert.AreEqual(result, "");
  }
}