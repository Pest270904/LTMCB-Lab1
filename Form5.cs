﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bt
{

    public partial class Form5 : Form
    {
        public static string placeHolder = "Enter a list of scores, can only be seperated by a space or comma     Ex: 5.75 3 5";
        public static string errorMsg = "- Please re-enter your list of scores that only contain non-negative numbers " +
                    "which is <= 10." +
                    "\n- Each one is separated by a space or comma.";
        private static bool isLegitInput(string text)
        {
            if (!text.All("0123456789,. ".Contains))
                return false;
            string[] seperate = { " ", ", ", "," };
            string[] arr = text.Split(seperate, System.StringSplitOptions.RemoveEmptyEntries);
            foreach (var each in arr)
                if (Convert.ToDouble(each) > 10)
                    return false;
            return true;
        }
        public Form5()
        {
            InitializeComponent();
            inputTB.Text = placeHolder;
            inputTB.ForeColor = Color.LightSlateGray;
        }

        private void inputTB_Enter(object sender, EventArgs e)
        {
            if (inputTB.Text == placeHolder)
            {
                inputTB.Text = "";
                inputTB.ForeColor = Color.Black;
            }
        }

        private void inputTB_Leave(object sender, EventArgs e)
        {
            if (inputTB.Text == "")
            {
                inputTB.Text = placeHolder;
                inputTB.ForeColor = Color.LightSlateGray;
            }
        }

        private void buttonXuat_Click(object sender, EventArgs e)
        {
            listScoreTB.Clear();
            avgTB.Clear();
            maxScoreTB.Clear();
            minScoreTB.Clear();
            passTB.Clear();
            failTB.Clear();
            finalTB.Clear();

            try {
                if (isLegitInput(inputTB.Text))
                {
                    string[] seperate = { " ", ", ", "," };
                    string[] listOfScores = inputTB.Text.Split(seperate, System.StringSplitOptions.RemoveEmptyEntries);
                    int i = 1, pass = 0, fail = 0;
                    double avg = 0, dMin = 11, dMax = 0;
                    foreach (var score in listOfScores)
                    {
                        double dScore = (double)System.Math.Round(Convert.ToDouble(score),2);
                        if (dScore < 5)
                            fail++;
                        else pass++;
                        avg += dScore;
                        dMin = Math.Min(dMin, dScore);
                        dMax = Math.Max(dMax, dScore);

                        listScoreTB.Text += ("Môn học " + i.ToString() + ": " + dScore.ToString() + "đ" + '\t');
                        if (i % 5 == 0)
                            listScoreTB.AppendText(Environment.NewLine);
                        i++;
                    }

                    avgTB.Text = "Điểm trung bình: " + (avg / (i - 1)).ToString("0.00");
                    maxScoreTB.Text = "Điểm cao nhất: " + dMax.ToString();
                    minScoreTB.Text = "Điểm thấp nhất: " + dMin.ToString();
                    passTB.Text = "Số môn đậu: " + pass.ToString();
                    failTB.Text = "Số môn rớt: " + fail.ToString();

                    if (avg >= 8 && dMin >= 6.5)
                        finalTB.Text = "Xếp loại học lực: Giỏi";
                    else if (avg >= 6.5 && dMin >= 5)
                        finalTB.Text = "Xếp loại học lực: Khá";
                    else if (avg >= 5 && dMin >= 3.5)
                        finalTB.Text = "Xếp loại học lực: TB";
                    else if (avg >= 3.5 && dMin >= 2)
                        finalTB.Text = "Xếp loại học lực: Yếu";
                    else
                        finalTB.Text = "Xếp loại học lực: Kém";
                }
                else
                    MessageBox.Show(errorMsg);
            }
            catch(Exception ex)
            {
                MessageBox.Show(errorMsg);
            }
        }
    }
}
