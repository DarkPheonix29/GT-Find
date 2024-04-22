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
            fun1.CheckedChanged += fun_CheckedChanged;
            fun2.CheckedChanged += fun_CheckedChanged;
            fun3.CheckedChanged += fun_CheckedChanged;
            fun4.CheckedChanged += fun_CheckedChanged;
            fun5.CheckedChanged += fun_CheckedChanged;

            comp1.CheckedChanged += comp_CheckedChanged;
            comp2.CheckedChanged += comp_CheckedChanged;
            comp3.CheckedChanged += comp_CheckedChanged;
            comp4.CheckedChanged += comp_CheckedChanged;
            comp5.CheckedChanged += comp_CheckedChanged;

            srs1.CheckedChanged += srs_CheckedChanged;
            srs2.CheckedChanged += srs_CheckedChanged;
            srs3.CheckedChanged += srs_CheckedChanged;
            srs4.CheckedChanged += srs_CheckedChanged;
            srs5.CheckedChanged += srs_CheckedChanged;

            com1.CheckedChanged += com_CheckedChanged;
            com2.CheckedChanged += com_CheckedChanged;
            com3.CheckedChanged += com_CheckedChanged;
            com4.CheckedChanged += com_CheckedChanged;
            com5.CheckedChanged += com_CheckedChanged;

            ded1.CheckedChanged += ded_CheckedChanged;
            ded2.CheckedChanged += ded_CheckedChanged;
            ded3.CheckedChanged += ded_CheckedChanged;
            ded4.CheckedChanged += ded_CheckedChanged;
            ded5.CheckedChanged += ded_CheckedChanged;
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

        private void fun_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckbox = (CheckBox)sender;

            if (clickedCheckbox.Checked)
            {
                CheckBox[] checkboxes = { fun1, fun2, fun3, fun4, fun5 };

                foreach (CheckBox checkbox in checkboxes)
                {
                    if (checkbox != clickedCheckbox)
                    {
                        checkbox.Checked = false;
                    }
                }
            }
        }

        private void comp_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckbox = (CheckBox)sender;

            if (clickedCheckbox.Checked)
            {
                CheckBox[] checkboxes = { comp1, comp2, comp3, comp4, comp5 };

                foreach (CheckBox checkbox in checkboxes)
                {
                    if (checkbox != clickedCheckbox)
                    {
                        checkbox.Checked = false;
                    }
                }
            }
        }

        private void srs_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckbox = (CheckBox)sender;

            if (clickedCheckbox.Checked)
            {
                CheckBox[] checkboxes = { srs1, srs2, srs3, srs4, srs5 };

                foreach (CheckBox checkbox in checkboxes)
                {
                    if (checkbox != clickedCheckbox)
                    {
                        checkbox.Checked = false;
                    }
                }
            }
        }

        private void com_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckbox = (CheckBox)sender;

            if (clickedCheckbox.Checked)
            {
                CheckBox[] checkboxes = { com1, com2, com3, com4, com5 };

                foreach (CheckBox checkbox in checkboxes)
                {
                    if (checkbox != clickedCheckbox)
                    {
                        checkbox.Checked = false;
                    }
                }
            }
        }

        private void ded_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckbox = (CheckBox)sender;

            if (clickedCheckbox.Checked)
            {
                CheckBox[] checkboxes = { ded1, ded2, ded3, ded4, ded5 };

                foreach (CheckBox checkbox in checkboxes)
                {
                    if (checkbox != clickedCheckbox)
                    {
                        checkbox.Checked = false;
                    }
                }
            }
        }

    }
}
