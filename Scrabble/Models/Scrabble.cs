using System;
using System.Collections.Generic;

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

    // public List<string> valueOne = new List<string>() {"a", "e", "i", "o", "u", "l", "n", "r", "s", "t"};
    // public List<string> valueTwo = new List<string>() {"d", "g"};
    // public List<string> valueThree = new List<string>();
    // public List<string> valueFour = new List<string>();
    // public List<string> valueFive = new List<string>();
    // public List<string> valueEight = new List<string>();
    // public List<string> valueTen = new List<string>();
    
    // public void CreateKey()
    // {
    //   Logic list = new Logic();
    //   valueOne.Add("a");
    //   valueOne.Add("e");
    //   valueOne.Add("i");
    //   valueOne.Add("o");
    //   valueOne.Add("u");
    //   valueOne.Add("l");
    //   valueOne.Add("n");
    //   valueOne.Add("r");
    //   valueOne.Add("s");
    //   valueOne.Add("t");

    //   valueTwo.Add("d");
    //   valueTwo.Add("g");

    //   valueThree.Add("b");
    //   valueThree.Add("c");
    //   valueThree.Add("m");
    //   valueThree.Add("p");

    //   valueFour.Add("f");
    //   valueFour.Add("h");
    //   valueFour.Add("v");
    //   valueFour.Add("w");
    //   valueFour.Add("y");

    //   valueFive.Add("k");

    //   valueEight.Add("j");
    //   valueEight.Add("x");

    //   valueTen.Add("q");
    //   valueTen.Add("z");

    //   tileValue.Add(1, valueOne);
    //   tileValue.Add(2, valueTwo);
    //   tileValue.Add(3, valueThree);
    //   tileValue.Add(4, valueFour);
    //   tileValue.Add(5, valueFive);
    //   tileValue.Add(8, valueEight);
    //   tileValue.Add(10, valueTen);
    //   }

  //   public void GetValue()
  //   {
  //     Logic newLogic = new Logic();
  //     Console.WriteLine("inside GetValue");
  //     foreach (KeyValuePair<int, List<string>> list in tileValue)
  //     {
  //       Console.WriteLine("in foreach loop");
  //       foreach (string value in list.Value)
  //       {
  //         Console.WriteLine("Key = {0}, Value = {1}", list.Key, value);
  //       }
  //     }
  //   }

  }
}

/*

    private static Dictionary<char, int> _letterScores = new Dictionary<char, int>
    {
      { 'a', 1 },
      { 'b', 3 },
      { 'c', 3 },
      { 'd', 2 },
      { 'e', 1 },
      { 'f', 4 },
      { 'g', 2 },
      { 'h', 4 },
      { 'i', 1 },
      { 'j', 8 },
      { 'k', 5 },
      { 'l', 1 },
      { 'm', 3 },
      { 'n', 1 },
      { 'o', 1 },
      { 'p', 3 },
      { 'q', 10 },
      { 'r', 1 },
      { 's', 1 },
      { 't', 1 },
      { 'u', 1 },
      { 'v', 4 },
      { 'w', 4 },
      { 'x', 8 },
      { 'y', 4 },
      { 'z', 10 }
    };
*/