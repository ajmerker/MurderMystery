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
    public partial class NathanielGame : Form
    {
        public NathanielGame()
        {
            InitializeComponent();
        }

        public static int points = 0;

        private async void buttonPlay_Click(object sender, EventArgs e)
        {
            points = 0; 
            label3.Text =  points.ToString();

            button1.Visible = true;
            await Task.Delay(300);
            button1.Visible = false;

            button2.Visible = true;
            await Task.Delay(300);
            button2.Visible = false;

            button3.Visible = true;
            await Task.Delay(300);
            button3.Visible = false;

            button4.Visible = true;
            await Task.Delay(300);
            button4.Visible = false;

            button5.Visible = true;
            await Task.Delay(300);
            button5.Visible = false;

            button6.Visible = true;
            await Task.Delay(300);
            button6.Visible = false;

            button7.Visible = true;
            await Task.Delay(300);
            button7.Visible = false;

            button8.Visible = true;
            await Task.Delay(300);
            button8.Visible = false;

            button9.Visible = true;
            await Task.Delay(300);
            button9.Visible = false;

            button10.Visible = true;
            await Task.Delay(300);
            button10.Visible = false;

            button11.Visible = true;
            await Task.Delay(300);
            button11.Visible = false;

            button12.Visible = true;
            await Task.Delay(300);
            button12.Visible = false;

            button13.Visible = true;
            await Task.Delay(300);
            button13.Visible = false;

            button14.Visible = true;
            await Task.Delay(300);
            button14.Visible = false;

            button15.Visible = true;
            await Task.Delay(300);
            button15.Visible = false;

            button16.Visible = true;
            await Task.Delay(300);
            button16.Visible = false;

            button17.Visible = true;
            await Task.Delay(300);
            button17.Visible = false;

            button18.Visible = true;
            await Task.Delay(300);
            button18.Visible = false;

            button19.Visible = true;
            await Task.Delay(300);
            button19.Visible = false;

            button20.Visible = true;
            await Task.Delay(300);
            button20.Visible = false;

            button21.Visible = true;
            await Task.Delay(300);
            button21.Visible = false;

            button22.Visible = true;
            await Task.Delay(300);
            button22.Visible = false;

            button23.Visible = true;
            await Task.Delay(300);
            button23.Visible = false;

            button24.Visible = true;
            await Task.Delay(300);
            button24.Visible = false;

            button25.Visible = true;
            await Task.Delay(300);
            button25.Visible = false;

            button26.Visible = true;
            await Task.Delay(300);
            button26.Visible = false;

            button27.Visible = true;
            await Task.Delay(300);
            button27.Visible = false;

            button27.Visible = true;
            await Task.Delay(300);
            button27.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            points = points - 5;
            label3.Text = points.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            points = points + 5;
            label3.Text = points.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            points = points - 5;
            label3.Text = points.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            points = points - 5;
            label3.Text = points.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            points = points + 5;
            label3.Text = points.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            points = points - 5;
            label3.Text = points.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            points = points - 5;
            label3.Text = points.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            points = points + 5;
            label3.Text = points.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            points = points - 5;
            label3.Text = points.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            points = points - 5;
            label3.Text = points.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            points = points - 5;
            label3.Text = points.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            points = points + 5;
            label3.Text = points.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            points = points + 5;
            label3.Text = points.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            points = points - 5;
            label3.Text = points.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            points = points - 5;
            label3.Text = points.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            points = points - 5;
            label3.Text = points.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            points = points - 5;
            label3.Text = points.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            points = points + 5;
            label3.Text = points.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            points = points - 5;
            label3.Text = points.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            points = points - 5;
            label3.Text = points.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            points = points + 5;
            label3.Text = points.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            points = points + 5;
            label3.Text = points.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            points = points - 5;
            label3.Text = points.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            points = points + 5;
            label3.Text = points.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            points = points - 5;
            label3.Text = points.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            points = points - 5;
            label3.Text = points.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            points = points + 5;
            label3.Text = points.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            points = points - 5;
            label3.Text = points.ToString();
        }

        //ignore this
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            if(points >= 20)
            {
                MessageBox.Show("Congradulations! You won the game!\nNathaniel Nutmeg swears he did not intentionally " +
                    "over serve Bill Bourbon the night of the muder. He claims that Bill was at his bar that night complainin' " +
                    "that he had finally changed his will, and none of his family would be happy about it besides his wife Beatrix. " +
                    "Bill said he was tired of her naggin,' and just gave in and changed it so she'd shut up about it.", "Nathaniel Nutmeg"); 
            }
            else
            {
                MessageBox.Show("You Lost the game! You will not get Nathaniel Nutmeg's final clue.", "Nathaniel Nutmeg");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nathaniel n1 = new Nathaniel();
            n1.ShowDialog(); 
        }

        //ignore this 
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
