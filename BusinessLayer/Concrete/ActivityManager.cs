using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ActivityManager : IActivityService
    {
        private readonly IActivityDal activityDal;

        public ActivityManager(IActivityDal activityDal)
        {
            this.activityDal = activityDal;
        }

        public void DeleteActivity(Activity activity)
        {
            activityDal.DeleteActivity(activity);
        }

        public List<Activity> GetAllActivities()
        {
            return activityDal.GetAllActivites();
        }

        public Activity GetById(int id)
        {
            return activityDal.GetActivityById(id);
        }

        public void SaveActivity(Activity activity)
        {
            activityDal.SaveActivity(activity);
        }

        public void UpdateActivity(Activity activity)
        {
            activityDal.UpdateActivity(activity);
        }
    }
}

