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
    public partial class ProfileBox : UserControl
    {
        public ProfileBox()
        {
            InitializeComponent();
            this.Load += ProfileBox_Load;
        }

        private void ProfileBox_Load(object sender, EventArgs e)
        {
            // Handle the load event
        }

        public void SetProfileInfo(string username, string bio, string region, string country, string platform)
        {
            lblUsername.Text = username;
            lblBio.Text = bio;
            lblRegion.Text = region;
            lblCountry.Text = country;
            lblPlatform.Text = platform;
        }

    }
}
