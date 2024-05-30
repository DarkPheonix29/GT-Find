using BLL;
using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GT_Find.Lay_outs
{
    public partial class Find : Form
    {
        private readonly GTService gtService;
        public Find()
        {
            InitializeComponent();
            this.gtService = new GTService(new GTData_Account(), new GTData_Profile(), new GTData_Games());
            flowLayoutPanelProfiles.AutoScroll = true;
        }

        private void Find_Load(object sender, EventArgs e)
        {
            homelbl.Visible = false;
            findlbl.Visible = false;
            profilelbl.Visible = false;

            LoadProfiles();
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

        private void LoadProfiles()
        {
            try
            {
               
                int currentUserId = UserSession.CurrentUser.UserId; ;

        
                UserMatching userMatching = new UserMatching(gtService);

          
                List<ProfileInfo> potentialMatches = userMatching.FindMatches(currentUserId);

                Debug.WriteLine($"Number of potential matches: {potentialMatches.Count}");

             
                flowLayoutPanelProfiles.Controls.Clear();

          
                foreach (ProfileInfo profile in potentialMatches)
                {
         
                    ProfileBox profileBox = new ProfileBox();


                    profileBox.SetProfileInfo(profile.Username, profile.Bio, profile.Region, profile.Country, profile.Platform);

   
                    flowLayoutPanelProfiles.Controls.Add(profileBox);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading profiles: {ex.Message}");
            }
        }
    }
}
