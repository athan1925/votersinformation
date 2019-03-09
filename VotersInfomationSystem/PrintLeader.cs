using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VotersInfomationSystem
{
    public partial class PrintLeader : UserControl
    {
        string Leaderselect;
        MySqlConnection conn;
        string connString;
        public PrintLeader()
        {
            InitializeComponent();
            txtsearchvoters.Enabled = false;
            btnprintvoters.Enabled = false;
        }
        void autotxtbarangay1()
        {
            connString = "server = localhost; user id = root; database = teamjocas";

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                string sql = "Select brgyname From barangaylist ";
                MySqlCommand msqlc = new MySqlCommand(sql, conn);
                MySqlDataReader mdr = msqlc.ExecuteReader();
                AutoCompleteStringCollection autotxtcom12 = new AutoCompleteStringCollection();

                while (mdr.Read())
                {
                    autotxtcom12.Add(mdr.GetString(0));
                }

                txtsearchvoters.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtsearchvoters.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtsearchvoters.AutoCompleteCustomSource = autotxtcom12;
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void autotxtleader1()
        {
            connString = "server = 192.168.0.10; user id = root; database = teamjocas";

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                string sql = "Select fullname From coorlist ";
                MySqlCommand msqlc = new MySqlCommand(sql, conn);
                MySqlDataReader mdr = msqlc.ExecuteReader();
                AutoCompleteStringCollection autotxtcoor123 = new AutoCompleteStringCollection();

                while (mdr.Read())
                {
                    autotxtcoor123.Add(mdr.GetString(0));
                }

                txtsearchvoters.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtsearchvoters.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtsearchvoters.AutoCompleteCustomSource = autotxtcoor123;
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtsearchvoters.Clear();
            btnprintvoters.Enabled = true;
            autotxtleader1();
            txtsearchvoters.Focus();
            Leaderselect = "Barangay";
            txtsearchvoters.Enabled = true;
        }

        private void radiobarangay_CheckedChanged(object sender, EventArgs e)
        {
            autotxtbarangay1();
            txtsearchvoters.Clear();
            btnprintvoters.Enabled = true;
            txtsearchvoters.Focus();
            Leaderselect = "Coordinator";
            
            txtsearchvoters.Enabled = true;
        }

        private void btnprintvoters_Click(object sender, EventArgs e)
        {
            if (txtsearchvoters.Text == "")
            {
                MessageBox.Show("Please Enter the Name of Coordinator or the Barangay");
            }
            else
            {
                if (Leaderselect == "Barangay")
                {
                    try
                    {

                        MessageBox.Show("Under Maintenace for Barangay Selection");
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                else if (Leaderselect == "Coordinator")
                {
                    try
                    {
                        MessageBox.Show("Under Maintenace for Coordinator Selection");

                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please Select ");
                }
            }
        }
    }
}
