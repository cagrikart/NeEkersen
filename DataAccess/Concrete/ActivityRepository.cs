using DataAccess.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ActivityRepository : IActivityRepository
    {
        public Activity CreateActivity(Activity activity)
        {
            using (var activityDb = new DataDbContext())
            {
                activityDb.Activities.Add(activity);  
                activityDb.SaveChanges();
                return activity;
            }
        }

        public void DeleteActivity(Guid id)
        {
            using (var activity = new DataDbContext())
            {
                var deleteActivity = GetActivityById(id);
                activity.Activities.Remove(deleteActivity);
                activity.SaveChanges(); 

            }
        }

        public Activity GetActivityById(Guid id)
        {
            using (var activity = new DataDbContext())
            {
                return activity.Activities.Find(id);
            }
        }

        public List<Activity> GetAllActivity()
        {
            using (var activity = new DataDbContext ())
            {
                return activity.Activities.ToList();
            }
        }

        public Activity UpdateActivity(Activity activity)
        {
            using (var activityDb = new DataDbContext())
            {
                activityDb.Activities.Update(activity);
                activityDb.SaveChanges();
                return activity;

            }
        }
    }
}
