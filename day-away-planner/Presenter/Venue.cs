using day_away_planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Presenter
{
    internal class Venue
    {
        public Venue()
        {


        }

        public List<Models.Venue> getVenueList()
        {
            using (var context = new MyDBEntities())
            {
                var venueList = context.Venues.ToList<Models.Venue>();
                return venueList;
            }
        }
    }
}
//send all data to front and present in table