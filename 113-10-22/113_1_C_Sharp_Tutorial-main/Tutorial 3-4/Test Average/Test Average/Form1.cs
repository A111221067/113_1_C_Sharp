﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(test1TextBox.Text, out decimal test1) &&
                decimal.TryParse(test2TextBox.Text, out decimal test2) &&
                decimal.TryParse(test3TextBox.Text, out decimal test3))
            {
              
                decimal average = (test1 + test2 + test3) / 3;

               
                averageLabel.Text = average.ToString("F2"); 
            }
            else
            {
                
                MessageBox.Show("請輸入有效的數值", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

