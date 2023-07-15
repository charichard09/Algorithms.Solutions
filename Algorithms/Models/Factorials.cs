// A factorial is the product of numbers from 1 to n
// given int n, return the factorial of n
// if n is > 12 or < 0, throw an ArgumentOutOfRangeException
using System;

namespace Algorithms.Models;

public class Factorials
{
  public static int Calculate(int n)
  {
    // if n == 2, return 2
    if (n == 2)
    {
      return 2;
    } 
    // if n is > 12 or < 0, throw an ArgumentOutOfRangeException
    else if (n > 12 || n < 0)
    {
      throw new ArgumentOutOfRangeException(nameof(n), "Argument Out of Range, less than 0, or greater than 12");
    }
    else if (n == 0 || n == 1)
    {
      return 1;
    }

    // declare int sum = 2;
    int sum = 2;
    // for loop n times, start i at 3
    for (int i = 3; i <= n; i++)
    {
      // for each iteration, sum = sum * i 
      sum = sum * i;
    }

    // return sum
    return sum;
  }
}