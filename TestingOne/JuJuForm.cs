using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MurderMystery
{ 

    public partial class JuJuForm : Form
    {
        string SecretWord;
        int LivesLeft = 3; 
        bool c1Guessed, c2Guessed, c3Guessed, c4Guessed, c5Guessed, c6Guessed, Won;

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TB_charToGuess.Text.Length > 1)
            {
                MessageBox.Show("You can't put in more than one character!", "Voodoo Mama JuJu");
            }

            //if (TB_MissedWords.Text.Contains(TB_charToGuess.Text))  //it used to be char to guess . text 
            // {
            //  MessageBox.Show("You have already guessed" + TB_charToGuess.Text, "hangman"); 
            // }

            if (SecretWord.Contains(TB_charToGuess.Text.ToLower()))
            {
                if (TB_charToGuess.Text == c1.ToString())
                {
                    LB_Char1.Text = c1.ToString();
                    c1Guessed = true;
                }
                if (TB_charToGuess.Text == c2.ToString())
                {
                    LB_Char2.Text = c2.ToString();
                    c2Guessed = true;
                }
                if (TB_charToGuess.Text == c3.ToString())
                {
                    LB_Char3.Text = c3.ToString();
                    c3Guessed = true;
                }
                if (TB_charToGuess.Text == c4.ToString())
                {
                    LB_Char4.Text = c4.ToString();
                    c4Guessed = true;
                }
                if (TB_charToGuess.Text == c5.ToString())
                {
                    LB_Char5.Text = c5.ToString();
                    c5Guessed = true;
                }
                if (TB_charToGuess.Text == c6.ToString())
                {
                    LB_Char6.Text = c6.ToString();
                    c6Guessed = true;
                }

                if (c1Guessed && c2Guessed && c3Guessed && c4Guessed && c5Guessed && c6Guessed)
                {
                    Won = true;
                }

                if (Won)
                {
                    MessageBox.Show("You have won and had " + LivesLeft.ToString() + " Tries Left \n" +
                        "Voodoo mama Juju was at the bar that night because she had a bad hunch " +
                        "about Bill Bourbon's aura, and went to make sure he was okay. Our lyin' " +
                        "detectors indicate she was tellin' the truth.", "Voodoo Mama JuJu");
                    //Form4.richTextBox3.Visible = true; 
                }
            }
            else
            {
                LivesLeft--;
                LB_LifeValue.Text = LivesLeft.ToString();
                TB_MissedWords.Text += TB_charToGuess;

                if (LivesLeft == 0)
                {
                    MessageBox.Show("You have lost! Voodoo Mama JuJu's final clue will remain a secret.");
                    Won = false;
                    button2.Visible = false;
                    BTN_Play_Click.Visible = false;

                }
            }
        }

        private void LB_Char1_Click(object sender, EventArgs e)
        {

        }

        char c1, c2, c3, c4, c5, c6; 

        public JuJuForm()
        {
            InitializeComponent();
            button2.Visible = false;
        }

        private void BTN_Play_Click_Click(object sender, EventArgs e)
        {
            Resetter();
            LivesLeft = 3; 
            Won = false; 
            SecretWord = "potion";
            c1 = SecretWord[0]; c2 = SecretWord[1]; c3 = SecretWord[2]; c4 = SecretWord[3]; c5 = SecretWord[4]; c6 = SecretWord[5];
            LB_LifeValue.Text = LivesLeft.ToString(); 
            //MessageBox.Show(SecretWord);
            MessageBox.Show("A hidden word has been hidden in Voodoo Mama JuJu's spell book! Can you solve it to get the final clue?", "Voodoo Mama JuJu"); 

        }

        private void Resetter()
        {
            Won = false; c1Guessed = false; c2Guessed = false; c3Guessed = false; c4Guessed = false; c5Guessed = false; c6Guessed = false; button2.Visible = true;
            LB_Char1.Text = " * "; LB_Char2.Text = " * "; LB_Char3.Text = " * "; LB_Char4.Text = " * "; LB_Char5.Text = " * "; LB_Char6.Text = " * ";
        }
    }
}
