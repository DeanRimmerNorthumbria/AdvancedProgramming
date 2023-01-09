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
    public partial class Venue : Form
    {
        public Venue()
        {
            InitializeComponent();
        }

        private void Venue_Load(object sender, EventArgs e)
        {
            Presenter.Venue venue = new Presenter.Venue();

            venueGridView.DataSource= venue.VenueList();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void venueGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
