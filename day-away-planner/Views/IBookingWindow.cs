using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Views
{
    interface IBookingWindow
    {
        Models.Client BookingClient { get; set; }

        Models.Activity BookingActivity { get; set; }

        Models.Venue BookingVenue { get; set; }

        bool BookingCreate(Models.Client client, Models.Activity activity, Models.Venue venue, string date, string time, string cost, string extras);

        void PayBooking(int bookingID);

        List<dynamic> BookingList();

        List<dynamic> BookingClientFilter(string clientName, string clientCompany);

        List<dynamic> BookingFilter(List<bool> filters);
    }
}
