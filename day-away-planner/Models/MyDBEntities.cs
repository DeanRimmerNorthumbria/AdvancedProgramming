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