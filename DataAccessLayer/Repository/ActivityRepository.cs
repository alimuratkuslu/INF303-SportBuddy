using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class ActivityRepository : IActivityDal
    {

        private readonly Context _context;

        public ActivityRepository(Context context)
        {
            _context = context;
        }

        public void DeleteActivity(Activity activity)
        {
            _context.Remove(activity);
            _context.SaveChanges();
        }

        public Activity GetActivityById(int id)
        {
            return _context.activity.Find(id);
        }

        public List<Activity> GetAllActivites()
        {
            return _context.activity.ToList();
        }

        public void SaveActivity(Activity activity)
        {
            _context.Add(activity);
            _context.SaveChanges();
        }

        public void UpdateActivity(Activity activity)
        {
            _context.Update(activity);
            _context.SaveChanges();
        }
    }
}

