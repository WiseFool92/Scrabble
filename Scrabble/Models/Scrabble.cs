using System;
using System.Collections.Generic;

namespace Scrabble.Model
{
  public class Logic
  {
    public static string Input {get; set;}
    // public static Dictionary<int, string> tileValues = new Dictionary<int, string>() {{1,"a", "e" , "i", "o", "u", "l", "n", "r", "s", "t"}, {2,"b"}, {3,"c"}};

    // public static string AssignValues()
    // {
    //   List<string> options = new List<string>{};
    // }
    
    public static void GetInput(string input)
    {
      Input = input.ToLower();
      // Console.WriteLine(tileValues[1]);
    }
  }
}