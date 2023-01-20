using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace day_away_planner_UnitTesting
{
    [TestClass]
    public class ViewsActivityTesting
    {
        [TestMethod]
        public void TestActivityNoArgs()
        {
            day_away_planner.Views.Activity activity = new day_away_planner.Views.Activity();
            Assert.IsInstanceOfType(activity, typeof(day_away_planner.Views.Activity));
        }
        [TestMethod]
        public void TestActivityArgs()
        {
            day_away_planner.Views.BookingWindow window = new day_away_planner.Views.BookingWindow();
            day_away_planner.Views.Activity activity = new day_away_planner.Views.Activity(window);
            Assert.IsInstanceOfType(activity, typeof(day_away_planner.Views.Activity));
        }
    }
}
