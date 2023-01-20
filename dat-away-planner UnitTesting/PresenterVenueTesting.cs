//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w21052079@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk
using day_away_planner.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace day_away_planner_UnitTesting
{
    [TestClass]
    public class PresenterVenueTesting
    {
        private day_away_planner.Presenter.Venue venue = new day_away_planner.Presenter.Venue();
        [TestMethod]
        public void TestGetSetVenueID()
        {
            venue.VenueID = 1;
            Assert.AreEqual(1, venue.VenueID);
        }
        [TestMethod]
        public void TestGetSetVenueName()
        {
            venue.VenueName = "venue";
            Assert.AreEqual(5, venue.VenueName.Length);
            Assert.AreEqual("venue", venue.VenueName);
        }
        [TestMethod]
        public void TestGetSetVenueCost()
        {
            venue.VenueCost = 1.10;
            Assert.AreEqual(1.10, venue.VenueCost);
            venue.VenueCost += 1.10;
            Assert.AreEqual(2.20, venue.VenueCost);
        }
        [TestMethod]
        public void TestGetSetVenueExtras()
        {
            Assert.IsNull(venue.VenueExtras);
            venue.VenueExtras = "open bar";
            Assert.AreEqual("open bar", venue.VenueExtras);
        }
        [TestMethod]
        public void TestGetSetVenueLocation()
        {
            venue.VenueLocation = "Newcastle";
            Assert.AreEqual("Newcastle", venue.VenueLocation);
        }
        [TestMethod]
        public void TestGetAllClients()
        {
            var context = new MyDBEntities();
            var venueList = venue.VenueList(context);
            Assert.IsNotNull(venueList[0].VenueID);
            Assert.IsInstanceOfType(venueList[0], typeof(day_away_planner.Models.Venue));
        }
    }
}
