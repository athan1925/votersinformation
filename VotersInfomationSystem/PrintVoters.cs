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
    public partial class PrintVoters : UserControl
    {
        string Leaderselect;
        MySqlConnection conn;
        string connString;
        public PrintVoters()
        {
            InitializeComponent();
            txtsearchvoters.Enabled = false;
            btnprintvoters.Enabled = false;


        }

        void autotxtbarangay()
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
                AutoCompleteStringCollection autotxtcom1 = new AutoCompleteStringCollection();

                while (mdr.Read())
                {
                    autotxtcom1.Add(mdr.GetString(0));
                }

                txtsearchvoters.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtsearchvoters.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtsearchvoters.AutoCompleteCustomSource = autotxtcom1;
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            void autotxtleader()
            {
                connString = "server = localhost; user id = root; database = teamjocas";

                try
                {
                    conn = new MySqlConnection();
                    conn.ConnectionString = connString;
                    conn.Open();
                    string sql = "Select fullname From leaderlist ";
                    MySqlCommand msqlc = new MySqlCommand(sql, conn);
                    MySqlDataReader mdr = msqlc.ExecuteReader();
                    AutoCompleteStringCollection autotxtcoor12 = new AutoCompleteStringCollection();

                    while (mdr.Read())
                    {
                        autotxtcoor12.Add(mdr.GetString(0));
                    }

                    txtsearchvoters.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txtsearchvoters.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtsearchvoters.AutoCompleteCustomSource = autotxtcoor12;
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
            autotxtbarangay();
            txtsearchvoters.Focus();
            Leaderselect = "Barangay";
            txtsearchvoters.Enabled = true;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            txtsearchvoters.Clear();
            btnprintvoters.Enabled = true;
            txtsearchvoters.Focus();
            Leaderselect = "Leader";
            autotxtleader();
            txtsearchvoters.Enabled = true;
        }
        private void button_WOC1_Click(object sender, EventArgs e)
        {

            if (txtsearchvoters.Text == "")
            {
                MessageBox.Show("Please Enter the Name of Leader or the Barangay");
            }
            else
            {
                if (Leaderselect == "Barangay")
                {
                    try
                    {
                        CRTBarvoters cr = new CRTBarvoters();
                        conn = new MySqlConnection();
                        conn.ConnectionString = connString;
                        conn.Open();

                        // string sql = "SELECT * from users where UID ='" +textBox1.Text+"' ";
                        string sql = "Select * From voterslist where Barangay LIKE '%" + txtsearchvoters.Text + "%' ORDER BY VotersID DESC";
                        DataSet ds = new DataSet();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                        adapter.Fill(ds, "voterslist");
                        DataTable dt = ds.Tables["voterslist"];

                        cr.SetDataSource(ds.Tables["voterslist"]);
                        crptviewvoters.ReportSource = cr;
                        crptviewvoters.Refresh();

                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                else if (Leaderselect == "Leader")
                {
                    try
                    {
                        CRTLeadvoters cr = new CRTLeadvoters();
                        conn = new MySqlConnection();
                        conn.ConnectionString = connString;
                        conn.Open();

                        // string sql = "SELECT * from users where UID ='" +textBox1.Text+"' ";
                        string sql = "Select * From voterslist where leader LIKE '%" + txtsearchvoters.Text + "%' ORDER BY fullname ASC";
                        DataSet ds = new DataSet();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                        adapter.Fill(ds, "voterslist");
                        DataTable dt = ds.Tables["voterslist"];

                        cr.SetDataSource(ds.Tables["voterslist"]);
                        crptviewvoters.ReportSource = cr;
                        crptviewvoters.Refresh();

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

        private void PrintVoters_Load(object sender, EventArgs e)
        {

        }
    }
}
