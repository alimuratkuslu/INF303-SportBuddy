using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class LocationRepository : ILocationDal
    {

        private readonly Context context;

        public void DeleteLocation(Location location)
        {
            throw new NotImplementedException();
        }

        public List<Location> GetAllLocations()
        {
            throw new NotImplementedException();
        }

        public Location GetLocationById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveLocation(Location location)
        {
            throw new NotImplementedException();
        }

        public void UpdateLocation(Location location)
        {
            throw new NotImplementedException();
        }
    }
}

