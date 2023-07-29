// A Narcissistic Number (or Armstrong Number) is a positive number which is the 
// sum of its own digits, each raised to the power of the number of digits in a given 
// base. In this Kata, we will restrict ourselves to decimal (base 10).

// For example, take 153 (3 digits), which is narcissistic:

//     1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
// and 1652 (4 digits), which isn't:

//     1^4 + 6^4 + 5^4 + 2^4 = 1 + 1296 + 625 + 16 = 1938
// The Challenge:

// Your code must return true or false (not 'true' and 'false') depending upon whether 
// the given number is a Narcissistic number in base 10.

// This may be True and False in your language, e.g. PHP.

// Error checking for text strings or other invalid inputs is not required, only valid 
// positive non-zero integers will be passed into the function.

// input = 153
// output = true

// input = 1652
// output = false

// given n, check length of n, assign length of n to variable numLength which we will use to 
// raise each digit to the power of

// split n into its individual parts, ToString n, then use Split("") to turn into an array of
// individual nums

// create int sum;
// for each through all nums
// sum += Math.Pow(num, numLength);

// return sum == n;
// which should return true or false if n is a Narcissistic number

namespace Algorithms.Models;

class Narcissistic
{
  public static bool Calculate()
  {
    return true;
  }
}