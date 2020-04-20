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
    public partial class AcuseMurder : Form
    {
        public AcuseMurder()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button8.Visible = true;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false; 
            MessageBox.Show("Sorry detective! It looks like you need to freshen' up on the suspects stories " +
                "before you acuse the murderer. It was a good guess, but the murder will remain a mystery for now. " +
                "Play again to sharpen up on the clues.", "Belles, Bourbon, and Bullets"); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button8.Visible = true;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            MessageBox.Show("Sorry detective! It looks like you need to freshen' up on the suspects stories " +
                "before you acuse the murderer. It was a good guess, but the murder will remain a mystery for now. " +
                "Play again to sharpen up on the clues.", "Belles, Bourbon, and Bullets");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button8.Visible = true;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            MessageBox.Show("Sorry detective! It looks like you need to freshen' up on the suspects stories " +
                "before you acuse the murderer. It was a good guess, but the murder will remain a mystery for now. " +
                "Play again to sharpen up on the clues.", "Belles, Bourbon, and Bullets");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button8.Visible = true;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            MessageBox.Show("Sorry detective! It looks like you need to freshen' up on the suspects stories " +
                "before you acuse the murderer. It was a good guess, but the murder will remain a mystery for now. " +
                "Play again to sharpen up on the clues.", "Belles, Bourbon, and Bullets");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button8.Visible = true;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            MessageBox.Show("Sorry detective! It looks like you need to freshen' up on the suspects stories " +
                "before you acuse the murderer. It was a good guess, but the murder will remain a mystery for now. " +
                "Play again to sharpen up on the clues.", "Belles, Bourbon, and Bullets");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = Visible;
            button2.Visible = true;
            button8.Visible = true;
            MessageBox.Show("Great job detective! The murderer was infact Beatrix Bourbon. As it turns out, Beatrix had gotten Bill to change his will a couple of days ago so that she would get all his money. I reckon she didn't wantta' wait any longer to get the money. We're on our way to arrest her right now. ", "Belles, Bournon, and Bullets"); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }
    }
}
