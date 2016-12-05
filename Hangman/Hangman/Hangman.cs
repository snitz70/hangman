using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Hangman
    {

        // TODO 
        // add method to pick random word from text file
        // 
        private string _word;
        private char[] _hiddenWord;
        public List<char> _guessedLetters = new List<char>();
        public int NumberOfIncorrectGuesses;
        private const int INCORRECT = 6;
        private List<int> GuessedLetterIndexs = new List<int>();
        private int Missed = 0;
        public string GameStatus = "Playing";

        public string Word
        {
            set
            {
                _word = value;
                _hiddenWord = value.ToCharArray();
                for (int i = 0; i < _hiddenWord.Length; i++)
                {
                    _hiddenWord[i] = '_';
                }
            }
            get { return _word; }
        }

        public string HiddenWord
        {
            get { return String.Join(" ", _hiddenWord); }
        }

        public string GuessedLetters
        {
            get
            {
                return String.Join(" ", _guessedLetters);
            }
        }

        public List<int> GetIndexes(char letter)
        {
            List<int> indexes = new List<int>();
            int i = 0;
            while (( i = Word.IndexOf(letter, i)) != -1)
            {
                indexes.Add(i);
                i++;
            }

            return indexes;
        }

        public Hangman()
        {
            Word = GetRandomWord();
        }

        public void ReplaceLetters(List<int> indexes)
        {
            foreach(int index in indexes)
            {
                _hiddenWord[index] = _word.ToCharArray()[index];
            }
        }

        // Guess letter and return boolean whether it was found
        public bool GuessLetter(char letter)
        {
            _guessedLetters.Add(letter);
            List<int> indexes = new List<int>();
            indexes = GetIndexes(letter);
            if (indexes.Count == 0)
            {
                Missed++;
                if (Missed == INCORRECT)
                    GameStatus = "Lost";
                return false;
            }
            else
            {
                ReplaceLetters(indexes);
                if (_word == string.Join("", _hiddenWord))
                    GameStatus = "Won";
                return true;
            }
        }

        private string GetRandomWord()
        {
            string[] lines = System.IO.File.ReadAllLines("C:\\temp\\words.txt");
            Random random = new Random();
            return lines[random.Next(lines.Length)];
        }

    }
}
