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
using System.Configuration;

namespace VotersInfomationSystem
{
    public partial class DashUserConrol : UserControl
    {
        public DashUserConrol()
        {
            InitializeComponent();
        }

        private void DashUserConrol_Load(object sender, EventArgs e)
        {


            //This Area for my Chart Database Link
            string constring = "server = localhost; user id = root; database = teamjocas";
            MySqlConnection conn = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand("select * from voterslist", conn);
            MySqlDataReader myReader;
            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    this.chart1.Series["Name"].Points.AddXY(myReader.GetString("fullname"), myReader.GetString("age"));

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            /* Displaying Data from database to label
            try
            {
            MySqlConnection sqlcon = new MySqlConnection("server = localhost; user id = root; database = teamjocas");
            sqlcon.Open();
            MySqlDataAdapter sa = new MySqlDataAdapter("select *  from voterslist", sqlcon);
            DataSet dts = new DataSet();
            sa.Fill(dts);

            foreach (DataRow dr in dts.Tables[0].Rows)
            {
                lbltotalvoters.Text += dts.Tables[0].Rows[0]["fullname"].ToString();

            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            */
        }



    }
    
}
