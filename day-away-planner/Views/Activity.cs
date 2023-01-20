//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w21052079@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk
using day_away_planner.Models;
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

        private BookingWindow bookingWindow;
        private List<Models.Activity> activities;
        Presenter.Activity activity = new Presenter.Activity();

        public Activity()
        {
            InitializeComponent();
        }

        public Activity(BookingWindow window)
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

        private void activityGridView_RowCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bookingWindow != null)
            {
                bookingWindow.BookingActivity = activities[e.RowIndex];
                this.Close();
            }
            MyDBEntities entity = new MyDBEntities();
            activityGridView.DataSource = activity.getActivityList(entity);

        }

        private void Activity_Load(object sender, EventArgs e)
        {
            MyDBEntities entity= new MyDBEntities();    
            activities = activity.getActivityList(entity);
            activityGridView.DataSource = activities;
        }
    }
}
