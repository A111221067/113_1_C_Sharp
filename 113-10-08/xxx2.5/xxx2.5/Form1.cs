namespace xxx2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //#@$!$!$#!
        private void BtnBack_Click(object sender, EventArgs e)
        {
            PtxBack.Visible = true;
            PtxFromt.Visible = false;

        }
        //$!#%$!$
        private void BtnFRomt_Click(object sender, EventArgs e)
        {
            PtxBack.Visible = false;
            PtxFromt.Visible = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
