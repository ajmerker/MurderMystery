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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        //declare tries
        public static int triesLeft = 4;

        //declare each item
        public static int p1;
        public static int p2;
        public static int p3;
        public static int p4;
        public static int p5;
        public static int p6;
        public static int p7;
        public static int p8;
        public static int p9;
        public static int p10;
        public static int p11;
        public static int p12;


        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        //locate the images
        private void Form7_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("1.png");
            pictureBox2.Image = Image.FromFile("2.png");
            pictureBox3.Image = Image.FromFile("3.png");
            pictureBox4.Image = Image.FromFile("4.png");
            pictureBox5.Image = Image.FromFile("5.png");
            pictureBox6.Image = Image.FromFile("1.png");
            pictureBox7.Image = Image.FromFile("2.png");
            pictureBox8.Image = Image.FromFile("4.png");
            pictureBox9.Image = Image.FromFile("4.png");
            pictureBox10.Image = Image.FromFile("5.png");
            pictureBox11.Image = Image.FromFile("1.png");
            pictureBox12.Image = Image.FromFile("2.png");

        }

        // generate random numbers 
        public static class IntUtil
        {
            private static Random random;

            private static void Init()
            {
                if (random == null) random = new Random();
            }
            public static int Random(int min, int max)
            {
                Init();
                return random.Next(min, max);
            }
        }

        //when play is pressed: 
        private void button1_Click(object sender, EventArgs e)
        {
                for (var i = 0; i < 10; i++)
                {
                    p1 = IntUtil.Random(1, 6);
                    p2 = IntUtil.Random(1, 6);
                    p3 = IntUtil.Random(1, 6);
                    p4 = IntUtil.Random(1, 6);
                    p5 = IntUtil.Random(1, 6);
                    p6 = IntUtil.Random(1, 6);
                    p7 = IntUtil.Random(1, 6);
                    p8 = IntUtil.Random(1, 6);
                    p9 = IntUtil.Random(1, 6);
                    p10 = IntUtil.Random(1, 6);
                    p11 = IntUtil.Random(1, 6);
                    p12 = IntUtil.Random(1, 6);
                }

            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                pictureBox1.Image = Image.FromFile(p1.ToString() + ".png");

            if (pictureBox2.Image != null) pictureBox2.Image.Dispose();
                pictureBox2.Image = Image.FromFile(p2.ToString() + ".png");

            if (pictureBox3.Image != null) pictureBox3.Image.Dispose();
                pictureBox3.Image = Image.FromFile(p3.ToString() + ".png");

            if (pictureBox4.Image != null) pictureBox4.Image.Dispose();
            pictureBox4.Image = Image.FromFile(p4.ToString() + ".png");

            if (pictureBox5.Image != null) pictureBox5.Image.Dispose();
            pictureBox5.Image = Image.FromFile(p5.ToString() + ".png");

            if (pictureBox6.Image != null) pictureBox6.Image.Dispose();
            pictureBox6.Image = Image.FromFile(p6.ToString() + ".png");

            if (pictureBox7.Image != null) pictureBox7.Image.Dispose();
            pictureBox7.Image = Image.FromFile(p7.ToString() + ".png");

            if (pictureBox8.Image != null) pictureBox8.Image.Dispose();
            pictureBox8.Image = Image.FromFile(p8.ToString() + ".png");

            if (pictureBox9.Image != null) pictureBox9.Image.Dispose();
            pictureBox9.Image = Image.FromFile(p9.ToString() + ".png");

            if (pictureBox10.Image != null) pictureBox10.Image.Dispose();
            pictureBox10.Image = Image.FromFile(p10.ToString() + ".png");

            if (pictureBox11.Image != null) pictureBox11.Image.Dispose();
            pictureBox11.Image = Image.FromFile(p11.ToString() + ".png");

            if (pictureBox12.Image != null) pictureBox12.Image.Dispose();
            pictureBox12.Image = Image.FromFile(p12.ToString() + ".png");

            pictureBox1.Visible = false; //hides all images 
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;

            b1.Visible = true; //shows all guess buttons 
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;

            button1.Visible = false; //takes away play button 

            label1.Text = triesLeft.ToString();
            triesLeft = 4; 

            MessageBox.Show("The images have been shuffled! Try to find the pistol used to kill Bill Bourbon! You have 4 guesses."); 

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Butler b1 = new Butler();
            this.Hide();
            b1.ShowDialog(); 
        }

        //if button 1 is guessed: 
        private void b1_Click(object sender, EventArgs e)
        {
            if(triesLeft <= 0)
            {
                pictureBox1.Visible = true; 
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                MessageBox.Show("You lost the game! You Won't get the Butler's final clue.", "Butler"); 
            }
            else if(triesLeft > 0)
            {
                if(p1 == 3)
                {
                    b1.Visible = false;
                    pictureBox1.Visible = true;
                    MessageBox.Show("You found the pistol! You had " + triesLeft + " tries left! " +
                        "\nThe Butler said that Deb U. Taunt never asked him where the pistol was kept." +
                        " He claims that Beatrix lied about that, and he also heard her up late the previous " +
                        "night lookin' for something. Our lyin' devices indicate he's tellin' the truth. ");
                }
                else
                {
                    triesLeft = triesLeft - 1;
                    label1.Text = triesLeft.ToString();
                    b1.Visible = false;
                    pictureBox1.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (triesLeft <= 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                MessageBox.Show("You lost the game! You Won't get the Butler's final clue.", "Butler");
            }
            else if (triesLeft > 0)
            {
                if (p2 == 3)
                {
                    button2.Visible = false;
                    pictureBox2.Visible = true;
                    MessageBox.Show("You found the pistol! You had " + triesLeft + " tries left! " +
                        "\nThe Butler said that Deb U. Taunt never asked him where the pistol was kept." +
                        " He claims that Beatrix lied about that, and he also heard her up late the previous " +
                        "night lookin' for something. Our lyin' devices indicate he's tellin' the truth. ");
                }
                else
                {
                    triesLeft = triesLeft - 1;
                    label1.Text = triesLeft.ToString();
                    button2.Visible = false;
                    pictureBox2.Visible = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (triesLeft <= 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                MessageBox.Show("You lost the game! You Won't get the Butler's final clue.", "Butler");
            }
            else if (triesLeft > 0)
            {
                if (p3 == 3)
                {
                    button3.Visible = false;
                    pictureBox3.Visible = true;
                    MessageBox.Show("You found the pistol! You had " + triesLeft + " tries left! " +
                        "\nThe Butler said that Deb U. Taunt never asked him where the pistol was kept." +
                        " He claims that Beatrix lied about that, and he also heard her up late the previous " +
                        "night lookin' for something. Our lyin' devices indicate he's tellin' the truth. ");
                }
                else
                {
                    triesLeft = triesLeft - 1;
                    label1.Text = triesLeft.ToString();
                    button3.Visible = false;
                    pictureBox3.Visible = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (triesLeft <= 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                MessageBox.Show("You lost the game! You Won't get the Butler's final clue.", "Butler");
            }
            else if (triesLeft > 0)
            {
                if (p4 == 3)
                {
                    button4.Visible = false;
                    pictureBox4.Visible = true;
                    MessageBox.Show("You found the pistol! You had " + triesLeft + " tries left! " +
                        "\nThe Butler said that Deb U. Taunt never asked him where the pistol was kept." +
                        " He claims that Beatrix lied about that, and he also heard her up late the previous " +
                        "night lookin' for something. Our lyin' devices indicate he's tellin' the truth. ");
                }
                else
                {
                    triesLeft = triesLeft - 1;
                    label1.Text = triesLeft.ToString();
                    button4.Visible = false;
                    pictureBox4.Visible = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (triesLeft <= 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                MessageBox.Show("You lost the game! You Won't get the Butler's final clue.", "Butler");
            }
            else if (triesLeft > 0)
            {
                if (p5 == 3)
                {
                    button5.Visible = false;
                    pictureBox5.Visible = true;
                    MessageBox.Show("You found the pistol! You had " + triesLeft + " tries left! " +
                        "\nThe Butler said that Deb U. Taunt never asked him where the pistol was kept." +
                        " He claims that Beatrix lied about that, and he also heard her up late the previous " +
                        "night lookin' for something. Our lyin' devices indicate he's tellin' the truth. ");
                }
                else
                {
                    triesLeft = triesLeft - 1;
                    label1.Text = triesLeft.ToString();
                    button5.Visible = false;
                    pictureBox5.Visible = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (triesLeft <= 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                MessageBox.Show("You lost the game! You Won't get the Butler's final clue.", "Butler");
            }
            else if (triesLeft > 0)
            {
                if (p6 == 3)
                {
                    button6.Visible = false;
                    pictureBox6.Visible = true;
                    MessageBox.Show("You found the pistol! You had " + triesLeft + " tries left! " +
                        "\nThe Butler said that Deb U. Taunt never asked him where the pistol was kept." +
                        " He claims that Beatrix lied about that, and he also heard her up late the previous " +
                        "night lookin' for something. Our lyin' devices indicate he's tellin' the truth. ");
                }
                else
                {
                    triesLeft = triesLeft - 1;
                    label1.Text = triesLeft.ToString();
                    button6.Visible = false;
                    pictureBox6.Visible = true;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (triesLeft <= 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                MessageBox.Show("You lost the game! You Won't get the Butler's final clue.", "Butler");
            }
            else if (triesLeft > 0)
            {
                if (p7 == 3)
                {
                    button7.Visible = false;
                    pictureBox7.Visible = true;
                    MessageBox.Show("You found the pistol! You had " + triesLeft + " tries left! " +
                        "\nThe Butler said that Deb U. Taunt never asked him where the pistol was kept." +
                        " He claims that Beatrix lied about that, and he also heard her up late the previous " +
                        "night lookin' for something. Our lyin' devices indicate he's tellin' the truth. ");
                }
                else
                {
                    triesLeft = triesLeft - 1;
                    label1.Text = triesLeft.ToString();
                    button7.Visible = false;
                    pictureBox7.Visible = true;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (triesLeft <= 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                MessageBox.Show("You lost the game! You Won't get the Butler's final clue.", "Butler");
            }
            else if (triesLeft > 0)
            {
                if (p8 == 3)
                {
                    button8.Visible = false;
                    pictureBox8.Visible = true;
                    MessageBox.Show("You found the pistol! You had " + triesLeft + " tries left! " +
                        "\nThe Butler said that Deb U. Taunt never asked him where the pistol was kept." +
                        " He claims that Beatrix lied about that, and he also heard her up late the previous " +
                        "night lookin' for something. Our lyin' devices indicate he's tellin' the truth. ");
                }
                else
                {
                    triesLeft = triesLeft - 1;
                    label1.Text = triesLeft.ToString();
                    button8.Visible = false;
                    pictureBox8.Visible = true;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (triesLeft <= 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                MessageBox.Show("You lost the game! You Won't get the Butler's final clue.", "Butler");
            }
            else if (triesLeft > 0)
            {
                if (p9 == 3)
                {
                    button9.Visible = false;
                    pictureBox9.Visible = true;
                    MessageBox.Show("You found the pistol! You had " + triesLeft + " tries left! " +
                        "\nThe Butler said that Deb U. Taunt never asked him where the pistol was kept." +
                        " He claims that Beatrix lied about that, and he also heard her up late the previous " +
                        "night lookin' for something. Our lyin' devices indicate he's tellin' the truth. ");
                }
                else
                {
                    triesLeft = triesLeft - 1;
                    label1.Text = triesLeft.ToString();
                    button9.Visible = false;
                    pictureBox9.Visible = true;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (triesLeft <= 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                MessageBox.Show("You lost the game! You Won't get the Butler's final clue.", "Butler");
            }
            else if (triesLeft > 0)
            {
                if (p10 == 3)
                {
                    button10.Visible = false;
                    pictureBox10.Visible = true;
                    MessageBox.Show("You found the pistol! You had " + triesLeft + " tries left! " +
                        "\nThe Butler said that Deb U. Taunt never asked him where the pistol was kept." +
                        " He claims that Beatrix lied about that, and he also heard her up late the previous " +
                        "night lookin' for something. Our lyin' devices indicate he's tellin' the truth. ");
                }
                else
                {
                    triesLeft = triesLeft - 1;
                    label1.Text = triesLeft.ToString();
                    button10.Visible = false;
                    pictureBox10.Visible = true;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (triesLeft <= 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                MessageBox.Show("You lost the game! You Won't get the Butler's final clue.", "Butler");
            }
            else if (triesLeft > 0)
            {
                if (p11 == 3)
                {
                    button11.Visible = false;
                    pictureBox11.Visible = true;
                    MessageBox.Show("You found the pistol! You had " + triesLeft + " tries left! " +
                        "\nThe Butler said that Deb U. Taunt never asked him where the pistol was kept." +
                        " He claims that Beatrix lied about that, and he also heard her up late the previous " +
                        "night lookin' for something. Our lyin' devices indicate he's tellin' the truth. ");
                }
                else
                {
                    triesLeft = triesLeft - 1;
                    label1.Text = triesLeft.ToString();
                    button11.Visible = false;
                    pictureBox11.Visible = true;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (triesLeft <= 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                MessageBox.Show("You lost the game! You Won't get the Butler's final clue.", "Butler");
            }
            else if (triesLeft > 0)
            {
                if (p12 == 3)
                {
                    button12.Visible = false;
                    pictureBox12.Visible = true;
                    MessageBox.Show("You found the pistol! You had " + triesLeft + " tries left! " +
                        "\nThe Butler said that Deb U. Taunt never asked him where the pistol was kept." +
                        " He claims that Beatrix lied about that, and he also heard her up late the previous " +
                        "night lookin' for something. Our lyin' devices indicate he's tellin' the truth. ");
                }
                else
                {
                    triesLeft = triesLeft - 1;
                    label1.Text = triesLeft.ToString();
                    button12.Visible = false;
                    pictureBox12.Visible = true;
                }
            }
        }
    }
}
