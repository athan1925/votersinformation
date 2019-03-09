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
    public partial class AddVoters : UserControl
    {
        MySqlConnection conn;
        string connString = "server = localhost; user id = root; database = teamjocas";
        public static string sendtext = "";

        public AddVoters()
        {
            InitializeComponent();
            Autocompletesearch();
            Autocompleteleader();
            Lstview();
            lblerror.Visible = false;
            lblerror.Text = "This Voter is Already Exist Copy this Manually";
            lbllead.Text = "";
            lblleadername.Text = "";
            lblleaderran.Text = "Leader";
            //lblerror.Visible = false;
            //lbllead.Visible = false;
            // panel1.Visible = false;
            DisableText();


        }

        private void AddVoters_Load(object sender, EventArgs e)
        {
            
        }
        void Cleartext()
        {

           
            txtcn.Text = "";
            txtadd.Text = "";
            txtbar.Text = "";
            txtbd.Text = "";
            txtage.Text = "";
            txtpn.Text = "";
            txtvn.Text = "";
            txtlead.Text = "";
        

        }

        void Autocompleteleader()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = connString;
            conn.Open();
            string sql = "Select fullname From leaderlist";
            MySqlCommand msqlc = new MySqlCommand(sql, conn);
            MySqlDataReader mdr = msqlc.ExecuteReader();
            AutoCompleteStringCollection autotxtleader = new AutoCompleteStringCollection();

            while (mdr.Read())
            {
                autotxtleader.Add(mdr.GetString(0));
            }

            txtlead.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtlead.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtlead.AutoCompleteCustomSource = autotxtleader;
            conn.Close();
        }
        void Autocompletesearch()
        {
            
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                string sql = "Select fullname From source";
                MySqlCommand msqlc = new MySqlCommand(sql, conn);
                MySqlDataReader mdr = msqlc.ExecuteReader();
                AutoCompleteStringCollection autotxtsearch = new AutoCompleteStringCollection();

                while (mdr.Read())
                {
                    autotxtsearch.Add(mdr.GetString(0));
                }

                txtsearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtsearch.AutoCompleteCustomSource = autotxtsearch;
                conn.Close();

         }
        void DisableText()
        {
            
            txtvn.Enabled = false;
            txtcn.Enabled = false;
            txtadd.Enabled = false;
            txtbar.Enabled = false;
            txtbd.Enabled = false;
            txtage.Enabled = false;
            txtpn.Enabled = false;


        }

        void ThisenableText()
        {
            
            txtvn.Enabled = true;
            txtcn.Enabled = true;
            txtadd.Enabled = true;
            txtbar.Enabled = true;
            txtbd.Enabled = true;
            txtage.Enabled = true;
            txtpn.Enabled = true;


        }
        void Lstview()
        {
            lvaddvoters.GridLines = false;
            lvaddvoters.View = View.Details;
            lvaddvoters.FullRowSelect = true;


            //Add Column Header

            lvaddvoters.Columns.Add("CNo.", 80);
            lvaddvoters.Columns.Add("FullName", 250);
            lvaddvoters.Columns.Add("Address", 160);
            lvaddvoters.Columns.Add("Barangay", 120);
            lvaddvoters.Columns.Add("Birthdate", 90);
            lvaddvoters.Columns.Add("Age", 80);
            lvaddvoters.Columns.Add("PrecintNo", 130);

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            lblerror.Visible = false;
            lvaddvoters.Enabled = true;
            lblleadername.Text = "";
            lbllead.Text = "";
            lblleaderran.Visible = false;
            btn_save.Visible = true;


            string sql = "Select VotersId,Fullname, Address ,Barangay,Birthdate,Age,PrecintNo From Source where Fullname LIKE '%" + txtsearch.Text + "%'";
            MySqlConnection cnn = new MySqlConnection(connString);
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader Reader = cmd.ExecuteReader();

            lvaddvoters.Items.Clear();

            while (Reader.Read())
            {

                ListViewItem lv = new ListViewItem(Reader.GetString(0));
                lv.SubItems.Add(Reader.GetString(1));
                lv.SubItems.Add(Reader.GetString(2));
                lv.SubItems.Add(Reader.GetString(3));
                lv.SubItems.Add(Reader.GetString(4));
                lv.SubItems.Add(Reader.GetString(5));
                lv.SubItems.Add(Reader.GetString(6));
                lvaddvoters.Items.Add(lv);


            }

            Reader.Close();
            cnn.Close();
        }

        private void txtlead_TextChanged(object sender, EventArgs e1)
        {
          
        }

        private void lvaddvoters_MouseClick(object sender, MouseEventArgs e)
        {
            String id = lvaddvoters.SelectedItems[0].SubItems[0].Text;
            String fname = lvaddvoters.SelectedItems[0].SubItems[1].Text;
            String add = lvaddvoters.SelectedItems[0].SubItems[2].Text;
            String brgy = lvaddvoters.SelectedItems[0].SubItems[3].Text;
            String idbday = lvaddvoters.SelectedItems[0].SubItems[4].Text;
            String age = lvaddvoters.SelectedItems[0].SubItems[5].Text;
            String pn = lvaddvoters.SelectedItems[0].SubItems[6].Text;

            txtcn.Text = id;
            txtvn.Text = fname;
            txtadd.Text = add;
            txtbar.Text = brgy;
            txtbd.Text = idbday;
            txtage.Text = age;
            txtpn.Text = pn;
            txtlead.Enabled = true;
            txtlead.Focus();
            Autocompleteleader();



        }

        

        private void txtvn_TextChanged(object sender, EventArgs e)
        {
            
            MySqlConnection sqlcon2 = new MySqlConnection("server = localhost; user id = root; database = teamjocas");
            string sql123 = "select count(fullname) from voterslist where fullname = '" + txtvn.Text + "'";
            MySqlCommand msqa = new MySqlCommand(sql123, sqlcon2);
            sqlcon2.Open();
            int temp = Convert.ToInt32(msqa.ExecuteScalar().ToString());
            if (temp > 0)
            {

                sendtext = txtvn.Text;
                lblerror.Visible = true;
                lblleaderran.Visible = true;
                btn_save.Enabled = false;
                lbllead.Text = AddVoters.sendtext;

                string source = ("server = localhost; user id = root; database = teamjocas");
                MySqlConnection msql = new MySqlConnection(source);
                msql.Open();
                string sql = "Select Fullname,Leader From voterslist where Fullname LIKE '%" + lbllead.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(sql, msql);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                    lblleadername.Text = (dr["leader"].ToString());
                    lvaddvoters.Enabled = false;
                    MessageBox.Show("This Voter Already Exist Please Copy the Information Below");
                    lblleaderran.Visible = true;
                   
                    txtlead.Enabled = false;

                    txtsearch.Focus();
                    lvaddvoters.Items.Clear();



                }


            }

            else
            {

                btn_save.Enabled = true;
                lvaddvoters.Enabled = true;
            }
            }

      

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
           /// MessageBox.Show("Test");
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do You Want to save this Voter?", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                //Do something
                try
                {

                    if (txtlead.Text == "")
                    {
                        MessageBox.Show("Please Enter or Type Last Name of the Leader");
                    }
                    else
                    {
                        MySqlConnection sqlcon = new MySqlConnection("server = localhost; user id = root; database = teamjocas");
                        sqlcon.Open();
                        MySqlDataAdapter sa = new MySqlDataAdapter("insert into voterslist(votersId, fullname, address,barangay, birthdate, age,precintNo,Leader)  values ('" + txtcn.Text + "', '" + txtvn.Text + "', '" + txtadd.Text + "', '" + txtbar.Text + "', '" + txtbd.Text + "', '" + txtage.Text + "','" + txtpn.Text + "','" + txtlead.Text + "' )", sqlcon);
                        DataTable dt = new DataTable();
                        sa.Fill(dt);
                        sqlcon.Close();
                        MessageBox.Show("New Voter of TEAM JOCAS succesfully Added");
                    }

                }

                catch (Exception e1)
                {
                    MessageBox.Show("Error during insert: " + e1.Message);
                }
            }
            else
            {
                MessageBox.Show("Your Entry not succesfully Saved");
                txtsearch.Text = "";

            }

            txtsearch.Focus();
            Cleartext();
            lvaddvoters.Items.Clear();

        }

        private void txtlead_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btn_save.Select();

            }
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                lvaddvoters.Select();

            }

        }
    }
}
