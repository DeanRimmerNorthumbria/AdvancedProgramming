//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w21052079@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        [Required]
        public int BookingActivityID { get; set; }
        [Required]
        public int BookingClientID { get; set; }
        [Required]
        public int BookingVenueID { get; set; }
        [Required]
        public bool BookingConfirmation { get; set; }
        [Required, Column(TypeName = "datetime2")]
        public DateTime BookingDate { get; set; }
        [Required, Column(TypeName = "datetime2")]
        public DateTime BookingEventDate { get; set; }
        [Required]
        public bool BookingCancellation { get; set; }
        [Column(TypeName= "datetime2")]
        public DateTime BookingCancellationDate { get; set; }
    }
}
