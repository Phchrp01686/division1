using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace division
{
    public partial class Form1 : Form
    {
        int num11, num12, num13;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num11 = int.Parse(Display.Text);
            Display.Text = "";
            op = "/";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            num12=int.Parse(Display.Text);
            if (op == "/")
            {
                num13 = num11 / num12;
                Display.Text = num13.ToString();
            }//Close /
        }

        private void OFF_Click(object sender, EventArgs e)
        {
          
        }

        private void CE_Click(object sender, EventArgs e)
        {
            Display.Text = "";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "0";
        }
    }
}
