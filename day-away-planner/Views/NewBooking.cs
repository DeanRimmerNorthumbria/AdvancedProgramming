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

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void who_Click(object sender, EventArgs e)
        {
            Console.WriteLine(window.BookingClient.ClientName);
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
            MessageBox.Show("Booking Created Confirmation will be sent out");
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Would you like to Close this Window?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }
    }
}
