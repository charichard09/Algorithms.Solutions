using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Models;

namespace Algorithms.Tests
{
  [TestClass]
  public class TwoOldestAgesTests
  {
    // Test methods go here
    [TestMethod]
    public void Calculate_ReturnResultArray_LengthOfTwo()
    {
      // A
      int[] result = new int[2];
      result = TwoOldestAges.Calculate(new int[] { 1, 2, 10, 8 });

      // Act

      // Assert
      Assert.AreEqual(result.Length, 2);
    }

    [TestMethod]
    public void Calculate_ReturnTwoHighestValuesOfArg1_ArrayOfEightAndTen() {
      // Arrange
      int[] test = new int[4] { 1, 2, 10, 8 };

      // Act
      int[] result = TwoOldestAges.Calculate(test);

      // Assert
      CollectionAssert.AreEqual(result, new int[] { 8, 10 });
    }
  }
}