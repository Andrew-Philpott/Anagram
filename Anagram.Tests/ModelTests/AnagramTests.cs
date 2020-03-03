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
      Anagram newAnagram = new Anagram(word);
      Assert.AreEqual(typeof(Anagram), newAnagram.GetType());
      Assert.AreEqual(word, newAnagram.Word);
    }

  }
}