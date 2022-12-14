using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {

        private readonly IAdminDal adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            this.adminDal = adminDal;
        }

        public void DeleteAdmin(Admin admin)
        {
            adminDal.DeleteAdmin(admin);
        }

        public List<Admin> GetAllAdmins()
        {
            return adminDal.GetAllAdmins();
        }

        public Admin GetById(int id)
        {
            return adminDal.GetAdminById(id);
        }

        public void SaveAdmin(Admin admin)
        {
            adminDal.SaveAdmin(admin);
        }

        public void UpdateAdmin(Admin admin)
        {
            adminDal.UpdateAdmin(admin);
        }
    }
}

