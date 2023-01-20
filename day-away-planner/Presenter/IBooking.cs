//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w18029848@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using day_away_planner.Models;

namespace day_away_planner.Presenter
{
    interface IBooking
    {
        int BookingID { get; set; }
        int BookingActivityID { get; set; }
        int BookingClientID { get; set; }
        int BookingVenueID { get; set; }
        bool BookingConfirmation { get; set; }
        DateTime BookingDate { get; set; }
        DateTime BookingEventDate { get; set; }
        bool BookingCancellation { get; set; }
        DateTime BookingCancellationDate { get; set; }
        List<dynamic> BookingList(MyDBEntities DBcontext);
        List<dynamic> BookingFilter(List<bool> filter, MyDBEntities bookingContext);
        bool BookingCreate(Models.Client client, Models.Activity activity, Models.Venue venue, string date, string time, string cost, string extras, MyDBEntities bookingContext, MyDBEntities clientContext, bool createBooking);
        List<dynamic> BookingClientFilter(string clientName, string clientCompany, MyDBEntities bookingContext);
        void BookingToPay(int bookingID, MyDBEntities bookingContext, MyDBEntities clientContext, bool confirmBooking);
    }
}


