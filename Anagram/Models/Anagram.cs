using System;

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

      //char[] characters = 
      return false;
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