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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonDoc_Click(object sender, EventArgs e)
        {
            int num;
            if(Int32.TryParse(inputTB.Text, out num) && num >= 0 && num <= 9)
            {
                switch(num)
                {
                    case 0:
                        ansTB.Text = "Không";
                        break;
                    case 1:
                        ansTB.Text = "Một";
                        break;
                    case 2:
                        ansTB.Text = "Hai";
                        break;
                    case 3:
                        ansTB.Text = "Ba";
                        break;
                    case 4:
                        ansTB.Text = "Bốn";
                        break;
                    case 5:
                        ansTB.Text = "Năm";
                        break;
                    case 6:
                        ansTB.Text = "Sáu";
                        break;
                    case 7:
                        ansTB.Text = "Bảy";
                        break;
                    case 8:
                        ansTB.Text = "Tám";
                        break;
                    case 9:
                        ansTB.Text = "Chín";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập vào 1 số nguyên từ 0 đến 9.");
            }
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            inputTB.Clear();
            ansTB.Clear();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
