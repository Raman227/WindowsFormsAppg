using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        private int randomNumber = 0;
        private int chances = 3;

        private void Form1_Load(object sender, EventArgs e)
        {
            randomNumber = rand.Next(0, 10);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = randomNumber + "";
            //MessageBox.show(convert.Tostring(randomNumber));
            if (chances > 0)
            {
                if (Convert.ToInt32(textBox1.Text) == randomNumber)

                {
                    MessageBox.Show("you win");
                }
                else if (Convert.ToInt32(textBox1.Text) != randomNumber)
                {
                    MessageBox.Show("you have " + chances + " number of chance(s) left");
                    //chances = chances -1;
                    //chances -=1;
                    chances--;
                    //Text.Visible = false;7
                }
                else
                {
                    MessageBox.Show("you lose");
                }

            }


        }
    }
}