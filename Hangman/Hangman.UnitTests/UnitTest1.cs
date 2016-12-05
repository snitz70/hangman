﻿using System;
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
            string hidden = "_ _ _ _ _ _ _";
            Hangman hangman = new Hangman() { Word = "welcome" };
            Assert.AreEqual(hangman.HiddenWord, hidden);
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
        public void TestReplacingUnderscoreWithLetters()
        {
            Hangman hangman = new Hangman() { Word = "welcome" };
            string hidden = "_ e _ _ _ _ e";
            List<int> indexes = new List<int>() { 1, 6 };
            hangman.ReplaceLetters(indexes);
            Assert.AreEqual(hangman.HiddenWord, hidden);
        }
        
        [TestMethod]
        public void TestGuessCorrectLetter()
        {
            Hangman hangman = new Hangman() { Word = "welcome" };
            Assert.IsTrue(hangman.GuessLetter('e'));
        }
    }
}
