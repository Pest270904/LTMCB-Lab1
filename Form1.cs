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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            if (Int32.TryParse(textBox1.Text, out num1) && Int32.TryParse(textBox2.Text, out num2))
            {
                num1 = Int32.Parse(textBox1.Text.Trim());
                num2 = Int32.Parse(textBox2.Text.Trim());
                sum = num1 + num2;
                textBox3.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập vào 2 số nguyên!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
