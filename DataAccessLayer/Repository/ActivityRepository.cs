using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class ActivityRepository : IActivityDal
    {

        private readonly Context context;

        public void DeleteActivity(Activity activity)
        {
            throw new NotImplementedException();
        }

        public Activity GetActivityById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Activity> GetAllActivites()
        {
            throw new NotImplementedException();
        }

        public void SaveActivity(Activity activity)
        {
            throw new NotImplementedException();
        }

        public void UpdateActivity(Activity activity)
        {
            throw new NotImplementedException();
        }
    }
}

