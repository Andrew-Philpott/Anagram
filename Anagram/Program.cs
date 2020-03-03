using System;
using AnagramFinder.Models;

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
      Console.WriteLine("Select a word from our list:");
      Anagram.PrintList();
      string userWord = Console.ReadLine();

    }
  }
}