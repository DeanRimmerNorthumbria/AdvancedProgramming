using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        [Required]
        public string ClientName { get; set; }
        [Required]
        public string ClientCompany { get; set; }
        [Required]
        public string ClientDepartment { get; set; }
        [Required]
        public double ClientDebt { get; set; }
        [Required]
        public bool ClientArrears { get; set; }
    }
}
