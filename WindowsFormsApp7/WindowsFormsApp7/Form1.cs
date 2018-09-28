using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        int conde = 0;
        Boolean limite = false;

        conde c = new conde(4);

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = 0.ToString();

            c.ThresholdReached += c_ThresholdReached;
        }
        public void c_ThresholdReached(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.perritoalerta;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conde++;
            textBox1.Text = conde.ToString();
            c.Add(conde);

            if(limite)
            {
                if(conde<5)
                {
                    textBox1.Text = conde.ToString();
                }
                else
                {
                    textBox1.Text = 5.ToString();
                    conde = 5;
                }
            }
            else
            {
                if (conde<10)
                {
                    textBox1.Text = conde.ToString();
                }
                else
                {
                    textBox1.Text = 10.ToString();
                    conde = 10;
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            conde = trackBar1.Value;
            c.Add(conde);

            if (conde<4)
            {
                pictureBox1.Image = Properties.Resources.noalerta;
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            trackBar1.Value = conde;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int currentValue = 0;
            limite = checkBox1.Checked;

            if(limite)
            {
                trackBar1.Maximum = 5;
                currentValue =Convert.ToInt16(textBox1.Text);

                if(currentValue > 5)
                {
                    textBox1.Text = 5.ToString();
                }

            }
            else
            {
                trackBar1.Maximum = 10;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
