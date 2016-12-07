using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Game
    {
        private List<char> _guessedLetters = new List<char>();
        public int NumberOfIncorrectGuesses;
        private const int GUESSESTOLOSEGAME = 6;
        private int Missed = 0;
        public string GameStatus = "Playing";
        public Word word;

        public string GuessedLetters
        {
            get
            {
                return String.Join(" ", _guessedLetters);
            }
        }

        public void NewGame()
        {
            word = new Word(GetRandomWord());
        }

        public string GetRandomWord()
        {
            string[] lines = System.IO.File.ReadAllLines("C:\\temp\\words.txt");
            Random random = new Random();
            return lines[random.Next(lines.Length)];
        }

        public bool GuessLetter(string letter)
        {
            _guessedLetters.Add(Convert.ToChar(letter));
            bool LetterInWord = word.ReplaceLetterIfInWord(letter);
            if (!LetterInWord)
            {
                Missed++;
            }
            return LetterInWord;
        }


    }
}
