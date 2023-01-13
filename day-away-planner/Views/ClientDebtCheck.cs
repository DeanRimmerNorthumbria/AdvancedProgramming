using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day_away_planner.Views
{
    public partial class ClientDebtCheck : Form
    {
        string bookingID;
        public ClientDebtCheck(string bID)
        {
            this.bookingID = bID;
            InitializeComponent();
        }

        private void Check_Debt_Click(object sender, EventArgs e)
        {
            int bookingIntID = int.Parse(bookingID);
            Models.MyDBEntities context = new Models.MyDBEntities();
            Models.Booking bookingFind = context.Bookings.Find(bookingIntID);
            DateTime bookingDateTime = bookingFind.BookingEventDate;

            double clientDebt;
            if (double.TryParse(Client_Debt.Text, out clientDebt))
            {
                if (clientDebt > 0)
                {  
                    DateTime currentDate = DateTime.Now;
                    DateTime Client_Booked_Date = bookingDateTime;

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
                else
                {
                    MessageBox.Show("There is no debt");
                }
            }
            else
            {
                MessageBox.Show("Invalid debt value entered");
            }
        }

        private void ClientDebtCheck_Load(object sender, EventArgs e)
        {

        }
    }
}

