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

        public string Word
        {
            set
            {
                _word = value;
                _hiddenWord = value.ToCharArray();
            }
            get { return _word; }
        }

        public char[] HiddenWord
        {
            get { return _hiddenWord; }
        }
    }
}
