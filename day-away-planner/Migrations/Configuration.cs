using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace day_away_planner.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using day_away_planner.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<day_away_planner.Models.MyDBEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        
        protected override void Seed(day_away_planner.Models.MyDBEntities context)
        {
            context.Venues.AddOrUpdate(x => x.VenueID,
                new Venue() { VenueID = 100, VenueName = "The Walsall Hub", VenueCost = 236.89, VenueLocation = "31A Stafford Street, Walsall WS2 8DG", VenueCapacity = 100},
                new Venue() { VenueID = 101, VenueName = "The Abbey Hotel Golf and Spa", VenueCost = 1134.34, VenueLocation = "Hither Green Lane, Dagnell End Rd, Redditch B98 9BE", VenueCapacity = 100 },
                new Venue() { VenueID = 102, VenueName = "Elmhay Park", VenueCost = 232.56, VenueLocation = "Frome, Somerset BA11 2PB", VenueCapacity = 100 },
                new Venue() { VenueID = 103, VenueName = "The Halfway House Inn", VenueCost = 241.23, VenueLocation = "The Haflway House Inn, Bridgnorth WV16 5LS", VenueCapacity = 100 },
                new Venue() { VenueID = 104, VenueName = "Wookey Hole Hotel", VenueCost = 721.263, VenueLocation = "The Mill, Wookey Hole, Wells BA5 1BA", VenueCapacity = 100 },
                new Venue() { VenueID = 105, VenueName = "The Hen & Chicken", VenueCost = 2661.23, VenueLocation = "210 North Street, Bristol BS3 1JF", VenueCapacity = 123, VenueExtras = "Optional Open Bar"},
                new Venue() { VenueID = 106, VenueName = "The Assembly Rooms", VenueCost = 211.23, VenueLocation = "Fenkle St, Newcastle Upon Tyne Ne1 5XU", VenueCapacity = 312, VenueExtras = "Optional Open Bar" },
                new Venue() { VenueID = 107, VenueName = "Mayfair Suite", VenueCost = 564.23, VenueLocation = "Park Lane, Sandwell B21 8LE", VenueCapacity = 231, VenueExtras = "Optional Overnight Stay" },
                new Venue() { VenueID = 108, VenueName = "Pennard House", VenueCost = 241.23, VenueLocation = "East Pennard, Shepton Mallet BA4 6TP", VenueCapacity = 111, VenueExtras = "Optinal Morning Breakfast" },
                new Venue() { VenueID = 109, VenueName = "The Laverton", VenueCost = 661.23, VenueLocation = "The Laverton Bratton Rd, Westbury BA13 3EN", VenueCapacity = 123, VenueExtras = "Optional Upcycling Workshop" }
            );

            context.Clients.AddOrUpdate(x => x.ClientID,
                new Client() {ClientID = 1, ClientName = "Bob Test", ClientDepartment = "Sales", ClientCompany = "Bloom Marketing", ClientDebt = 0, ClientArrears = false},
                new Client() {ClientID = 2, ClientName = "Kayley Vail", ClientDepartment = "Marketing", ClientCompany = "Bloom Marketing", ClientDebt = 0, ClientArrears = false},
                new Client() { ClientID = 3, ClientName = "Frank Carrington", ClientDepartment = "Accounting", ClientCompany = "Hearty Pancake", ClientDebt = 233.45, ClientArrears = false },
                new Client() { ClientID = 4, ClientName = "Clayton Wynn", ClientDepartment = "Sales", ClientCompany = "The Auto DNA", ClientDebt = 0, ClientArrears = false },
                new Client() { ClientID = 5, ClientName = "Temple Raleigh", ClientDepartment = "Accounting", ClientCompany = "Urban Philosophy", ClientDebt = 233.45, ClientArrears = false },
                new Client() { ClientID = 6, ClientName = "Skyler Cam", ClientDepartment = "Marketing", ClientCompany = "Gourmet Sandwich", ClientDebt = 0, ClientArrears = false },
                new Client() { ClientID = 7, ClientName = "Tegan Spencer", ClientDepartment = "Accounting", ClientCompany = "Office Tile", ClientDebt = 0, ClientArrears = false },
                new Client() { ClientID = 8, ClientName = "Ansley Christan", ClientDepartment = "Marketing", ClientCompany = "The Crunchy Croissant", ClientDebt = 0, ClientArrears = false },
                new Client() { ClientID = 9, ClientName = "Brice Ken", ClientDepartment = "Sales", ClientCompany = "Smart Phone Repair", ClientDebt = 0, ClientArrears = false },
                new Client() { ClientID = 10, ClientName = "Kimberley Raleigh", ClientDepartment = "Sales", ClientCompany = "Ready Continental", ClientDebt = 0, ClientArrears = false },
                new Client() { ClientID = 11, ClientName = "Piper Kit", ClientDepartment = "Accounting", ClientCompany = "Service Scientist", ClientDebt = 233.45, ClientArrears = false },
                new Client() { ClientID = 12, ClientName = "Avery Page", ClientDepartment = "Marketing", ClientCompany = "House Brush", ClientDebt = 0, ClientArrears = false },
                new Client() { ClientID = 13, ClientName = "Linsey Ainslee", ClientDepartment = "Accounting", ClientCompany = "Office Brush", ClientDebt = 0, ClientArrears = false },
                new Client() { ClientID = 14, ClientName = "Halley Kim", ClientDepartment = "Sales", ClientCompany = "Brew Bean", ClientDebt = 0, ClientArrears = false },
                new Client() { ClientID = 15, ClientName = "Jeanelle Caine", ClientDepartment = "Marketing", ClientCompany = "Trendy Scissor", ClientDebt = 233.45, ClientArrears = false }
            );

            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}