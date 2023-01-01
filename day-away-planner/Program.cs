using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using day_away_planner.Models;

namespace day_away_planner
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            using (var context = new MyDBEntities())
            {

                //var venueList = context.Venues.ToList<Venue>();
                //Venue a = new Venue();
                //a.VenueName = "Test";
                //a.VenueCost = 1;
                //a.VenueLocation = "animal3";
                //Console.WriteLine(a.VenueLocation);
                //context.Venues.Add(a);
                //context.SaveChanges();

            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}