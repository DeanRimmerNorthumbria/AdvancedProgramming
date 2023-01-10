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
    public partial class Client : Form
    {
        private BookingWindow bookingWindow;
        private List<Models.Client> clients;
        public Client()
        {
            InitializeComponent();
        }

        internal Client(BookingWindow window)
        {
            this.bookingWindow = window;
            InitializeComponent();
            back.Enabled = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            Presenter.Client client = new Presenter.Client();
            clients = client.ClientList();
            clientGridView.DataSource = clients;
        }

        private void clientGridView_RowCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(bookingWindow != null)
            {
               bookingWindow.BookingClient = clients[e.RowIndex];
               this.Close();
            }
        }
    }
}
