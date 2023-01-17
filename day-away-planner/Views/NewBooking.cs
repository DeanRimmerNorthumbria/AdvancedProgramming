using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace day_away_planner.Views
{
    public partial class NewBooking : Form
    {
        private BookingWindow window;
        private bool isDateCorrect = false;
        private bool isTimeCorrect = false;
        private bool isExtraCostCorrect = true;
        internal NewBooking(BookingWindow currentWindow)
        {
            this.window = currentWindow;
            InitializeComponent();
        }

        private void selectClient_Click(object sender, EventArgs e)
        {
            Client c = new Client(window);
            c.Show();
            checkChanged();
        }

        private void NewBooking_Load(object sender, EventArgs e)
        {

        }

        private void who_Click(object sender, EventArgs e)
        {
            label14.Text = window.BookingClient.ClientName;
        }

        private void modifyClient_Click(object sender, EventArgs e)
        {
            Client c = new Client(window);
            c.Show();
            checkChanged();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double totalCost;
            if(textBox5.Text.Length > 0)
            {
                string value  = textBox5.Text;
                double extra = Convert.ToDouble(value);
                totalCost =  extra + window.BookingActivity.ActivityCost + window.BookingVenue.VenueCost;
            }
            else
            {
                totalCost = window.BookingActivity.ActivityCost + window.BookingVenue.VenueCost;
            }
            
            DialogResult dr = MessageBox.Show("Total Price: " + Convert.ToString(totalCost), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                window.BookingCreate(window.BookingClient, window.BookingActivity, window.BookingVenue, textBox4.Text, textBox3.Text, Convert.ToString(totalCost), textBox6.Text);
                MessageBox.Show("Booking Created Confirmation will be sent out");
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Would you like to Close this Window?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void selectActivity_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            Activity a = new Activity(window);
            a.Show();
            checkChanged();
        }

        private void what_Click(object sender, EventArgs e)
        {
            label13.Text = window.BookingActivity.ActivityName + ", price: £" + window.BookingActivity.ActivityCost;
        }

        private void selectVenue_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            Venue v = new Venue(window);
            v.Show();
            checkChanged();
        }

        private void where_Click(object sender, EventArgs e)
        {
            label12.Text = window.BookingVenue.VenueName + ", price: £" + window.BookingVenue.VenueCost;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            isTimeCorrect= false;
            checkBox1.Checked = false;
            string text = textBox3.Text;
            var result = Regex.Match(text, "^[0-2][0-9]:[0-5][0-9]$", RegexOptions.IgnoreCase);

            if (result.Success)
            {
                label9.Text = "\u2714";
                isTimeCorrect= true;
                label9.ForeColor= Color.DarkGreen;
                checkChanged();
            }
            else
            {
                label9.Text = "Please follow correct time syntax: hh:mm";
                label9.ForeColor = Color.Red;
                isTimeCorrect = false;
                checkChanged();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            isDateCorrect = false;
            checkBox1.Checked = false;
            string text = textBox4.Text;
            var result = Regex.Match(text, "^[0-3][0-9]/[0-1][0-9]/[1-2][0-9][0-9][0-9]$", RegexOptions.IgnoreCase);

            if (result.Success)
            {
                isDateCorrect= true;
                label10.Text = "\u2714";
                label10.ForeColor = Color.DarkGreen;
                checkChanged();
            }
            else
            {
                isDateCorrect = false;
                label10.Text = "Please follow correct date syntax: dd/mm/yyyy";
                label10.ForeColor = Color.Red;
                checkChanged();
            }
        }

        private void checkChanged()
        {
            if(textBox6.Text.Length == 0)
            {
                isExtraCostCorrect = true;
            }

            if (isDateCorrect && isTimeCorrect && checkBox1.Checked && isExtraCostCorrect && (window.BookingVenue != null) && (window.BookingClient != null) && (window.BookingActivity != null))
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;    
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if(textBox6.Text.Length > 0)
            {
                textBox5.Enabled = true;
                isExtraCostCorrect = false;
                checkChanged();
            } else
            {
                textBox5.Enabled = false;
                textBox5.Text = string.Empty;
                isExtraCostCorrect = true;
                checkChanged();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string text = textBox5.Text;
            var result = Regex.Match(text, "^[0-9]+\\.?[0-9]*$", RegexOptions.IgnoreCase);

            if (result.Success)
            {
                isExtraCostCorrect = true;
                label11.Text = "\u2714";
                label11.ForeColor = Color.DarkGreen;
                checkChanged();
            }
            else
            {
                isExtraCostCorrect = false;
                label11.Text = "Please follow correct price syntax: xxxx.yy";
                label11.ForeColor = Color.Red;
                checkChanged();
            }
        }
    }
}
