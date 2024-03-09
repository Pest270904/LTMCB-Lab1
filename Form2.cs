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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            if (Int32.TryParse(textBox1.Text, out num1) && Int32.TryParse(textBox2.Text, out num2)  && Int32.TryParse(textBox2.Text, out num2))
            {
                num1 = Int32.Parse(textBox1.Text.Trim());
                num2 = Int32.Parse(textBox2.Text.Trim());
                num3 = Int32.Parse(textBox3.Text.Trim());
                textBox4.Text = Math.Max(num1, Math.Max(num2, num3)).ToString();
                textBox5.Text = Math.Min(num1, Math.Min(num2, num3)).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập vào 3 số nguyên!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
