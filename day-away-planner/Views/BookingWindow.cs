using day_away_planner.Models;
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
            MyDBEntities DBcontext = new MyDBEntities();    
            return booking.BookingList(DBcontext);
        }

        public List<dynamic> BookingFilter(List<bool> filters)
        {
            MyDBEntities bookingContext = new MyDBEntities();
            return booking.BookingFilter(filters, bookingContext);
        }

        public List<dynamic> BookingClientFilter(string clientName, string clientCompany)
        {
            MyDBEntities bookingContext = new MyDBEntities();
            return booking.BookingClientFilter(clientName, clientCompany, bookingContext);
        }

        public void PayBooking(int bookingID)
        {
            MyDBEntities bookingContext = new MyDBEntities();
            MyDBEntities clientContext = new MyDBEntities();
            Presenter.Booking bp = new Presenter.Booking();
            bp.BookingToPay(bookingID, bookingContext, clientContext, true);
        }

        public bool BookingCreate(Models.Client client, Models.Activity activity, Models.Venue venue, string date, string time, string cost, string extras)
        {
            Presenter.Booking bookingPresenter = new Presenter.Booking();
            MyDBEntities bookingContext = new MyDBEntities();
            MyDBEntities clientContext = new MyDBEntities();
            bookingPresenter.BookingCreate(client, activity, venue, date, time, cost, extras, bookingContext, clientContext, true);
            return true;
        }

    }
}
