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
    public partial class Profile : Form
    {
        private readonly GTService gtService;


        private int funValue = 0;
        private int copValue = 0;
        private int srsValue = 0;
        private int comValue = 0;
        private int dedValue = 0;

        public Profile()
        {
            InitializeComponent();
            countrytxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            regiontxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            platformtxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.gtService = new GTService(new GTData_Account(), new GTData_Profile(), new GTData_Games());
            this.Load += Profile_Load;
         
            AttachCheckboxEventHandlers();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            homelbl.Visible = false;
            findlbl.Visible = false;
            profilelbl.Visible = false;
            LoadUserProfile(User.UserId);
            LoadGames();

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

        public void gotofindpage(object sender, EventArgs e)
        {
            Find find = new Find();
            find.Show();
            this.Hide();
        }

        public void gotohomepage(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void AttachCheckboxEventHandlers()
        {
     
            EventHandler checkBox_CheckedChanged = (sender, e) =>
            {
                CheckBox clickedCheckbox = (CheckBox)sender;
                Debug.WriteLine($"Checkbox changed: {clickedCheckbox.Name}");
                UncheckOtherCheckboxes(clickedCheckbox);
            };

     
            foreach (CheckBox checkBox in Controls.OfType<CheckBox>())
            {
                checkBox.CheckedChanged += checkBox_CheckedChanged;

          
                switch (checkBox.Name)
                {
                    case "fun1":
                    case "fun2":
                    case "fun3":
                    case "fun4":
                    case "fun5":
                        checkBox.CheckedChanged += fun_CheckedChanged;
                        break;
                    case "cop1":
                    case "cop2":
                    case "cop3":
                    case "cop4":
                    case "cop5":
                        checkBox.CheckedChanged += cop_CheckedChanged;
                        break;
                    case "srs1":
                    case "srs2":
                    case "srs3":
                    case "srs4":
                    case "srs5":
                        checkBox.CheckedChanged += srs_CheckedChanged;
                        break;
                    case "com1":
                    case "com2":
                    case "com3":
                    case "com4":
                    case "com5":
                        checkBox.CheckedChanged += com_CheckedChanged;
                        break;
                    case "ded1":
                    case "ded2":
                    case "ded3":
                    case "ded4":
                    case "ded5":
                        checkBox.CheckedChanged += ded_CheckedChanged;
                        break;
                }
            }
        }


        private void UncheckOtherCheckboxes(CheckBox clickedCheckbox)
        {
      
            foreach (CheckBox checkBox in Controls.OfType<CheckBox>())
            {
                if (checkBox != clickedCheckbox && checkBox.Tag == clickedCheckbox.Tag)
                {
                    checkBox.Checked = false;
                }
            }
        }

        private void SaveProfileButton_Click(object sender, EventArgs e)
        {
            string username = User.Username;
            int userId = User.UserId;
            string bio = biotext.Text;
            string region = regiontxt.Text;
            string country = countrytxt.Text;
            string platform = platformtxt.Text;

            List<string> selectedGames = GetSelectedGames();


            try
            {
                bool success = gtService.SaveProfile(userId, username, bio, region, country, platform, funValue, copValue, srsValue, comValue, dedValue);

                if (success)
                {

                    success = SaveGames(selectedGames);

                    if (success)
                    {
                        MessageBox.Show("Profile saved successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to save selected games!");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to save profile!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private List<string> GetSelectedGames()
        {
            List<string> selectedGames = new List<string>();


            foreach (var selectedItem in GameBox.SelectedItems)
            {
                selectedGames.Add(selectedItem.ToString());
            }

            return selectedGames;
        }

        private bool SaveGames(List<string> selectedGames)
        {
            int userId = User.UserId;

            try
            {
                // Log the selected games
                Debug.WriteLine("Selected Games:");
                foreach (var game in selectedGames)
                {
                    Debug.WriteLine(game);
                }

                // Attempt to save the selected games
                bool success = gtService.SaveUserGames(userId, selectedGames);

                if (success)
                {
                    Debug.WriteLine("User games saved successfully.");
                }
                else
                {
                    Debug.WriteLine("Failed to save user games.");
                }

                return success;
            }
            catch (Exception ex)
            {
                // Log any exceptions that occur
                Debug.WriteLine($"An error occurred while saving user games: {ex.Message}");
                return false;
            }
        }


        private void fun_CheckedChanged(object sender, EventArgs e)
        {
            funValue = GetCheckboxValue(sender);
        }

        private void cop_CheckedChanged(object sender, EventArgs e)
        {
            copValue = GetCheckboxValue(sender);
        }

        private void srs_CheckedChanged(object sender, EventArgs e)
        {
            srsValue = GetCheckboxValue(sender);
        }

        private void com_CheckedChanged(object sender, EventArgs e)
        {
            comValue = GetCheckboxValue(sender);
        }

        private void ded_CheckedChanged(object sender, EventArgs e)
        {
            dedValue = GetCheckboxValue(sender);
        }

        private int GetCheckboxValue(object sender)
        {

            CheckBox checkBox = (CheckBox)sender;


            string categoryName = checkBox.Name.Substring(0, 3); 
            int value = int.Parse(checkBox.Name.Substring(3)); 


            if (checkBox.Checked)
            {

                return value;
            }
            else
            {

                return 0;
            }
        }

        private void LoadUserProfile(int userId)
        {

            ProfileInfo profileInfo = gtService.RetrieveProfile(userId);

            biotext.Text = profileInfo.Bio;
            regiontxt.Text = profileInfo.Region;
            countrytxt.Text = profileInfo.Country;
            platformtxt.Text = profileInfo.Region;

            funValue = profileInfo.Fun;
            copValue = profileInfo.Competitive;
            srsValue = profileInfo.Serious;
            comValue = profileInfo.Communication;
            dedValue = profileInfo.Dedication;

            SetCheckboxStates(funValue, "fun");
            SetCheckboxStates(copValue, "cop");
            SetCheckboxStates(srsValue, "srs");
            SetCheckboxStates(comValue, "com");
            SetCheckboxStates(dedValue, "ded");
        }

        private void SetCheckboxStates(int value, string category)
        {
            foreach (CheckBox checkBox in Controls.OfType<CheckBox>())
            {
                if (checkBox.Tag?.ToString() == category)
                {
                    int index = int.Parse(checkBox.Name.Substring(category.Length)); 
                    checkBox.Checked = index == value; 
                }
            }
        }

        private void LoadGames()
        {

            List<string> games = gtService.RetrieveGames();


           GameBox.Items.Clear();


            foreach (string game in games)
            {
                GameBox.Items.Add(game);
            }
        }

        


        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
