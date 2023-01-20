//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w18029848@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk

using day_away_planner.Models;
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

        bool BookingCreate(Models.Client client, Models.Activity activity, Models.Venue venue, string date, string time, string cost, string extras, bool bookingCreate,MyDBEntities clientContext, MyDBEntities bookingContext);

        void PayBooking(int bookingID, bool confirmBooking,MyDBEntities clientContext, MyDBEntities bookingContext);

        List<dynamic> BookingList(MyDBEntities context);

        List<dynamic> BookingClientFilter(string clientName, string clientCompany, MyDBEntities context);

        List<dynamic> BookingFilter(List<bool> filters, MyDBEntities context);
    }
}
