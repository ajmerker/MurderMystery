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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog(); 


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            DebGame dg = new DebGame();
            dg.ShowDialog(); 
        }
    }
}
