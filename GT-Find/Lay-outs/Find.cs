using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GT_Find.Lay_outs
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }

        private void Find_Load(object sender, EventArgs e)
        {
            homelbl.Visible = false;
            findlbl.Visible = false;
            profilelbl.Visible = false;
        }

        private void openmenu(object sender, EventArgs e)
        {
            if (homelbl.Visible == false && findlbl.Visible == false && profilelbl.Visible == false)
            {
                homelbl.Visible = true;
                findlbl.Visible = true;
                profilelbl.Visible = true;
            }
            else if (homelbl.Visible == true && findlbl.Visible == true && profilelbl.Visible == true)
            {
                homelbl.Visible = false;
                findlbl.Visible = false;
                profilelbl.Visible = false;
            }
        }
        public void gotoprofilepage(object sender, EventArgs e)
        {
            Profile profile = new Profile();

            profile.Show();

            this.Hide();
        }
        public void gotohomepage(object sender, EventArgs e)
        {
            Home home = new Home();

            home.Show();

            this.Hide();
        }
    }
}
