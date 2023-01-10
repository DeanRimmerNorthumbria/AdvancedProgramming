using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Views
{
    interface IBookingWindow
    {
        Models.Client BookingClient { get; set; }

        Models.Activity BookingActivity { get; set; }

        Models.Venue BookingVenue { get; set; }

        List<dynamic> BookingList();

        List<dynamic> BookingFilter(List<bool> filters);
    }
}
