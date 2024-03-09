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

        private void buttonTim_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            if (Int32.TryParse(inputNum1TB.Text, out num1) && Int32.TryParse(inputNum2TB.Text, out num2)  && Int32.TryParse(inputNum3TB.Text, out num3))
            {
                num1 = Int32.Parse(inputNum1TB.Text.Trim());
                num2 = Int32.Parse(inputNum2TB.Text.Trim());
                num3 = Int32.Parse(inputNum3TB.Text.Trim());
                maxTB.Text = Math.Max(num1, Math.Max(num2, num3)).ToString();
                minTB.Text = Math.Min(num1, Math.Min(num2, num3)).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập vào 3 số nguyên!!");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            inputNum1TB.Clear();
            inputNum2TB.Clear();
            inputNum3TB.Clear();
            maxTB.Clear();
            minTB.Clear();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
