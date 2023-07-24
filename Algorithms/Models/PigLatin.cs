// Move the first letter of each word to the end of it, 
// then add "ay" to the end of the word. 
// Leave punctuation marks untouched.

// input => "Pig latin is cool"
// output => "igPay atinlAy siay oolcay"

// input => "Hello World!"
// output => "elloHay orldWay!"
using System.Linq;


namespace Algorithms.Models;

public class PigLatin
{
  public static string Calculate(string input)
  {
    // input.Split(" ") entire string into individual words and assign to a string[] array
    string[] splitWord = input.Split(" ");
    
    // declare string result = "", which we will use to rebuild string as it is being modified
    string result = "";
    
    // declare char[] punctuation = [',', '.', ...]
    char[] punctuation = new char[] { ',', '.', '?', '!', ';', ':' };

    // iterate through string[] 
    // foreach word, move the first letter of each word to the end of it
    // then add "ay" to the end of the word. 
    for (int i = 0; i < splitWord.Length; i++)
    {
      // if (i != string[].Length - 1) { result += " " } add a space for every word but the last 
      if (i != 0)
      {
        result += " ";
      }
      // if (word.Length == 1) { result += word + "ay" }
      if (splitWord[i].Length == 1)
      {
        result += splitWord[i] + "ay";
      }
      // else if (punctuation.Any(c => c == word[word.length - 1])) result += word.SubString(1, word.Length - 2) + word[0] + "ay" + word[word.Length - 1];
      else if (punctuation.Any(c => c == splitWord[i][splitWord[i].Length - 1]))
      {
        result += splitWord[i].Substring(1, splitWord[i].Length - 2) + splitWord[i][0] + "ay" + splitWord[i][splitWord[i].Length - 1];
      }
      // else add word to result += word.SubString(1, word.Length) + word[0] + "ay";
      else 
      {
        result += splitWord[i].Substring(1, splitWord[i].Length - 1) + splitWord[i][0] + "ay";
      }
    }

    // return result
    return result;
  }
}