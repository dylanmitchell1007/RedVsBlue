using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedVsBlue
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Player one = new Player();
            Player two = new Player();
            Player three = new Player();
            Player four = new Player();
            Player five = new Player();
            Player six = new Player();
            
            Party One = new Party(one,two, three);
            Party Two = new Party(four, five, six);


            
           



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Captan Red";
        }

        private void progressBar3_Click(object sender, EventArgs e)
        {
            progressBar3.Value = 100;
        }
        
        private void progressBar2_Click(object sender, EventArgs e)
        {
            progressBar2.Value = 100;
        
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar5_Click(object sender, EventArgs e)
        {
            
        }
    }
}

