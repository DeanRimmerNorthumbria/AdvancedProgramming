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
    public partial class NewBooking : Form
    {
        private BookingWindow window;
        internal NewBooking(BookingWindow currentWindow)
        {
            this.window = currentWindow;
            InitializeComponent();
        }

        private void selectClient_Click(object sender, EventArgs e)
        {
            Client c = new Client(window);
            c.Show();
        }

        private void NewBooking_Load(object sender, EventArgs e)
        {

        }

        private void who_Click(object sender, EventArgs e)
        {
            Console.WriteLine(window.BookingClient.ClientName);
        }

        private void modifyClient_Click(object sender, EventArgs e)
        {
            Client c = new Client(window);
            c.Show();
        }

        private void newClient_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            button2.Enabled = checkBox1.Checked;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            window.BookingCreate(window.BookingClient, window.BookingActivity, window.BookingVenue, textBox4.Text, textBox3.Text, textBox5.Text, textBox6.Text);
            MessageBox.Show("Booking Created Confirmation will be sent out");
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Would you like to Close this Window?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void selectActivity_Click(object sender, EventArgs e)
        {
            Activity a = new Activity(window);
            a.Show();
        }

        private void what_Click(object sender, EventArgs e)
        {
            Console.WriteLine(window.BookingActivity.ActivityName);
        }

        private void selectVenue_Click(object sender, EventArgs e)
        {
            Venue v = new Venue(window);
            v.Show();
        }

        private void where_Click(object sender, EventArgs e)
        {
            Console.WriteLine(window.BookingVenue.VenueName);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
