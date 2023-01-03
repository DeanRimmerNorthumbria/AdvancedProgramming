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
            Presenter.Client client = new Presenter.Client();

            clientGridView.DataSource = client.getClientList();
        }
    }
}
