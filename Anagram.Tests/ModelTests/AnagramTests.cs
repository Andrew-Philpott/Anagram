using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramFinder.Models;

namespace AnagramFinder.Tests
{
  [TestClass]
  public class AnagramTests
  {
    [TestMethod]
    public void Dispose()
    {
      Item.ClearAll();
    }
  }
}