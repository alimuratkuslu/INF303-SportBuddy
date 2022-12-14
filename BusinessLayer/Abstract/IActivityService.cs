using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IActivityService
    {
        void SaveActivity(Activity activity);
        void DeleteActivity(Activity activity);
        void UpdateActivity(Activity activity);
        List<Activity> GetAllActivities();
        Activity GetById(int id);
    }
}

