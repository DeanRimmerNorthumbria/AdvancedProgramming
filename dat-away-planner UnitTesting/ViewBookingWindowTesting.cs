//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w18029848@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk
using day_away_planner.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace day_away_planner_UnitTesting
{
    [TestClass]
    public class ViewBookingWindowTesting
    {
        day_away_planner.Views.BookingWindow window = new day_away_planner.Views.BookingWindow();
        [TestMethod]
        public void TestBookingWindowNoArgs()
        {
            day_away_planner.Views.BookingWindow bookingWindow = new day_away_planner.Views.BookingWindow();
            Assert.IsInstanceOfType(bookingWindow, typeof(day_away_planner.Views.BookingWindow));
        }
        [TestMethod]
        public void TestBookingWindowVenueGetSet()
        {
            day_away_planner.Models.Venue venue = new day_away_planner.Models.Venue();
            Assert.IsNull(window.BookingVenue);
            window.BookingVenue = venue;
            Assert.IsNotNull(window.BookingVenue);
            Assert.IsInstanceOfType(window.BookingVenue, typeof(day_away_planner.Models.Venue));
        }
        [TestMethod]
        public void TestBookingWindowActivityGetSet()
        {
            day_away_planner.Models.Activity activity = new day_away_planner.Models.Activity();
            Assert.IsNull(window.BookingActivity);
            window.BookingActivity = activity;
            Assert.IsNotNull(window.BookingActivity);
            Assert.IsInstanceOfType(window.BookingActivity, typeof(day_away_planner.Models.Activity));
        }
        [TestMethod]
        public void TestBookingWindowClientGetSet()
        {
            day_away_planner.Models.Client client = new day_away_planner.Models.Client();
            Assert.IsNull(window.BookingClient);
            window.BookingClient = client;
            Assert.IsNotNull(window.BookingClient);
            Assert.IsInstanceOfType(window.BookingClient, typeof(day_away_planner.Models.Client));
        }
        [TestMethod]
        public void TestBookingClientFilter()
        {
            string client1 = string.Empty;
            string client2 = "Skyler Cam";
            string company1 = string.Empty;
            string company2 = "Gourmet Sandwich";

            List<dynamic> noClientNoCompany = window.BookingClientFilter(client1, company1, CreateContext());
            List<dynamic> clientNoCompany = window.BookingClientFilter(client2, company1, CreateContext());
            List<dynamic> noClientCompany = window.BookingClientFilter(client1, company2, CreateContext());
            List<dynamic> clientCompany = window.BookingClientFilter(client2, company2, CreateContext());

            try
            {
                object value = noClientNoCompany[0];
            }
            catch (Exception ex)
            {
                Assert.IsNotNull(ex);
            }

            try
            {
                object value = clientNoCompany[0];
            }
            catch (Exception ex)
            {
                Assert.IsNotNull(ex);
            }

            try
            {
                object value = noClientCompany[0];
            }
            catch (Exception ex)
            {
                Assert.IsNotNull(ex);
            }

            object trueValue = clientCompany[0];
            Assert.IsNotNull(trueValue);
        }

        [TestMethod]
        public void TestBookingFilter()
        {
            List<bool> getAll = new List<bool> { true, true, true, true, true, true };
            List<bool> getNone = new List<bool> { false, false, false, false, false };
            List<bool> getDebt = new List<bool> { false, true, true, true, true, true };
            List<bool> getNoDebt = new List<bool> { true, false, true, true, true, true };

            List<dynamic> all = window.BookingFilter(getAll, CreateContext());
            List<dynamic> none = window.BookingFilter(getNone, CreateContext());
            List<dynamic> debt = window.BookingFilter(getDebt, CreateContext());
            List<dynamic> nodebt = window.BookingFilter(getNoDebt, CreateContext());

            try
            {
                object value = none[0];
            }
            catch (Exception ex)
            {
                Assert.IsNotNull(ex);
            }

            object allValues = all[0];
            allValues.ToString();
            Assert.IsNotNull(allValues);

            object debtValues = debt[0];
            debtValues.ToString();
            Assert.IsNotNull(debtValues);

            object debtNoValues = nodebt[0];
            debtNoValues.ToString();
            Assert.IsNotNull(debtNoValues);

        }
        [TestMethod]
        public void TestGetAllBookings()
        {
            var context = new MyDBEntities();
            List<dynamic> bookingList = new List<dynamic>();
            bookingList = window.BookingList(context);
            Assert.IsNotNull(bookingList);
        }
        private MyDBEntities CreateContext()
        {
            return new MyDBEntities();
        }
        [TestMethod]
        public void TestBookingWindowCreate()
        {
            MyDBEntities bookingContext = new MyDBEntities();
            MyDBEntities clientContext = new MyDBEntities();
            day_away_planner.Models.Activity activity = new day_away_planner.Models.Activity();
            day_away_planner.Models.Venue venue = new day_away_planner.Models.Venue();
            day_away_planner.Models.Client client = new day_away_planner.Models.Client();
            string date = "12/12/2023";
            string time = "12:45";
            string cost = "122.24";
            string extras = "";
            bool bookingCreate = false;
            bool updated = window.BookingCreate(client, activity, venue, date, time, cost, extras, bookingCreate, bookingContext, clientContext);
            Assert.IsFalse(updated);
        }
        [TestMethod]
        public void TestBookingWindowToPay()
        {
            MyDBEntities bookingContext = new MyDBEntities();
            MyDBEntities clientContext = new MyDBEntities();
            window.PayBooking(1, false, bookingContext, clientContext);
            Assert.IsTrue(true);
        }
    }
}
