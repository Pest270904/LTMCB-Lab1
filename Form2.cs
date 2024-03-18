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

            double num1, num2, num3;
            inputNum1TB.Text=inputNum1TB.Text.Replace(',', '.');
            inputNum2TB.Text=inputNum2TB.Text.Replace(',', '.');
            inputNum3TB.Text=inputNum3TB.Text.Replace(',', '.');
            if (double.TryParse(inputNum1TB.Text, out num1) && double.TryParse(inputNum2TB.Text, out num2)  && double.TryParse(inputNum3TB.Text, out num3))
            {
                maxTB.Text = Math.Max(num1, Math.Max(num2, num3)).ToString();
                minTB.Text = Math.Min(num1, Math.Min(num2, num3)).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập vào 3 số.");
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
