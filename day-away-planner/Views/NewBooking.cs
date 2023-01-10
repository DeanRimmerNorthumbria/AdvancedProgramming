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
    }
}
