using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Presenter
{
    interface IClient
    {
        int VenueID { get; set; }
        string VenueName { get; set; }
        double VenueCost { get; set; }
        string VenueExtras { get; set; }
        string VenueLocation { get; set; }
        int VenueCapacity { get; set; }

        List<Models.Client> ClientList();
    }
}

