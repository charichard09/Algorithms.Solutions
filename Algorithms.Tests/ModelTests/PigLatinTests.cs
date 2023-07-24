using Algorithms.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests;

[TestClass]
public class PigLatinTests
{
  [TestMethod]
  public void Calculate_WhenInputIsString_StringPlusAY()
  {
    // Arrange
    string result = PigLatin.Calculate("Hello World!");
    // Act

    // Assert
    Assert.AreEqual(result, "elloHay orldWay!");
  }
}