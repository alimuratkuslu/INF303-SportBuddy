using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ILocationService
    {
        void SaveLocation(Location location);
        void DeleteLocation(Location location);
        void UpdateLocation(Location location);
        List<Location> GetAllLocations();
        Location GetById(int id);
    }
}

