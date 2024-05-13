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

        // Define variables to hold checkbox values
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
            this.gtService = new GTService(new GTData());

            // Attach event handlers to checkbox changed events
            AttachCheckboxEventHandlers();
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
            // Define the event handler method
            EventHandler checkBox_CheckedChanged = (sender, e) =>
            {
                CheckBox clickedCheckbox = (CheckBox)sender;
                Debug.WriteLine($"Checkbox changed: {clickedCheckbox.Name}");
                UncheckOtherCheckboxes(clickedCheckbox);
            };

            // Attach the event handler to all checkboxes
            foreach (CheckBox checkBox in Controls.OfType<CheckBox>())
            {
                checkBox.CheckedChanged += checkBox_CheckedChanged;

                // Assign the specific event handler based on the checkbox name
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
            // Uncheck other checkboxes in the same group
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
            string bio = boitext.Text;
            string region = regiontxt.Text;
            string country = countrytxt.Text;
            string platform = platformtxt.Text;

            // Pass checkbox values directly to the service method
            try
            {
                bool success = gtService.SaveProfile(userId, bio, region, country, platform, funValue, copValue, srsValue, comValue, dedValue);

                if (success)
                {
                    MessageBox.Show("Profile saved successfully!");
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

        // Event handlers for checkbox changes
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
            // Cast the sender object to a CheckBox type
            CheckBox checkBox = (CheckBox)sender;

            // Get the category from the checkbox name (e.g., "fun1", "cop2", etc.)
            string categoryName = checkBox.Name.Substring(0, 3); // Extract the first three characters
            int value = int.Parse(checkBox.Name.Substring(3)); // Extract the remaining characters as the value

            // Check if the checkbox is checked
            if (checkBox.Checked)
            {
                // If checked, return the value
                return value;
            }
            else
            {
                // If not checked, return 0 as the default value
                return 0;
            }
        }
    }
}
