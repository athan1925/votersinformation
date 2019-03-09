using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotersInfomationSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard(string passobject)
        {
            InitializeComponent();
            timer1.Enabled = true;
            lblusername.Text = passobject;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashUserConrol1.BringToFront();
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            addCoor1.BringToFront();
            sidepanel.Height = button4.Height;
            sidepanel.Top = button4.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addVoters1.BringToFront();
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addLeader1.BringToFront();
            sidepanel.Height = button3.Height;
            sidepanel.Top = button3.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printVoters1.BringToFront();
            sidepanel.Height = button5.Height;
            sidepanel.Top = button5.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            printLeader1.BringToFront();
            sidepanel.Height = button7.Height;
            sidepanel.Top = button7.Top;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
            System.Environment.Exit(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printSummary1.BringToFront();
            sidepanel.Height = button6.Height;
            sidepanel.Top = button6.Top;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
            System.Environment.Exit(0);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dashUserConrol1.BringToFront();
            
        }

        private void addVoters1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void printSummary1_Load(object sender, EventArgs e)
        {

        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_lbl.Text = DateTime.Now.ToString();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
            System.Environment.Exit(0);
        }
    }
}
