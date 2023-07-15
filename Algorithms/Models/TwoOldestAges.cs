// The two oldest ages function/method needs to be completed. It should take an array of 
// numbers as its argument and return the two highest numbers within the array. The returned 
// value should be an array in the format [second oldest age,  oldest age].
// The order of the numbers passed in could be any order. The array will always include at 
// least 2 items. If there are two or more oldest age, then return both of them in array format
// For example (Input --> Output):
// [1, 2, 10, 8] --> [8, 10]
// [1, 5, 87, 45, 8, 8] --> [45, 87]
// [1, 3, 10, 0]) --> [3, 10]
using System;
using System.Linq;

namespace Algorithms.Models
{
  public class TwoOldestAges
  {
    // take int[] arg1 as param to Calculate()
    public static int[] Calculate(int[] arg1)
    {      
      // use arg1.OrderBy(x => x) where x is saying order by arg1's own items
      // note: OrderBy is a LINQ method that returns an IOrderedEnumerable<T> object
      // thus we need to convert the return to an array using ToArray()
      int[] sortedArray = arg1.OrderBy(x => x).ToArray();

      // declare result and during instantiation, assign index 1
      // sortedArray[sortedArray.Length - 2] and index 2 sortedArray[sortedArray.Length - 1]  
      int[] result = new int[2] { sortedArray[sortedArray.Length - 2], sortedArray[sortedArray.Length - 1] };

      // return int[] result containing two highest nums from arg1[], from lowest to highest
      return result;
    }
  }
}