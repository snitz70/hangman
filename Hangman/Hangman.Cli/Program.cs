using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Game hangman = new Game() { Word = "welcome" };
            Console.WriteLine(hangman.HiddenWord);
            while (hangman.GameStatus == "Playing")
            {
                Console.WriteLine("\nEnter Guess ");
                char letter = Convert.ToChar(Console.ReadLine());
                bool guess = hangman.GuessLetter(letter);
                if (guess)
                {
                    Console.WriteLine("Correct guess!");
                }
                else
                {
                    Console.WriteLine("incorrect!");
                }
                Console.WriteLine("Guessed letters: {0}", string.Join(" ", hangman.GuessedLetters));
                Console.WriteLine(hangman.HiddenWord);
            }

        }
    }
}
