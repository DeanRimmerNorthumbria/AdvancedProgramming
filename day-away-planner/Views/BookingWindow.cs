using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Views
{
    internal class BookingWindow
    {
        private Presenter.Booking booking = new Presenter.Booking();
        public BookingWindow()
        {

        }

        public Models.Client BookingClient { get; set; }

        public List<dynamic> BookingList()
        {
            return booking.BookingList();
        }

        public List<dynamic> BookingFilter(List<bool> filters)
        {
            return booking.BookingFilter(filters);
        }

    }
}
