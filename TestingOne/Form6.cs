using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace MurderMystery
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        // declare bets and total credits 
        public static long credits = 50;
        public static long total = 0;
        public static int bet = 5;

        // declare declare 
        public static int p1;
        public static int p2;
        public static int p3;

        private void Form6_Load(object sender, EventArgs e)
        {
            //provide images
            pictureBox1.Image = Image.FromFile("1.jpg");
            pictureBox2.Image = Image.FromFile("3.jpg");
            pictureBox3.Image = Image.FromFile("2.jpg");
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (credits >= bet)
            {
                credits = credits - bet;
                label1.Text = "Credits: " + credits.ToString();

                for (var i = 0; i < 10; i++)
                {
                    p1 = IntUtil.Random(1, 4);
                    p2 = IntUtil.Random(1, 4);
                    p3 = IntUtil.Random(1, 4);
                }

                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                pictureBox1.Image = Image.FromFile(p1.ToString() + ".jpg");

                if (pictureBox2.Image != null) pictureBox2.Image.Dispose();
                pictureBox2.Image = Image.FromFile(p2.ToString() + ".jpg");

                if (pictureBox3.Image != null) pictureBox3.Image.Dispose();
                pictureBox3.Image = Image.FromFile(p3.ToString() + ".jpg");

                total = 0;

                if (p1 == 3) total = total + 5;

                if (p1 == 2 & p2 == 2) total = total + 10;
                if (p1 == 3 & p2 == 3) total = total + 10;

                if (p1 == 1 & p2 == 1 & p3 == 1) total = total + 20;
                if (p1 == 2 & p2 == 2 & p3 == 2) total = total + 30;
                if (p1 == 3 & p2 == 3 & p3 == 3) total = total + 50;

                credits = credits + total;
                label3.Text = "Win: " + total.ToString();
                label1.Text = "Credits: " + credits.ToString();

                if (credits >= 200)
                {
                    MessageBox.Show("You have won Caleb Crawdad's mini Game! \nCaleb Crawdad has proof of being nowhere near the murder scene that night, and his family reports him being at home during that time. However, Crawdad reckons Ole Nathaniel Nutmeg may have encouraged him to drink too much the night of the murder. ");
                    button1.Visible = false; 
                }
                if (credits <= 0)
                {
                    MessageBox.Show("You have lost Caleb Cradad's Mini Game! \tYou will not get his final clue.");
                    button1.Visible = false; 
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalebCrawdad c3 = new CalebCrawdad();
            c3.ShowDialog(); 
        }
    }
}
