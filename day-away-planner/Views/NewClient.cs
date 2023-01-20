//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w21052079@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day_away_planner.Views
{
    public partial class NewClient : Form
    {
        public NewClient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Would you like to close this Window", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmation of Signup");
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = radioButton1.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged Into Account");
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = radioButton2.Checked;
        }

        private void NewClient_Load(object sender, EventArgs e)
        {

        }
    }
}
