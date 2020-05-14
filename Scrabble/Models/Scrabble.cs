using System;
using System.Collections.Generic;
// using System.linq;

namespace Scrabble.Model
{
  public class Logic
  {
    public string Input {get; set;}
    public Dictionary<int, List<string>> tileValue = new Dictionary<int, List<string>> 
    {
      { 1, new List<string> {"a", "e", "i", "o", "u", "l", "n", "r", "s", "t"} }, 
      { 2, new List<string> {"d", "g"} }, 
      { 3, new List<string> {"b", "c", "m", "p"} }, 
      { 4, new List<string> {"f", "h", "v", "w", "y"} },  
      { 5, new List<string> {"k"} }, 
      { 8, new List<string> {"j", "x"} },
      { 10, new List<string> {"q", "z"} }  
    };

    public void GetInput(string input)
    {
      Input = input.ToLower();
    }

    public void GetValue()
    {
      foreach (KeyValuePair<int, List<string>> list in tileValue)
      {
        foreach (string value in list.Value)
        {
          Console.WriteLine("Key = {0}, Value = {1}", list.Key, value);
        }
      }
    }
  }
}