using BLL;
using DAL;
using GT_Find.Lay_outs;
using System;
using System.Windows.Forms;

namespace GT_Find
{
    public partial class Signup : Form
    {
        private readonly GTService gtService;

        public Signup()
        {
            InitializeComponent();
            this.gtService = new GTService(new GTData_Account(), new GTData_Profile(), new GTData_Games());
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            // Initialize the form if needed
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            string passwordtext = passsutext.Text;
            string passwordconfirm = passsutext2.Text;

            if (passwordtext != passwordconfirm)
            {
                MessageBox.Show("Passwords do not match. Please re-enter your password.");
                return;
            }

            string email = emailsutext.Text;
            string username = usersutext.Text;

            if (!BLL.Validators.Validator.IsValidUsername(username))
            {
                MessageBox.Show("Username cannot be longer than 20 characters.");
                return;
            }

            // Hash password
            string hashedPassword = AuthManager.SecurePassword(passwordtext);

            // Call GTService method to create account
            bool accountCreated = gtService.CreateAccount(email, hashedPassword, username);

            if (accountCreated)
            {
                MessageBox.Show("Account Created!");

                // Open login form
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to create account. Please try again later.");
            }
        }
    }
}
