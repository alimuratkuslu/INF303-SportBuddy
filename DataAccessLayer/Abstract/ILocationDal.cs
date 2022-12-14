using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ILocationDal
    {
        List<Location> GetAllLocations();
        void SaveLocation(Location location);
        void DeleteLocation(Location location);
        void UpdateLocation(Location location);
        Location GetLocationById(int id);
    }
}

