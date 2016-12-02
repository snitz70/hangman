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
        public List<string> GuessedLetters = new List<string>();
        public int NumberOfIncorrectGuesses;
        private const int INCORRECT = 6;
        private List<int> GuessedLetterIndexs = new List<int>();

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

    }
}
