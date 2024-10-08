namespace home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BntShow.Text = "方塊8";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            BntShow.Text = "方塊5";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BntShow.Text = "方塊J";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            BntShow.Text = "紅心2";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BntShow.Text = "梅花6";
        }

        private void BntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
