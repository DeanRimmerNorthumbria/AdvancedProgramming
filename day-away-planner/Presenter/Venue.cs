using day_away_planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Presenter
{
    public class Venue : IVenue
    {
        public Venue()
        {


        }

        public int VenueID { get; set; }
        public string VenueName { get; set; }
        public double VenueCost { get; set; }
        public string VenueExtras { get; set; }
        public string VenueLocation { get; set; }
        public int VenueCapacity { get; set; }

        public List<Models.Venue> VenueList(MyDBEntities DbEntities)
        {
            using (var context = DbEntities)
            {
                var venueList = context.Venues.ToList<Models.Venue>();
                return venueList;
            }
        }
    }
}
//send all data to front and present in table