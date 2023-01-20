using day_away_planner.Models;
using System;
using System.Collections.Generic;
//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w18029848@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk

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
        private BookingWindow bookingWindow;
        private List<Models.Venue> venues;
        Presenter.Venue venue = new Presenter.Venue();
        public Venue()
        {
            InitializeComponent();
        }

        internal Venue(BookingWindow window)
        {
            this.bookingWindow = window;
            InitializeComponent();
            back.Enabled = false;
        }

        private void Venue_Load(object sender, EventArgs e)
        {
            MyDBEntities DbEntities = new MyDBEntities();
            venues = venue.VenueList(DbEntities);
            venueGridView.DataSource = venues;
        }

        private void venueGridView_RowCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bookingWindow != null)
            {
                bookingWindow.BookingVenue = venues[e.RowIndex];
                this.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}
