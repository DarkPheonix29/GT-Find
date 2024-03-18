using GT_Find.Lay_outs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GT_Find
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void gotohomepage (object sender, EventArgs e)
        {
            Home home = new Home();

            home.Show();

            this.Hide();
        }

        private void emailtext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
