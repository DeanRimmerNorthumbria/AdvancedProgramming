//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w18029848@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace day_away_planner_UnitTesting
{
    [TestClass]
    public class ViewsBookingTesting
    {
        [TestMethod]
        public void TestBookingNoArgs()
        {
            day_away_planner.Views.Booking booking = new day_away_planner.Views.Booking();
            Assert.IsInstanceOfType(booking, typeof(day_away_planner.Views.Booking));
        }
    }
}
