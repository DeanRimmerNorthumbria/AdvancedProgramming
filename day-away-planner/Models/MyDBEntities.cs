//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w21052079@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Models
{
    public partial class MyDBEntities : DbContext
    {
        public MyDBEntities() : base("conString")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyDBEntities>);
        }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder) { base.OnModelCreating(modelBuilder); }
    }
}