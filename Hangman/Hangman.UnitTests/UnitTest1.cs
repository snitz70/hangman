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
            string hidden = "_ _ _ _ _ _ _";
            Game game = new Game() { Word = "welcome" };
            Assert.AreEqual(game.HiddenWord, hidden);
            Assert.AreEqual(game.Word, "welcome");
        }

        [TestMethod]
        public void TestGuessedLetter_l_ReturnsCorrectIndexes()
        {
            List<int> indexes = new List<int>() { 2 };

            Game game = new Game() { Word = "welcome" };
            CollectionAssert.AreEqual(game.GetIndexes('l'), indexes);
        }

        [TestMethod]
        public void TestGuessedLetter_e_ReturnsCorrectIndexes()
        {
            List<int> indexes = new List<int>() { 1,6 };

            Game game = new Game() { Word = "welcome" };
            CollectionAssert.AreEqual(game.GetIndexes('e'), indexes);
        }

        [TestMethod]
        public void TestReplacingUnderscoreWithLetters()
        {
            Game game = new Game() { Word = "welcome" };
            string hidden = "_ e _ _ _ _ e";
            List<int> indexes = new List<int>() { 1, 6 };
            game.ReplaceLetters(indexes);
            Assert.AreEqual(game.HiddenWord, hidden);
        }
        
        [TestMethod]
        public void TestGuessCorrectLetter()
        {
            Game game = new Game() { Word = "welcome" };
            Assert.IsTrue(game.GuessLetter('e'));
        }
    }
}
