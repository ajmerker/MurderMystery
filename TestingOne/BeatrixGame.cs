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
    public partial class BeatrixGame : Form
    {
        public BeatrixGame()
        {
            InitializeComponent();
        }

        //declare each item
        public static int s1;
        public static int s2;
        public static int s3;

        //when you click exit 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog(); 
        }

        //declare the pictures
        private void BeatrixGame_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("s1.jpg");
            pictureBox2.Image = Image.FromFile("s2.jpg");
            pictureBox3.Image = Image.FromFile("s3.jpg");
        }

        //when you click play 
        private async void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            await Task.Delay(500);
            pictureBox1.Visible = false;

            pictureBox2.Visible = true;
            await Task.Delay(500);
            pictureBox2.Visible = false;

            pictureBox3.Visible = true;
            await Task.Delay(500);
            pictureBox3.Visible = false;

            button1.Visible = false;

            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            label2.Visible = true; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect! You will not get Beatrix Bourbon's final clue. Press exit to return to her page.", "Beatrix Bourbon");
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label2.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect! You will not get Beatrix Bourbon's final clue. Press exit to return to her page.", "Beatrix Bourbon");
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect! You will not get Beatrix Bourbon's final clue. Press exit to return to her page.", "Beatrix Bourbon");
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            label3.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect! You will not get Beatrix Bourbon's final clue. Press exit to return to her page.", "Beatrix Bourbon");
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            label3.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = true;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect! You will not get Beatrix Bourbon's final clue. Press exit to return to her page.", "Beatrix Bourbon");
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            label4.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect! You will not get Beatrix Bourbon's final clue. Press exit to return to her page.", "Beatrix Bourbon");
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            label4.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            MessageBox.Show("Great Memory dectective!\n" +
                "Beatrix claims to have come downstairs when she heard the gunshot, and saw her husband dead on the floor. She thinks Bill's niece Deb has somethin' to do with it, because she was in the manor the night of the murder."); 
        }
    }
}
