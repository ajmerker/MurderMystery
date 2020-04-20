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
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this allows the Beautrix Bourbon Button on suspects to take you to her page 
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog(); 
        }

        //voodoo mamma juju buttonn to her page 
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog(); 
        }

        //from Suspect list to main menu 
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(); 
            f1.ShowDialog(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5(); 
            f5.ShowDialog(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nathaniel n1 = new Nathaniel();
            n1.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nelly n2 = new Nelly();
            n2.ShowDialog(); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalebCrawdad c1 = new CalebCrawdad();
            c1.ShowDialog(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Butler b1 = new Butler();
            b1.ShowDialog(); 

        }
    }
}
