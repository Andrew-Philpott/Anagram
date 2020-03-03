using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramFinder.Models;
using System;

namespace AnagramFinder.Tests
{
  [TestClass]
  public class AnagramTests
  {
    // [TestMethod]
    // public void Dispose()
    // {
    //   Anagram.ClearAll();
    // }

    [TestMethod]
    public void AnagramConstructor_CreatesInstanceOfAnagram_Anagram()
    {
      string word = "Tar";
      string[] potentialAnagrams = new string[] { "Rat", "Art" };
      Anagram newAnagram = new Anagram(word, potentialAnagrams);
      Assert.AreEqual(typeof(Anagram), newAnagram.GetType());
      Assert.AreEqual(word, newAnagram.Word);
      Assert.AreEqual(potentialAnagrams, newAnagram.PotentialAnagrams);
    }

    [TestMethod]
    public void CheckAnagram_ChecksWordAgainstPotentialWord_True()
    {
      string word = "Tar";
      string potentialAnagram = "Rat";
      //string[] potentialAnagrams = new string[] { "Rat" };
      //Anagram newAnagram = new Anagram(word, potentialAnagrams);
      Assert.AreEqual(true, Anagram.CheckAnagram(word, potentialAnagram));
    }

    [TestMethod]
    public void CheckAnagram_ChecksWordAgainstPotentialWord_False()
    {
      string word = "tar";
      string potentialAnagram = "car";
      Assert.AreEqual(false, Anagram.CheckAnagram(word, potentialAnagram));
    }
  }
}