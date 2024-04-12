using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class frmGuessWord : Form
    {
        private string wordToGuess = "computer";
        private StringBuilder wrongGuesses = new StringBuilder();
        
        public frmGuessWord()
        {
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guessedWord = textBox1.Text.ToLower();
            if (guessedWord == wordToGuess)
            {
                label1.Text = wordToGuess;
                MessageBox.Show("Correct guess!");
            }
            else
            {                                       
                listBox1.Items.Add(guessedWord);
                MessageBox.Show("You guessed it wrong! Try again!");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
 
        }

        private void frmGuessWord_Load(object sender, EventArgs e)
        {
            label1.Text = "c??????r";         
        }
    }
}
