using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Models;

namespace Algorithms.Tests;

[TestClass]
public class FactorialTests
{
  [TestMethod]
  public void Calculate_ReturnZero()
  {
    // Arrange

    // Act

    // Assert
    Assert.AreEqual(Factorials.Calculate(), 0);
  }
}