using System;
using System.Collections.Generic;

namespace AnagramFinder.Models
{
  public class Anagram
  {
    public string Word { get; set; }
    public string[] PotentialAnagrams { get; set; }
    private static string[] _dictionary = new string[] { "tar", "rat", "arc", "car", "elbow", "below", "state", "taste", "cider" };
    private static string[] _alphaDictionary = new string[] { "tar", "rat", "arc", "car", "elbow", "below", "state", "taste", "cider" };

    public Anagram(string word, string[] potentialAnagrams)
    {
      Word = word;
      PotentialAnagrams = potentialAnagrams;
    }
    public static bool CheckAnagram(string word, string potentialAnagram)
    {

      char[] wordCharacters = word.ToLower().ToCharArray();
      char[] potentialAnagramCharacters = potentialAnagram.ToLower().ToCharArray();
      Array.Sort(wordCharacters);
      Array.Sort(potentialAnagramCharacters);
      string wordCharactersString = new string(wordCharacters).Trim();
      string wordPotentialCharactersString = new string(potentialAnagramCharacters).Trim();
      if (wordCharactersString == wordPotentialCharactersString)
      {
        return true;
      }
      return false;
    }

    public static List<string> GetAllAnagrams(string word, string[] potentialAnagrams)
    {
      List<string> potentialAnagramsList = new List<string>();
      // foreach (string item in potentialAnagrams)
      // {
      //   if (CheckAnagram(word, item))
      //   {
      //     potentialAnagramsList.Add(item);
      //   }
      // }
      return potentialAnagramsList;
    }
    public static void PrintList()
    {
      foreach (string item in _dictionary)
      {
        Console.WriteLine(item);
      }
    }



  }
}