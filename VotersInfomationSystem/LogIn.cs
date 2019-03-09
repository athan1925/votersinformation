using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VotersInfomationSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

    

        private void button_WOC1_Click(object sender, EventArgs e)
        {

            try {

                MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = teamjocas");
                MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from users where username ='" + txtuser.Text + "' and password ='" + txtpass.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Dashboard dba = new Dashboard(txtuser.Text);
                    dba.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password or Username");
                }

              
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error during insert: " + e1.Message);
            }
            
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            txtuser.Select();
        }
    }
}
