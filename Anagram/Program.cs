using System;
using AnagramFinder.Models;
using System.Collections.Generic;

namespace AnagramFinder
{
  public class Program
  {

    // Tar = Rat
    // Arc = Car
    // Elbow = Below
    // State = Taste
    // Cider = Cried
    // Dusty = Study
    // Night = Thing
    // Inch = Chin
    // Brag = Grab
    // Cat = Act
    // Bored = Robed
    // Save = Vase
    // Angel = Glean
    // Stressed = Desserts

    public static void Main()
    {
      Console.WriteLine("Check if your list of words are anagrams of a word:");
      Console.WriteLine("Enter the word to check against the word list");
      string word = Console.ReadLine();
      Console.WriteLine("Enter your list of words to check. Seperate words with commas Ex. rat,tar,bar,car");
      string wordsList = Console.ReadLine();
      string[] wordsArray = wordsList.Split(",");
      List<string> anagrams = Anagram.GetAllAnagrams(word, wordsArray);
      if (anagrams.Count != 0)
      {
        Console.WriteLine("Anagrams are:");
        foreach (string item in anagrams)
        {
          Console.WriteLine(item);
        }
      }
      else
      {
        Console.WriteLine("There are no anagrams in the list that match your word");
      }
    }
  }
}