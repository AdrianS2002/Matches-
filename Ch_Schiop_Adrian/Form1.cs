using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_Schiop_Adrian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tura = 1;
            label2.Text = "Player 1";
            label3.Visible = false;
        }

        int tura;

        void win()
        {
            if(pictureBox1.Visible == false &&
            pictureBox2.Visible == false &&
            pictureBox3.Visible == false &&
            pictureBox4.Visible == false &&
            pictureBox5.Visible == false &&
            pictureBox6.Visible == false &&
            pictureBox7.Visible == false &&
            pictureBox8.Visible == false &&
            pictureBox9.Visible == false &&
            pictureBox10.Visible == false &&
            pictureBox11.Visible == false &&
            pictureBox12.Visible == false &&
            pictureBox13.Visible == false &&
            pictureBox14.Visible == false &&
            pictureBox15.Visible == false &&
            pictureBox16.Visible == false)
            {
                label3.Visible =true;
                if (tura == 1)
                {
                    label3.Text = "Player 2 wins!";

                }
                else
                    label3.Text = "Player 1 wins!";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            win();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            win();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            win();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            win();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            win();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            win();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            win();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            win();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            win();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = false;
            win();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Visible = false;
            win();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Visible = false;
            win();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Visible = false;
            win();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = false;
            win();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Visible = false;
            win();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Visible = false;
            win();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restart_Click(object sender, EventArgs e)
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
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            tura = 1;
            label2.Text = "Player 1";
            label3.Visible = false;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (tura == 1)
            {
                tura = 2;
                label2.Text = "Player 2";

            }
            else
            {
                tura = 1;
                label2.Text = "Player 1";
            }
        }
    }
}
