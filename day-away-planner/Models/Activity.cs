using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Models
{
    public class Activity
    {
        [Key]
        public int ActivityID { get; set; }
        [Required]
        public string ActivityName { get; set; }
        [Required]
        public  double ActivityCost { get; set; }

        public string ActivityNote{ get; set; }


    }
}
