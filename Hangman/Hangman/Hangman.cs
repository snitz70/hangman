using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Hangman
    {
        private string _word;
        private char[] _hiddenWord;
        public List<char> GuessedLetters = new List<char>();
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

        public char[] HiddenWord
        {
            get { return _hiddenWord; }
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

        public void ReplaceLetters(List<int> indexes)
        {
            foreach(int index in indexes)
            {
                _hiddenWord[index] = _word.ToCharArray()[index];
            }
        }

        public bool GuessLetter(char letter)
        {
            GuessedLetters.Add(letter);
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

    }
}
