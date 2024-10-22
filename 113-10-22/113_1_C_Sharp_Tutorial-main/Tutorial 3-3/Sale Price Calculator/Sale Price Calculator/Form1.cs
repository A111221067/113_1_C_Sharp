using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void originalPricePromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(originalPriceTextBox.Text, out decimal originalPrice) &&
               decimal.TryParse(discountPercentageTextBox.Text, out decimal discountPercentage))
            {
                // 計算折扣後的價格
                decimal discountAmount = originalPrice * (discountPercentage / 100);
                decimal salePrice = originalPrice - discountAmount;

                // 將結果顯示在文本框中
                salePriceLabel.Text = salePrice.ToString("c"); // "c" 代表貨幣格式
            }
            else
            {
                // 顯示錯誤訊息
                MessageBox.Show("請輸入有效的數值", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    