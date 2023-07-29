using Algorithms.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests;

[TestClass]
class NarcissisticTests
{
  [TestMethod]
  public void Calculate_WhenNIsOne_True()
  {
    // 

    // Act
    bool result = Narcissistic.Calculate(1);

    // Assert
    Assert.AreEqual(result, true);
  }
}