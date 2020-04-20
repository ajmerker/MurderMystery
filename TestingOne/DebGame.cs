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
    public partial class DebGame : Form
    {
        public DebGame()
        {
            InitializeComponent();
        }

        //when you click play 
        private async void buttonPlay_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            await Task.Delay(5000);
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            await Task.Delay(3000);
            pictureBox5.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            label2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

        }

        //exit 
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form5 f5 = new Form5();
            f5.ShowDialog(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct! You win!\nDeb claims that allthough she was in the house during the time" +
                " of the murder, she was nowhere near the room where the gun shot went off. She says the butler can " +
                "back her and vougue for her, as he was near her during that time.", "Deb U. Taunt"); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonPlay.Visible = false; 
            MessageBox.Show("Incorrect! You will not get Deb U. Taunt's final clue.", "Deb U. Tuant"); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonPlay.Visible = false;
            MessageBox.Show("Incorrect! You will not get Deb U. Taunt's final clue.", "Deb U. Tuant");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonPlay.Visible = false;
            MessageBox.Show("Incorrect! You will not get Deb U. Taunt's final clue.", "Deb U. Tuant");
        }
    }
}
