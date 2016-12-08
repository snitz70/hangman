using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman.Gui
{
    public partial class Form1 : Form
    {
        Game hangman;

        public Form1()
        {
            InitializeComponent();
            hangman = new Game();
            hangman.NewGame();
            UpdateGui();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateGui()
        {
            label1.Text = hangman.word.HiddenWord;
            label2.Text = ("Guessed: " + hangman.GuessedLetters);
            if (hangman.gamestate != Game.GameState.Playing)
                MessageBox.Show("You " + hangman.gamestate.ToString(), "Game Over");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (hangman.GuessedLetters.IndexOf(textBox1.Text) > -1)
                    MessageBox.Show("You already guessed that letter");

                else
                {
                    hangman.GuessLetter(textBox1.Text);
                    UpdateGui();
                }
                textBox1.Clear();
            }
        }
    }
}
