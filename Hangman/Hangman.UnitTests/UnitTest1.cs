using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Hangman.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSettingWord()
        {
            char[] hidden = new char[7] { '_', '_', '_', '_', '_', '_', '_' };
            Hangman hangman = new Hangman() { Word = "welcome" };
            CollectionAssert.AreEqual(hangman.HiddenWord, hidden);
            Assert.AreEqual(hangman.Word, "welcome");
        }

        [TestMethod]
        public void TestGuessedLetter_l_ReturnsCorrectIndexes()
        {
            List<int> indexes = new List<int>() { 2 };

            Hangman hangman = new Hangman() { Word = "welcome" };
            CollectionAssert.AreEqual(hangman.GetIndexes('l'), indexes);
        }

        [TestMethod]
        public void TestGuessedLetter_e_ReturnsCorrectIndexes()
        {
            List<int> indexes = new List<int>() { 1,6 };

            Hangman hangman = new Hangman() { Word = "welcome" };
            CollectionAssert.AreEqual(hangman.GetIndexes('e'), indexes);
        }

        [TestMethod]
        public void 
    }
}
