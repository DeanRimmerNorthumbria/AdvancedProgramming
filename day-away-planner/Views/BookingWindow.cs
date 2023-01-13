using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Views
{
    internal class BookingWindow : IBookingWindow
    {
        private Presenter.Booking booking = new Presenter.Booking();
        public BookingWindow()
        {

        }

        public Models.Venue BookingVenue { get; set; }

        public Models.Client BookingClient { get; set; }

        public Models.Activity BookingActivity { get; set; }

        public List<dynamic> BookingList()
        {
            return booking.BookingList();
        }

        public List<dynamic> BookingFilter(List<bool> filters)
        {
            return booking.BookingFilter(filters);
        }

        public void PayBooking(int bookingID)
        {
            Presenter.Booking bp = new Presenter.Booking();
            bp.BookingToPay(bookingID);
        }

        public bool BookingCreate(Models.Client client, Models.Activity activity, Models.Venue venue, string date, string time, string cost, string extras)
        {
              
            Presenter.Booking bookingPresenter = new Presenter.Booking();
            bookingPresenter.BookingCreate(client, activity, venue, date, time, cost, extras);
            return true;
        }

    }
}
