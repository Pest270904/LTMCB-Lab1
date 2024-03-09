using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt
{
    public partial class Form4 : Form
    {
        private static bool IsBin(string text)
        {
            return text.All("01".Contains);
        }
        private static bool IsOctal(string text)
        {
            return text.All("01234567".Contains);
        }
        private static bool IsDec(string text)
        {
            return text.All("0123456789".Contains);
        }
        private static bool IsHex(string text)
        {
            return text.All("0123456789ABCDEF".Contains);
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sBase1 = comboBox1.Text, sBase2 = comboBox2.Text;
            
            int iBase2;
            if (sBase2 == "Binary")
                iBase2 = 2;
            else if (sBase2 == "Octal")
                iBase2 = 8;
            else if (sBase2 == "Decimal")
                iBase2 = 10;
            else iBase2 = 16;

            if (string.IsNullOrEmpty(sBase1) || string.IsNullOrEmpty(sBase2))
                MessageBox.Show("Vui lòng chọn 2 kiểu chuyển đổi");

            switch (sBase1)
            {
                case "Binary":
                    {
                        if (IsBin(textBox1.Text))
                        {
                            int inputValue_dec = Convert.ToInt32(textBox1.Text, 2);
                            textBox2.Text = Convert.ToString(inputValue_dec, iBase2);
                        }
                        else
                            MessageBox.Show("Nhập vào 1 số nhị phân");
                        break;
                    }
                case "Octal":
                    {
 
                        if (IsOctal(textBox1.Text))
                        {
                            int inputValue_dec = Convert.ToInt32(textBox1.Text, 8);
                            textBox2.Text = Convert.ToString(inputValue_dec, iBase2);
                        }
                        else
                            MessageBox.Show("Nhập vào 1 số bát phân");
                        break;
                    }
                case "Decimal":
                    {
                        int inputValue;
                        if (Int32.TryParse(textBox1.Text, out inputValue))
                        {
                            textBox2.Text = Convert.ToString(inputValue, iBase2);
                        }
                        else
                            MessageBox.Show("Nhập vào 1 số nguyên");
                        break;
                    }
                case "Hexadecimal":
                    {
                        if (IsHex(textBox1.Text.ToUpper()))
                        {
                            int inputValue_dec = Convert.ToInt32(textBox1.Text, 16);
                            textBox2.Text = Convert.ToString(inputValue_dec, iBase2);
                        }
                        else
                            MessageBox.Show("Nhập vào 1 số thập lục phân");
                        break;
                    }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
