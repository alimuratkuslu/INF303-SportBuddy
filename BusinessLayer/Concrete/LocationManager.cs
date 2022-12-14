using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class LocationManager : ILocationService
    {

        private readonly ILocationDal locationDal;

        public LocationManager(ILocationDal locationDal)
        {
            this.locationDal = locationDal;
        }

        public void DeleteLocation(Location location)
        {
            locationDal.DeleteLocation(location);
        }

        public List<Location> GetAllLocations()
        {
            return locationDal.GetAllLocations();
        }

        public Location GetById(int id)
        {
            return locationDal.GetLocationById(id);
        }

        public void SaveLocation(Location location)
        {
            locationDal.SaveLocation(location);
        }

        public void UpdateLocation(Location location)
        {
            locationDal.UpdateLocation(location);
        }
    }
}

