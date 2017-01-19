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

        TurnSystem TS;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player one = new Player(100, "Captain Red");
            Player two = new Player(100, "Private Red");
            Player three = new Player(100, "Sergent Red");
            Player four = new Player(100, "Captain Blue");
            Player five = new Player(100, "Sergent Blue");
            Player six = new Player(100, "Private Blue");


            Party One = new Party();
            One.AddPlayer(one);
            One.AddPlayer(two);
            One.AddPlayer(three);

            Party Two = new Party();
            Two.AddPlayer(four);
            Two.AddPlayer(five);
            Two.AddPlayer(six);


            this.TS = new TurnSystem();
            this.TS.Startup(One, Two);  



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
            
        }
        
        private void progressBar2_Click(object sender, EventArgs e)
        {
            progressBar2.Value = this.TS.ActiveParty.Squad[2].Health;
            
        
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = this.TS.ActiveParty.Squad[1].Health;
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
            this.TS.ActivePlayer.EndTurn();
        }

        private void progressBar5_Click(object sender, EventArgs e)
        {
            progressBar5.Value = this.TS
        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {
            richTextBox7.Text = this.TS.ActivePlayer.Name;
            //Current Player.Endturn Display Next Players name.
        }
    }
}

