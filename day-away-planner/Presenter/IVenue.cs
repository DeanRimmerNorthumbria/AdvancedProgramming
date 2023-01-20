//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w21052079@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk
using day_away_planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Presenter
{
    interface IVenue
    {
        int VenueID { get; set; }
        string VenueName { get; set; }
        double VenueCost { get; set; }
        string VenueExtras { get; set; }
        string VenueLocation { get; set; }
        int VenueCapacity { get; set; }

        List<Models.Venue> VenueList(MyDBEntities DbEntities);
    }
}
