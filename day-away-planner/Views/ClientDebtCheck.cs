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
    public partial class ClientDebtCheck : Form
    {
        public ClientDebtCheck()
        {
            InitializeComponent();
        }

        private void Check_Debt_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            DateTime Client_Booked_Date = DateTime.Parse("12/12/2021");
            int daysSinceBooking = (currentDate - Client_Booked_Date).Days;

            if (daysSinceBooking > 60)
            {
                // Debt is more than 60 days overdue
                MessageBox.Show("Red flag: Debt is more than 60 days overdue");
            }
            else
            {
                // Debt is not overdue
                MessageBox.Show("Debt is not overdue");
            }
        }
    }
}
