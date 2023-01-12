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

        private Presenter.Client client = new Presenter.Client();
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
            else
            {
                Clientbookingdetails cd = new Clientbookingdetails();
                cd.Client_Name.Text = this.clientGridView.CurrentRow.Cells[1].Value.ToString();
                cd.Company_Name.Text = this.clientGridView.CurrentRow.Cells[2].Value.ToString();
                cd.Client_Department.Text = this.clientGridView.CurrentRow.Cells[3].Value.ToString();
                cd.ShowDialog();
            }
        }

        private void companyName_TextChanged(object sender, EventArgs e)
        {
            var search = companyName.Text;
            if (search != "")
            {
                clientGridView.DataSource = client.FindClients(search);
            }
            else
            {
                clientGridView.DataSource = client.ClientList();
            }
        }

        private void createNewClient_Click(object sender, EventArgs e)
        {
            NewClient c = new NewClient();
            c.Show();
        }

        private void clientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
