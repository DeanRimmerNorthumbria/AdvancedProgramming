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
    public partial class Clientbookingdetails : Form
    {
        BookingWindow window = new BookingWindow();

        public Clientbookingdetails()
        {
            InitializeComponent();
        }

        private void clientNewbooking_Click(object sender, EventArgs e)
        {
            NewBooking d = new NewBooking(window);
            d.Show();
            
        }

        private void Clientbookingdetails_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = window.BookingClientFilter(Client_Name.Text, Company_Name.Text);
        }
    }
}
