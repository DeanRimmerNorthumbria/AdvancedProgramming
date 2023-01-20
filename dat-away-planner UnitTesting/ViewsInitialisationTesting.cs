using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace day_away_planner_UnitTesting
{
    [TestClass]
    public class ViewsInitialisationTesting
    {
        day_away_planner.Views.BookingWindow window = new day_away_planner.Views.BookingWindow();
        [TestMethod]
        public void TestClientNoArgs()
        {
            day_away_planner.Views.Client client = new day_away_planner.Views.Client();
            Assert.IsInstanceOfType(client, typeof(day_away_planner.Views.Client));
        }
        [TestMethod]
        public void TestClientbookingdetailsNoArgs()
        {
            day_away_planner.Views.Clientbookingdetails clientbookingdetails = new day_away_planner.Views.Clientbookingdetails();
            Assert.IsInstanceOfType(clientbookingdetails, typeof(day_away_planner.Views.Clientbookingdetails));
        }
        [TestMethod]
        public void TestClientDebtCheckNoArgs()
        {
            day_away_planner.Views.ClientDebtCheck clientDebtCheck = new day_away_planner.Views.ClientDebtCheck("1");
            Assert.IsInstanceOfType(clientDebtCheck, typeof(day_away_planner.Views.ClientDebtCheck));
        }
        [TestMethod]
        public void TestNewBookingArgs()
        {
            day_away_planner.Views.NewBooking newBooking = new day_away_planner.Views.NewBooking(window);
            Assert.IsInstanceOfType(newBooking, typeof(day_away_planner.Views.NewBooking));
        }
        [TestMethod]
        public void TestNewClientNoArgs()
        {
            day_away_planner.Views.NewClient newClient = new day_away_planner.Views.NewClient();
            Assert.IsInstanceOfType(newClient, typeof(day_away_planner.Views.NewClient));
        }
        [TestMethod]
        public void TestVenueNoArgs()
        {
            day_away_planner.Views.Venue venue = new day_away_planner.Views.Venue();
            Assert.IsInstanceOfType(venue, typeof(day_away_planner.Views.Venue));
        }
    }
}
