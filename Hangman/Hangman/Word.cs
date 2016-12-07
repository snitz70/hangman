using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Word
    {
        private string _word;
        private char[] _hiddenWord;

        public string OriginalWord
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

        public Word(string word)
        {
            OriginalWord = word;
        }

        public bool ReplaceLetterIfInWord(string letter)
        {
            List<int> indexes = new List<int>();
            indexes = GetIndexes(Convert.ToChar(letter));
            if (indexes.Count == 0)
                return false;
            
            else
            {
                foreach (int index in indexes)
                {
                    _hiddenWord[index] = _word.ToCharArray()[index];
                }
                return true;
            }
        }

        private List<int> GetIndexes(char letter)
        {
            List<int> indexes = new List<int>();
            int i = 0;
            while ((i = OriginalWord.IndexOf(letter, i)) != -1)
            {
                indexes.Add(i);
                i++;
            }

            return indexes;
        }
    }
}
