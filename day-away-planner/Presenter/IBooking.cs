using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        List<dynamic> BookingList();
        List<dynamic> BookingFilter(List<bool> filters);
        bool BookingCreate(Models.Client client, Models.Activity activity, Models.Venue venue, string date, string time, string cost, string extras);
        void BookingToPay(int bookingID);
    }
}


