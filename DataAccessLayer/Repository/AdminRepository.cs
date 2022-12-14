using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class AdminRepository : IAdminDal
    {

        private readonly Context _context;

        public AdminRepository(Context context)
        {
            _context = context;
        }

        public void DeleteAdmin(Admin admin)
        {
            _context.Remove(admin);
            _context.SaveChanges();
        }

        public Admin GetAdminById(int id)
        {
            return _context.admin.Find(id);
        }

        public List<Admin> GetAllAdmins()
        {
            return _context.admin.ToList();
        }

        public void SaveAdmin(Admin admin)
        {
            _context.Add(admin);
            _context.SaveChanges();
        }

        public void UpdateAdmin(Admin admin)
        {
            _context.Update(admin);
            _context.SaveChanges();
        }
    }
}

