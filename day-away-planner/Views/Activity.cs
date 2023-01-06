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
    public partial class Activity : Form
    {
        public Activity()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void activityGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Activity_Load(object sender, EventArgs e)
        {
            Presenter.Activity activity = new Presenter.Activity();

            activityGridView.DataSource = activity.getActivityList();
        }
    }
}
