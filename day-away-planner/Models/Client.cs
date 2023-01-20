//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w18029848@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk
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
