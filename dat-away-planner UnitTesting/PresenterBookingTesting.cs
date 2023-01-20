//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w18029848@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk
using day_away_planner.Models;
using day_away_planner.Presenter;
using day_away_planner.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace day_away_planner_UnitTesting
{
    [TestClass]
    public class PresenterBookingTesting
    {
        private day_away_planner.Presenter.Booking booking = new day_away_planner.Presenter.Booking();
        [TestMethod]
        public void TestBookingType()
        {
            day_away_planner.Presenter.Booking testBooking = new day_away_planner.Presenter.Booking();
            Assert.IsInstanceOfType(testBooking, typeof(day_away_planner.Presenter.Booking));
        }
        [TestMethod]
        public void TestGetSetBookingID()
        {
            booking.BookingID = 1;
            Assert.AreEqual(1, booking.BookingID);
        }
        [TestMethod]
        public void TestGetSetBookingActivityID()
        {
            booking.BookingActivityID = 1;
            Assert.AreEqual(1, booking.BookingActivityID);
        }
        [TestMethod]
        public void TestGetSetBookingClientID()
        {
            booking.BookingClientID = 1;
            Assert.AreEqual(1, booking.BookingClientID);
        }
        [TestMethod]
        public void TestGetSetBookingVenueID()
        {
            booking.BookingVenueID = 1;  
            Assert.AreEqual(1, booking.BookingVenueID);
        }
        [TestMethod]
        public void TestGetSetBookingConfirmation()
        {
            booking.BookingConfirmation = false;
            Assert.IsFalse(booking.BookingConfirmation);
            booking.BookingConfirmation = true;
            Assert.IsTrue(booking.BookingConfirmation);
        }
        [TestMethod]
        public void TestGetSetBookingDate()
        {
            booking.BookingDate = new DateTime(2000, 4, 16);
            Assert.AreEqual(booking.BookingDate, new DateTime(2000, 4, 16));
        }
        [TestMethod]
        public void TestGetSetEventDate()
        {
            booking.BookingEventDate = new DateTime(2000, 4, 20);
            Assert.AreEqual(booking.BookingEventDate, new DateTime(2000, 4, 20));
        }
        [TestMethod]
        public void TestGetSetBookingCancellation()
        {
            booking.BookingCancellation = false;
            Assert.IsFalse(booking.BookingCancellation);
            booking.BookingCancellation = true;
            Assert.IsTrue(booking.BookingCancellation);
        }
        [TestMethod]
        public void TestGetSetCancellationDate()
        {
            booking.BookingCancellationDate = new DateTime(2000, 4, 17);
            Assert.AreEqual(booking.BookingCancellationDate, new DateTime(2000, 4, 17));
        }
        [TestMethod]
        public void TestGetAllBookings()
        {
            var context = new MyDBEntities();
            List<dynamic> bookingList = new List<dynamic>();
            bookingList = booking.BookingList(context);
            Assert.IsNotNull(bookingList);
        }
        [TestMethod]
        public void TestBookingCreate()
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
            bool updated = booking.BookingCreate(client, activity, venue, date, time, cost, extras, bookingContext, clientContext, bookingCreate);
            Assert.IsFalse(updated);
        }
        [TestMethod]
        public void TestBookingToPay()
        {
            MyDBEntities bookingContext = new MyDBEntities();
            MyDBEntities clientContext = new MyDBEntities();
            booking.BookingToPay(1, bookingContext, clientContext, false);
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void TestBookingClientFilter()
        {
            string client1 = string.Empty;
            string client2 = "Skyler Cam";
            string company1 = string.Empty;
            string company2 = "Gourmet Sandwich";

            List<dynamic> noClientNoCompany = booking.BookingClientFilter(client1, company1, CreateContext());
            List<dynamic> clientNoCompany = booking.BookingClientFilter(client2, company1, CreateContext());
            List<dynamic> noClientCompany = booking.BookingClientFilter(client1, company2, CreateContext());
            List<dynamic> clientCompany = booking.BookingClientFilter(client2, company2, CreateContext());

            try
            {
                object value = noClientNoCompany.ElementAt(0);
            }
            catch (Exception ex)
            {
                Assert.IsNotNull(ex);
            }

            try
            {
                object value = clientNoCompany.ElementAt(0);
            }
            catch (Exception ex)
            {
                Assert.IsNotNull(ex);
            }

            try
            {
                object value = noClientCompany.ElementAt(0);
            }
            catch (Exception ex)
            {
                Assert.IsNotNull(ex);
            }

            object trueValue = clientCompany.ElementAt(0);
            Assert.IsNotNull(trueValue);
        }

        [TestMethod]
        public void TestBookingFilter()
        { 
            List<bool> getAll = new List<bool> { true, true, true, true, true, true };
            List<bool> getNone = new List<bool> { false, false, false, false, false };
            List<bool> getDebt = new List<bool> { false, true, true, true, true, true };
            List<bool> getNoDebt = new List<bool> { true, false, true, true, true, true };

            List<dynamic> all = booking.BookingFilter(getAll, CreateContext());
            List<dynamic> none = booking.BookingFilter(getNone, CreateContext());
            List<dynamic> debt = booking.BookingFilter(getDebt, CreateContext());
            List<dynamic> nodebt = booking.BookingFilter(getNoDebt, CreateContext());

            try
            {
                object value = none.ElementAt(0);
            }
            catch (Exception ex)
            {
                Assert.IsNotNull(ex);
            }

            object allValues = all.ElementAt(0);
            allValues.ToString();
            Assert.IsNotNull(allValues);

            object debtValues = debt.ElementAt(0);
            debtValues.ToString();
            Assert.IsNotNull(debtValues);

            object debtNoValues = nodebt.ElementAt(0);
            debtNoValues.ToString();
            Assert.IsNotNull(debtNoValues);

        }

        private MyDBEntities CreateContext()
        {
            return new MyDBEntities();
        }
    }
}


