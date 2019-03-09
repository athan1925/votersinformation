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
    public partial class AddCoor : UserControl
    {
        MySqlConnection conn;
        string connString;
        public AddCoor()
        {
            InitializeComponent();
            lblalready.Visible = false;
            autotxtcoorsource();
            autotxtbarangay();
            lblalready.Text = "This Coordinator is Already Exist !!!";
        }

        void ClearAll()
        {

            txtlcoorname.Text = "";
            txtbarname.Text = "";
        }
        void autotxtcoorsource()
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

                txtlcoorname.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtlcoorname.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtlcoorname.AutoCompleteCustomSource = autotxtcoorname1;
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

                txtbarname.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtbarname.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtbarname.AutoCompleteCustomSource = autotxtbrgy;
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void Cleartxtnow()
        {
            txtlcoorname.Text = "";
            txtbarname.Text = "";
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            if (txtlcoorname.Text == "" || txtbarname.Text == "" )
            {
                MessageBox.Show("Please Fill the TextBox");
            }
            else
            {
                try
                {

                    MySqlConnection sqlcon = new MySqlConnection("server = localhost; user id = root; database = teamjocas");
                    sqlcon.Open();
                    MySqlDataAdapter sa = new MySqlDataAdapter("insert into coorlist(fullname,barangay)  values ('" + txtlcoorname.Text + "', '" + txtbarname.Text + "')", sqlcon);
                    DataTable dt = new DataTable();
                    sa.Fill(dt);
                    sqlcon.Close();
                    MessageBox.Show("New Coordinator of TEAM JOCAS succesfully Added");
                    Cleartxtnow();
                    txtlcoorname.Focus();

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void txtlcoorname_TextChanged(object sender, EventArgs e)
        {

            MySqlConnection sqlcon2 = new MySqlConnection("server = localhost; user id = root; database = teamjocas");
            string sql123 = "select count(fullname) from coorlist where fullname = '" + txtlcoorname.Text + "'";
            MySqlCommand msqa = new MySqlCommand(sql123, sqlcon2);
            sqlcon2.Open();
            int temp = Convert.ToInt32(msqa.ExecuteScalar().ToString());
            if (temp > 0)
            {
                lblalready.Visible = true;
                MessageBox.Show("This Coordinator is Already Exist !!!");
                ClearAll();
                lblalready.Visible = false;
                txtlcoorname.Focus();
            }
        }

        private void AddCoor_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtbarname_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
