﻿using day_away_planner.Presenter;
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
    public partial class Booking : Form
    {
        BookingWindow window = new BookingWindow();
        
        public Booking()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            bookingGridView.DataSource = window.BookingList();
        }

        private void bookingGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eventUnpaid_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void eventPaid_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();   
        }

        private List<bool> checkFilters()
        {
            List<bool> filterValues = new List<bool>();
            filterValues.Add(eventPaid.Checked);
            filterValues.Add(eventUnpaid.Checked);
            filterValues.Add(bookingProposed.Checked);
            filterValues.Add(bookingConfirmed.Checked);
            filterValues.Add(bookingCancelled.Checked);  
            filterValues.Add(bookingCompleted.Checked);

            return filterValues;
        }

        private void applyFilters()
        {
            bookingGridView.DataSource = window.BookingFilter(checkFilters());
            bookingGridView.Refresh();
        }

        private void bookingProposed_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void bookingConfirmed_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void bookingCancelled_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void bookingCompleted_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void createNewBooking_Click(object sender, EventArgs e)
        {
            NewBooking newBooking = new NewBooking(window);
            newBooking.Show();
            this.Hide();
        }
    }
}
