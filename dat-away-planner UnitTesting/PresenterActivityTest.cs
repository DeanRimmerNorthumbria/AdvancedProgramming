//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w18029848@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk
using day_away_planner.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace day_away_planner_UnitTesting
{
    [TestClass]
    public class PresenterActivityTest
    {
        private day_away_planner.Presenter.Activity activity = new day_away_planner.Presenter.Activity();

        [TestMethod]
        public void TestGetAllActivities()
        {
            var context = new MyDBEntities();
            var activityList = activity.getActivityList(context);
            Assert.IsNotNull(activityList[0].ActivityID);
            Assert.IsInstanceOfType(activityList[0], typeof(day_away_planner.Models.Activity));
        }
    }
}
