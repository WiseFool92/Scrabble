using System;
using System.Collections.Generic;
using Scrabble.Model;

namespace ScrabbleEntry
{
  class Program
  {
    public static void Main()
    {
      Logic frontEnd = new Logic();
      // bool run = true;
      // while(run == true)
      // {
        // Console.WriteLine("Welcome to the Scrabble Calculator!");
        // Enter:
        Console.WriteLine("Please enter your word and we'll give you it's score!");
        string input = Console.ReadLine();
        Logic.GetInput(input);

        Logic.GetValue();
        

      //   Console.WriteLine("Would you like to check another?\n\n[Y/N]");
      //   string addNew = (Console.ReadLine().ToLower());
      //   if (addNew == "y")
      //   {
      //     goto Enter;
      //   }
      //   else
      //   {
      //     Environment.Exit(0);
      //   }
      // }
    }
  }
}