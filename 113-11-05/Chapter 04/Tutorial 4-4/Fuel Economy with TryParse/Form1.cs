using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double Kms;
            double liters;
            if (double.TryParse(milesTextBox.Text.out Kms));
            {
                if (double.TryParse(gallonsTextBox.Text.out liters));
            }
               else;
            {
                MessageBox.Show("xxxxxxxxxxx");
            }
         else;
          {
                MessageBox.Show("xxxxxxxxxxx");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
