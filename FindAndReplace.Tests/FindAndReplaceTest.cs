using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FindAndReplace.Models;
using System;

namespace FindAndReplace.Tests
{
  [TestClass]
  public class FindAndReplaceClassTest
  {
    // [TestMethod]
    // public void GetSentence_ReturnSentence_String()
    // {
    //   FindAndReplaceClass newSentence = new FindAndReplaceClass("I am walking my cat to the cathedral extra");
    //   string expected = "I am walking my cat to the cathedral extra";
    //   string actual = newSentence.GetSentence();
    //   Assert.AreEqual(expected, actual);
    // }
    // [TestMethod]
    // public void GetNewSentence_ReturnSentenceWithWordsReplaced_True()
    // {
    //   FindAndReplaceClass newSentence = new FindAndReplaceClass("I am walking my cat to the cathedral extra");
    //   string expected = "I am walking my dog to the cathedral extra";
    //   string actual = newSentence.GetNewSentence();
    //   Assert.AreEqual(expected, actual);
    // }
    [TestMethod]
    public void GetNewSentence_ReturnSentenceWithPartialWordsReplaced_True()
    {
      FindAndReplaceClass newSentence = new FindAndReplaceClass("I am walking my cat to the cathedral");
      string expected = "I am walking my dog to the doghedral";
      string actual = newSentence.GetNewSentence();
      Console.WriteLine(actual);
      Assert.AreEqual(expected, actual);
    }
  }
}
