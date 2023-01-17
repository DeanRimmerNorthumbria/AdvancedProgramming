using day_away_planner.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace dat_away_planner_UnitTesting
{
    [TestClass]
    public class ModelBookingTesting
    {
        [TestMethod]
        public void TestBookingID_IsKey()
        {
            // Arrange
            var prop = typeof(Booking).GetProperty("BookingID");

            // Act
            var keyAttr = prop.GetCustomAttribute<KeyAttribute>();

            // Assert
            Assert.IsNotNull(keyAttr);
        }

        [TestMethod]
        public void TestBookingActivityID_IsRequired()
        {
            var prop = typeof(Booking).GetProperty("BookingActivityID");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNotNull(requiredAttr);
        }

        [TestMethod]
        public void TestBookingClientID_IsRequired()
        {
            var prop = typeof(Booking).GetProperty("BookingClientID");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNotNull(requiredAttr);
        }
        [TestMethod]
        public void TestBookingVenueID_IsRequired()
        {
            var prop = typeof(Booking).GetProperty("BookingVenueID");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNotNull(requiredAttr);
        }
        [TestMethod]
        public void TestBookingConfirmation_IsRequired()
        {
            var prop = typeof(Booking).GetProperty("BookingConfirmation");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNotNull(requiredAttr);
        }
        [TestMethod]
        public void TestBookingDate_IsRequired()
        {
            var prop = typeof(Booking).GetProperty("BookingDate");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNotNull(requiredAttr);
        }
        [TestMethod]
        public void TestBookingDate_IsDatetime2()
        {
            var prop = typeof(Booking).GetProperty("BookingDate");
            var columnAttr = prop.GetCustomAttribute<ColumnAttribute>();
            Assert.IsNotNull(columnAttr);
            Assert.AreEqual(columnAttr.TypeName, "datetime2");
        }

        [TestMethod]
        public void TestBookingEventDate_IsRequired()
        {
            var prop = typeof(Booking).GetProperty("BookingEventDate");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNotNull(requiredAttr);
        }
        [TestMethod]
        public void TestBookingEventDate_IsDatetime2()
        {
            var prop = typeof(Booking).GetProperty("BookingEventDate");
            var columnAttr = prop.GetCustomAttribute<ColumnAttribute>();
            Assert.IsNotNull(columnAttr);
            Assert.AreEqual(columnAttr.TypeName, "datetime2");
        }

        [TestMethod]
        public void TestBookingCancellation_IsRequired()
        {
            var prop = typeof(Booking).GetProperty("BookingCancellation");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNotNull(requiredAttr);
        }
        [TestMethod]
        public void TestBookingCancellationDate_IsNotRequired()
        {
            var prop = typeof(Booking).GetProperty("BookingCancellationDate");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNull(requiredAttr);
        }
        [TestMethod]
        public void TestBookingCancellationDate_IsDatetime2()
        {
            var prop = typeof(Booking).GetProperty("BookingCancellationDate");
            var columnAttr = prop.GetCustomAttribute<ColumnAttribute>();
            Assert.IsNotNull(columnAttr);
            Assert.AreEqual(columnAttr.TypeName, "datetime2");
        }

    }
}
