using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Models { 
public class Venue
{
    [Key]
    public int VenueID { get; set; }
    [Required]
    public string VenueName { get; set; }
    [Required]
    public double VenueCost { get; set; }
    public string VenueExtras { get; set; }
    [Required]
    public string VenueLocation { get; set; }
    [Required]
    public int VenueCapacity { get; set; }
}

}
