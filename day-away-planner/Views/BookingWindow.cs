//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w18029848@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk

using day_away_planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Views
{
    public class BookingWindow : IBookingWindow
    {
        private Presenter.Booking booking = new Presenter.Booking();
        public BookingWindow()
        {

        }

        public Models.Venue BookingVenue { get; set; }

        public Models.Client BookingClient { get; set; }

        public Models.Activity BookingActivity { get; set; }

        public List<dynamic> BookingList(MyDBEntities context)
        {
            MyDBEntities DBcontext = context;    
            return booking.BookingList(DBcontext);
        }

        public List<dynamic> BookingFilter(List<bool> filters, MyDBEntities context)
        {
            MyDBEntities bookingContext = context;
            return booking.BookingFilter(filters, bookingContext);
        }

        public List<dynamic> BookingClientFilter(string clientName, string clientCompany, MyDBEntities context)
        {
            MyDBEntities bookingContext = context;
            return booking.BookingClientFilter(clientName, clientCompany, bookingContext);
        }

        public void PayBooking(int bookingID, bool confirmBooking, MyDBEntities clientContext, MyDBEntities bookingContext)
        {
            Presenter.Booking bp = new Presenter.Booking();
            bp.BookingToPay(bookingID, bookingContext, clientContext, confirmBooking);
        }

        public bool BookingCreate(Models.Client client, Models.Activity activity, Models.Venue venue, string date, string time, string cost, string extras, bool bookingCreate, MyDBEntities clientContext, MyDBEntities bookingContext)
        {
            Presenter.Booking bookingPresenter = new Presenter.Booking();
            return bookingPresenter.BookingCreate(client, activity, venue, date, time, cost, extras, bookingContext, clientContext, bookingCreate);
        }

    }
}
