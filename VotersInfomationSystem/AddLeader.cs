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
    public partial class AddLeader : UserControl
    {
        MySqlConnection conn;
        string connString;
        
        public AddLeader()
        {
            InitializeComponent();
            lblalready.Visible = false;
            lblalready.Text = "This leader is Already Exist !!!";
            txtleadname1.Focus();
            autotxtleadersource();
            autotxtcoor();
            autotxtbarangay();
        }

        private void AddLeader_Load(object sender, EventArgs e)
        {
            //autotxtleadersource();
           // autotxtcoor();

        }
        void autotxtcoor()
        {
            connString = "server = localhost; user id = root; database = teamjocas";

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                string sql = "Select fullname From coorlist";
                MySqlCommand msqlc = new MySqlCommand(sql, conn);
                MySqlDataReader mdr = msqlc.ExecuteReader();
                AutoCompleteStringCollection autotxtcoorname = new AutoCompleteStringCollection();

                while (mdr.Read())
                {
                    autotxtcoorname.Add(mdr.GetString(0));
                }

                txtleadcoornama1.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtleadcoornama1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtleadcoornama1.AutoCompleteCustomSource = autotxtcoorname;
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void autotxtbarangay()
        {
            connString = "server = localhost; user id = root; database = teamjocas";

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                string sql = "Select brgyname From barangaylist";
                MySqlCommand msqlc = new MySqlCommand(sql, conn);
                MySqlDataReader mdr = msqlc.ExecuteReader();
                AutoCompleteStringCollection autotxtbrgy = new AutoCompleteStringCollection();

                while (mdr.Read())
                {
                    autotxtbrgy.Add(mdr.GetString(0));
                }

                txtleadbar1.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtleadbar1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtleadbar1.AutoCompleteCustomSource = autotxtbrgy;
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void autotxtleadersource()
        {
            connString = "server = localhost; user id = root; database = teamjocas";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                string sql = "Select fullname From source";
                MySqlCommand msqlc = new MySqlCommand(sql, conn);
                MySqlDataReader mdr = msqlc.ExecuteReader();
                AutoCompleteStringCollection autotxtcoorname1 = new AutoCompleteStringCollection();

                while (mdr.Read())
                {
                    autotxtcoorname1.Add(mdr.GetString(0));
                }

                txtleadname1.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtleadname1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtleadname1.AutoCompleteCustomSource = autotxtcoorname1;
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void ClearAll()
        {
            txtleadname1.Text = "";
            txtleadbar1.Text = "";
            txtleadcoornama1.Text = "";

        }
        private void button_WOC1_Click(object sender, EventArgs e)
        {
            if (txtleadname1.Text == "" || txtleadbar1.Text == "" || txtleadcoornama1.Text == "")
            {
                MessageBox.Show("Please Fill the TextBox");
            }
            else
            {
                try {
                    MySqlConnection sqlcon = new MySqlConnection("server = localhost; user id = root; database = teamjocas");
                    sqlcon.Open();
                    MySqlDataAdapter sa = new MySqlDataAdapter("insert into leaderlist(fullname,barangay,coorname)  values ('" + txtleadname1.Text + "', '" + txtleadbar1.Text + "', '" + txtleadcoornama1.Text + "')", sqlcon);
                    DataTable dt = new DataTable();
                    sa.Fill(dt);
                    sqlcon.Close();
                    MessageBox.Show("New Leader of TEAM JOCAS succesfully Added");
                    ClearAll();
                   

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void txtleadname1_TextChanged(object sender, EventArgs e)
        {

            MySqlConnection sqlcon2 = new MySqlConnection("server = localhost; user id = root; database = teamjocas");
            string sql123 = "select count(fullname) from leaderlist where fullname = '" + txtleadname1.Text + "'";
            MySqlCommand msqa = new MySqlCommand(sql123, sqlcon2);
            sqlcon2.Open();
            int temp = Convert.ToInt32(msqa.ExecuteScalar().ToString());
            if (temp > 0)
            {
                lblalready.Visible = true;
                MessageBox.Show("This leader is Already Exist !!!");
                ClearAll();
                lblalready.Visible = false;
            }

           
        }
    }
}
