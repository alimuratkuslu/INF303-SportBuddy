using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class AdminRepository : IAdminDal
    {

        private readonly Context _context;

        public void DeleteAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }

        public Admin GetAdminById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetAllAdmins()
        {
            throw new NotImplementedException();
        }

        public void SaveAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void UpdateAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }
    }
}

