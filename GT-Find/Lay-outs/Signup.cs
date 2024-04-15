using MySql.Data.MySqlClient;
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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            string server = "studmysql01.fhict.local";
            string uid = "dbi540357";
            string password = "Kealan2002";
            string database = "dbi540357";
            string constring = "server=" + server + ";uid=" + uid + ";database=" + database + ";pwd=" + password + ";";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string query = "insert into account (Email, Password, Username) values('"+ emailsutext.Text+"','"+passsutext.Text+"','"+usertext.Text+"')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            if (i > -1) 
            {
                MessageBox.Show("Data Succesfully inserted");
            }

        }
    }
}
