namespace GT_Find
{
    public partial class Front : Form
    {

        public Front()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void gotologinpage(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Show();

            this.Hide();
        }
    }
}
