using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IActivityDal
    {
        List<Activity> GetAllActivites();
        void SaveActivity(Activity activity);
        void DeleteActivity(Activity activity);
        void UpdateActivity(Activity activity);
        Activity GetActivityById(int id);
    }
}

