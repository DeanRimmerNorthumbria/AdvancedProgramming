using day_away_planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Presenter
{
    internal class Booking
    {
        public Booking()
        {


        }


        public List<dynamic> getBookingList()
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
