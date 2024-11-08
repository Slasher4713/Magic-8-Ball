using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_8_Ball
{
    
    public partial class Form1 : Form
    {
        Random gen = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void magicButton_Click_1(object sender, EventArgs e)
        {
            int rando = gen.Next(1, 7);
            switch (rando)
            {
                case 1:
                    magicOutput.Text = "It is certain";
                    break;
                case 2:
                    magicOutput.Text = "Ask again later";
                    break;
                case 3:
                    magicOutput.Text = "Signs point to yes";
                    break;
                case 4:
                    magicOutput.Text = "Very doubtful";
                    break;
                case 5:
                    magicOutput.Text = "Concentrate and ask again";
                    break;
                case 6:
                    magicOutput.Text = "My sources say no";
                    break;
            }
        }
    }
}
