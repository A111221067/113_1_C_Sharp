using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        private decimal total = 0m;
        public Form1()
        {
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            AddToTotal(0.05m);
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            AddToTotal(0.10m);
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            AddToTotal(0.25m);
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            AddToTotal(0.50m);
        }
        private void AddToTotal(decimal amount)
        {
            total += amount;
            totalLabel.Text = total.ToString("c"); 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctBot_Click(object sender, EventArgs e)
        {
            totalLabel.Text = "";
        }
    }
}
