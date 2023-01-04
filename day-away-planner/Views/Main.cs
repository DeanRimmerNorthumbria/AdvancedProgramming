using day_away_planner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day_away_planner
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void venueButton_Click(object sender, EventArgs e)
        {
            Views.Venue venue = new Views.Venue();
            venue.Show();
            this.Hide();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            Views.Client client = new Views.Client();
            client.Show();
            this.Hide();
        }

        private void activityButton_Click(object sender, EventArgs e)
        {
            Views.Activity activity = new Views.Activity();
            activity.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
