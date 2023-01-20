//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w18029848@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk
using day_away_planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Presenter
{
    public class Activity
    {

        public Activity()
        {


        }


        public List<Models.Activity> getActivityList(MyDBEntities entityContext)
        {
            using (var context = entityContext)
            {
                var activityList = context.Activities.ToList<Models.Activity>();
                return activityList;
            }
        }

    }

}
