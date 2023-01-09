using day_away_planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Presenter
{
    internal class Activity
    {

        public Activity()
        {


        }


        public List<Models.Activity> getActivityList()
        {
            using (var context = new MyDBEntities())
            {
                var activityList = context.Activities.ToList<Models.Activity>();
                return activityList;
            }
        }

    }

}
