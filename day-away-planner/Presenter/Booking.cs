using day_away_planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Presenter
{
    internal class Booking : IBooking
    {
        public Booking()
        {


        }

        public int BookingID { get; set; }
        public int BookingActivityID { get; set; }
        public int BookingClientID { get; set; }
        public int BookingVenueID { get; set; }
        public bool BookingConfirmation { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime BookingEventDate { get; set; }
        public bool BookingCancellation { get; set; }
        public DateTime BookingCancellationDate { get; set; }
        public List<dynamic> BookingList()
        {
            using (var context = new MyDBEntities())
            {
                var query =
                    from booking in context.Bookings
                    join ven in context.Venues on booking.BookingVenueID equals ven.VenueID
                    join act in context.Activities on booking.BookingActivityID equals act.ActivityID
                    join cli in context.Clients on booking.BookingClientID equals cli.ClientID
                    select new {bookingID = booking.BookingID, venueName = ven.VenueName, venueLoation = ven.VenueLocation, ven.VenueCapacity ,act.ActivityName, 
                        cli.ClientName, cli.ClientCompany, booking.BookingEventDate, booking.BookingConfirmation, booking.BookingCancellation, booking.BookingCancellationDate};

                List<dynamic> data = new List<dynamic>();
                foreach (var item in query)
                {
                    data.Add(item); 
                }
                
                return data;

            }
            
        }
    }
}
