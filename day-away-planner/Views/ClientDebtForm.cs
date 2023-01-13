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
    public partial class ClientDebtForm : Form
    {
        public ClientDebtForm()
        {
        }

        public ClientDebtForm(object window)
        {
            InitializeComponent();
        }

        public object Client_Booked_date { get; internal set; }
    }
}
