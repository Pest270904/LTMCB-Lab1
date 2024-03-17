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

        private void buttonThucHien_Click(object sender, EventArgs e)
        {
            string sBase1 = base1CB.Text, sBase2 = base2CB.Text;
            
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
            else
                switch (sBase1)
                {
                    case "Binary":
                        {
                            if (IsBin(inputTB.Text) && !String.IsNullOrEmpty(inputTB.Text))
                            {
                                int inputValue_dec = Convert.ToInt32(inputTB.Text, 2);
                                ansTB.Text = Convert.ToString(inputValue_dec, iBase2);
                            }
                            else
                                MessageBox.Show("Nhập vào 1 số nhị phân");
                            break;
                        }
                    case "Octal":
                        {
 
                            if (IsOctal(inputTB.Text) && !String.IsNullOrEmpty(inputTB.Text))
                            {
                                int inputValue_dec = Convert.ToInt32(inputTB.Text, 8);
                                ansTB.Text = Convert.ToString(inputValue_dec, iBase2);
                            }
                            else
                                MessageBox.Show("Nhập vào 1 số bát phân");
                            break;
                        }
                    case "Decimal":
                        {
                            int inputValue;
                            if (Int32.TryParse(inputTB.Text, out inputValue))
                            {
                                ansTB.Text = Convert.ToString(inputValue, iBase2);
                            }
                            else
                                MessageBox.Show("Nhập vào 1 số nguyên");
                            break;
                        }
                    case "Hexadecimal":
                        {
                            if (IsHex(inputTB.Text.ToUpper()) && !String.IsNullOrEmpty(inputTB.Text))
                            {
                                int inputValue_dec = Convert.ToInt32(inputTB.Text, 16);
                                ansTB.Text = Convert.ToString(inputValue_dec, iBase2);
                            }
                            else
                                MessageBox.Show("Nhập vào 1 số thập lục phân");
                            break;
                        }
                }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            inputTB.Clear();
            base1CB.Text = "";
            base2CB.Text = "";
            ansTB.Clear();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
