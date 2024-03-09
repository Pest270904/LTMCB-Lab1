using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt
{
    public partial class Form5 : Form
    {
        private static bool isLegitInput(string text)
        {
            return text.All("0123456789,. ".Contains);
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter a list of scores, can only be seperated by a space or comma")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter a list of scores, can only be seperated by a space or comma";
                textBox1.ForeColor = Color.LightSlateGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isLegitInput(textBox1.Text) && String.IsNullOrEmpty(textBox1.Text)!=false)
            {
                string[] outPut;


            }
            else
                MessageBox.Show("Please re-enter your list of scores that only contain non-negative numbers and each one is separated by a space or comma.");
            //string test = "6.4, 4   2,5";
            //string[] seperate = { " ", ", ", "," };
            //string[] arr = test.Split(seperate, System.StringSplitOptions.RemoveEmptyEntries);
            //foreach (var a in arr)
            //    System.Console.Write(a);
        }
    }
}
