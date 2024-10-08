namespace TestBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string FullName;
            string FirsName;
            string LastName;

            FirsName = TxtFirstName.Text;
            LastName = TxtLastName.Text;
            FullName = LastName + " " + FirsName;

            LblShow.Text = FullName;

        }
    }
}
