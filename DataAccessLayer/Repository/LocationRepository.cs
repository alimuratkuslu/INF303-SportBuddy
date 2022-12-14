using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repository
{
    public class LocationRepository : ILocationDal
    {

        private readonly Context _context;

        public LocationRepository(Context context)
        {
            _context = context;
        }

        public void DeleteLocation(Location location)
        {
            _context.Remove(location);
            _context.SaveChanges();
        }

        public List<Location> GetAllLocations()
        {
            return _context.location.ToList();
        }

        public Location GetLocationById(int id)
        {
            return _context.location.Find(id);
        }

        public void SaveLocation(Location location)
        {
            _context.Add(location);
            _context.SaveChanges();
        }

        public void UpdateLocation(Location location)
        {
            _context.Update(location);
            _context.SaveChanges();
        }
    }
}

