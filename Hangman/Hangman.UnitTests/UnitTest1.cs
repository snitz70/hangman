using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hangman.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSettingWord()
        {
            string word = "welcome";
            Hangman hangman = new Hangman();
            hangman.Word = word;
            CollectionAssert.AreEqual(hangman.HiddenWord, word.ToCharArray());
            Assert.AreEqual(hangman.Word, word);
        }
    }
}
