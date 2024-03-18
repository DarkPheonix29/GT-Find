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
    public partial class Profile : Form
    {

        public Profile()
        {
            InitializeComponent();
            countrytxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            regiontxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            platformtxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Profile_Load(object sender, EventArgs e)
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
    }
}
