// Triangular numbers are so called because of the equilateral triangular shape that they 
// occupy when laid out as dots. i.e.

// 1st (1)   2nd (3)    3rd (6)
// *          **        ***
//            *         **
//                      *

// You need to return the nth triangular number. You should return 0 for out of range values:

// For example: (Input --> Output)

// 0 --> 0
// 2 --> 3
// 3 --> 6
// -10 --> 0

// input is essentially the height, output is always height + (height - 1) + (height - 2)...
// use recursion to take TriangularTreasure.Calculate(n - 1) + n 
// until base case height == 1, then when n == 1, return n
// make sure to add conditional n < 1, return 0;

namespace Algorithms.Models;

public class TriangularTreasure
{
  public static int Calculate(int n) {
    if (n < 0) 
    {
      return 0;
    } 
    else if (n == 1)
    {
      return n;
    }
    else
    {
      return Calculate(n - 1) + n;
    }
  }
}