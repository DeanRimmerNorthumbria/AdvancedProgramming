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

        private Presenter.Client client = new Presenter.Client();
        public Client()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            clientGridView.DataSource = client.ClientList();
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
    }
}
