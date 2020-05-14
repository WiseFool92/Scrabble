using System;
using System.Collections.Generic;

namespace Scrabble.Model
{
  public class Logic
  {
    public static string Input {get; set;}
    public static Dictionary<int, List<string>> tileValue = new Dictionary<int, List<string>>();
    
    public void CreateKey()
    {
    List<string> valueOne = new List<string>();
    valueOne.Add("a");
    valueOne.Add("e");
    valueOne.Add("i");
    valueOne.Add("o");
    valueOne.Add("u");
    valueOne.Add("l");
    valueOne.Add("n");
    valueOne.Add("r");
    valueOne.Add("s");
    valueOne.Add("t");

    // List<string> valueTwo = new List<string>();
    // valueOne.Add("d");
    // valueOne.Add("g");

    // List<string> valueThree = new List<string>();
    
    tileValue.Add(1, valueOne);
    // tileValues.Add(2, valueTwo);
    }

    public static void GetValue()
    {
      Console.WriteLine("inside GetValue");
      foreach (KeyValuePair<int, List<string>> kvp in tileValue)
      {
        foreach (string value in kvp.Value)
        {
          Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, value);
        }
      }
    }

    public static void GetInput(string input)
    {
      Input = input.ToLower();
    }
  }
}