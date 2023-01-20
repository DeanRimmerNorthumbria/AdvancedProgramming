using day_away_planner.Models;
using day_away_planner.Presenter;
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
    public partial class Booking : Form
    {
        BookingWindow window = new BookingWindow();
        
        public Booking()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn bookingButton = new DataGridViewButtonColumn();
            bookingButton.Name = "PayBooking";
            bookingButton.HeaderText = "Pay Booking";
            bookingButton.Text = "Pay Booking";
            bookingButton.UseColumnTextForButtonValue = true;
            bookingGridView.Columns.Insert(0, bookingButton);
            MyDBEntities context = new MyDBEntities();
            bookingGridView.DataSource = window.BookingList(context);    
        }

        private void bookingGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (bookingGridView.Columns[e.ColumnIndex].Name == "PayBooking")
            {
                DialogResult dr = MessageBox.Show("Has this booking been paid and confirmed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int bookingID = (Int32)bookingGridView.Rows[e.RowIndex].Cells[1].Value;
                    MyDBEntities bookingContext= new MyDBEntities();
                    MyDBEntities clientContext= new MyDBEntities();
                    window.PayBooking(bookingID, true, clientContext, bookingContext);  
                }
            }
            else
            {
                ClientDebtCheck debt = new ClientDebtCheck(this.bookingGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                debt.Client_Booked_Date.Text = this.bookingGridView.CurrentRow.Cells[9].Value.ToString();
                debt.Client_Debt.Text = this.bookingGridView.CurrentRow.Cells[8].Value.ToString();
                debt.Client_Name.Text = this.bookingGridView.CurrentRow.Cells[6].Value.ToString();
                debt.Client_Company.Text = this.bookingGridView.CurrentRow.Cells[7].Value.ToString();
                debt.ShowDialog();
            }
        }

        private void eventUnpaid_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void eventPaid_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();   
        }

        private List<bool> checkFilters()
        {
            List<bool> filterValues = new List<bool>();
            filterValues.Add(eventPaid.Checked);
            filterValues.Add(eventUnpaid.Checked);
            filterValues.Add(bookingProposed.Checked);
            filterValues.Add(bookingConfirmed.Checked);
            filterValues.Add(bookingCancelled.Checked);  
            filterValues.Add(bookingCompleted.Checked);

            return filterValues;
        }

        private void applyFilters()
        {
            MyDBEntities context = new MyDBEntities();
            bookingGridView.DataSource = window.BookingFilter(checkFilters(), context);
            bookingGridView.Refresh();
        }

        private void bookingProposed_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void bookingConfirmed_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void bookingCancelled_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void bookingCompleted_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void createNewBooking_Click(object sender, EventArgs e)
        {
            NewBooking newBooking = new NewBooking(window);
            newBooking.Show();
        }
    }
}
