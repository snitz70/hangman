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
            Word word = new Word("welcome");
            Assert.AreEqual(word.HiddenWord, hidden);
            Assert.AreEqual(word.OriginalWord, "welcome");
        }

        [TestMethod]
        public void TestReplacingUnderscoreWithLetters()
        {
            Word word = new Word("welcome");
            string hidden = "_ e _ _ _ _ e";
            word.ReplaceLetterIfInWord("e");
            Assert.AreEqual(word.HiddenWord, hidden);
        }

        [TestMethod]
        public void TestGuessedLetter_l_ReturnsTrue()
        {
            Game game = new Game();
            game.word = new Word("welcome");
            Assert.IsTrue(game.GuessLetter("e"));
        }

        [TestMethod]
        public void TestGuessedLetter_e_ReturnsTrue()
        {
            Game game = new Game();
            game.word = new Word("welcome");
            Assert.IsTrue(game.GuessLetter("e"));
        }

        [TestMethod]
        public void TestGussedLetter_g_ReturnsFalse()
        {
            Game game = new Game();
            game.word = new Word("welcome");
            Assert.IsFalse(game.GuessLetter("g"));
        }

    }
}
