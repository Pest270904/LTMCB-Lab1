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
            inputNum2TB.Clear();
            inputNum1TB.Clear();
            ansTB.Clear();
        }

        private void buttonTinh_Click(object sender, EventArgs e)
        {
            int num1, num2;
            if (Int32.TryParse(inputNum2TB.Text, out num1) && Int32.TryParse(inputNum1TB.Text, out num2))
            {
                long sum = num1 + num2;
                ansTB.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập vào 2 số nguyên!!");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
